using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubcategoriesManager
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    class Merge : IExternalCommand
    {
        internal static Dictionary<string, Category> catdict = new Dictionary<string, Category>();

        internal static Dictionary<string, Category> subcatsdict = new Dictionary<string, Category>();

        internal static string category = "";      

        internal static List<Category> oldsubcategories = new List<Category>();

        internal static Category newsubcategory = null;

        internal static bool delete = false;

        internal static List<GraphicsStyle> oldstyles = new List<GraphicsStyle>();

        internal static GraphicsStyle newstylecut = null;

        internal static GraphicsStyle newstyleproj = null;

        internal static Dictionary<string, Category> subcatdict = new Dictionary<string, Category>();

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            if (doc.IsFamilyDocument)
            {
                TaskDialog.Show("Error", "Subcategories Manager requires an open Project Document.");

                return Result.Cancelled;
            }

            Categories categories = doc.Settings.Categories;

            catdict = new Dictionary<string, Category>();

            subcatsdict = new Dictionary<string, Category>();

            category = "";

            oldsubcategories = new List<Category>();

            newsubcategory = null;

            foreach (Category category in categories)
            {
                if (category.CanAddSubcategory && category.CategoryType != CategoryType.Internal)
                {
                    if (catdict.ContainsKey(category.Name))
                    {
                        catdict.Add(category.Name + "1", category);
                    }
                    else
                    {
                        catdict.Add(category.Name, category);
                    }                    
                }
            }

            var catdialog = new Dialogs.CategoriesDialog();

            List<string> catlist = catdict.Keys.ToList();

            catlist.Sort();

            catdialog.CategoriesDropdown.DataSource = catlist;

            var dialog = catdialog.ShowDialog();

            if (dialog != DialogResult.OK)
            {
                return Result.Cancelled;
            }

            delete = catdialog.DeleteCheckBox.Checked;

            TransactionGroup tg = new TransactionGroup(doc, "Merge SubCategories");

            int systemcategories = 0;

            tg.Start();

            try
            {
                if (category == "Lines")
                {
                    ReplaceCurveSubcategories(doc, oldsubcategories, newsubcategory);                    
                }
                else
                {
                    IList<Element> families = new FilteredElementCollector(doc).OfClass(typeof(Family)).ToElements();

                    ReplaceFamilySubCategories(doc, families, category, oldsubcategories, newsubcategory);

                    ReplaceModelTextSubCategories(doc, oldsubcategories, newsubcategory);                    
                }

                if (delete)
                {
                    Transaction t1 = new Transaction(doc, "Delete Subcategories");

                    t1.Start();

                    foreach (Category c in oldsubcategories)
                    {
                        if(c.Name != newsubcategory.Name)
                        {
                            try
                            {
                                doc.Delete(c.Id);
                            }
                            catch { systemcategories++; }
                        }                        
                    }

                    t1.Commit();
                }

                tg.Assimilate();

                if (systemcategories > 0)
                {
                    TaskDialog.Show("Warning", "System Subcategories cannot be deleted.");
                }

                return Result.Succeeded;
            }
            catch (Exception e)
            {
                tg.RollBack();

                TaskDialog.Show("Error", e.Message);

                return Result.Failed;
            }            
        }
        private void ReplaceCurveSubcategories(Document doc, List<Category> oldcats, Category newcat)
        {
            IList<Element> curves = new FilteredElementCollector(doc).OfClass(typeof(CurveElement)).ToElements();

            IList<Element> regions = new FilteredElementCollector(doc).OfClass(typeof(FilledRegion)).ToElements();

            string[] forbidden = new string[] { "<Area Boundary>", "<Fabric Envelope>", "<Fabric Sheets>", "<Room Separation>", "<Sketch>", "<Space Separation>", "Axis of Rotation" };

            Transaction t1 = new Transaction(doc, "Change Subcategories");

            t1.Start();

            List<GroupType> grouptypes = new List<GroupType>();            

            foreach (Category oldcat in oldcats)
            {
                foreach (CurveElement c in curves)
                {
                    GraphicsStyle ln = c.LineStyle as GraphicsStyle;

                    if (ln == null | forbidden.Contains(ln.GraphicsStyleCategory.Name))
                    {
                        continue;
                    }
                    if (ln.GraphicsStyleCategory.Name == oldcat.Name)
                    {
                        if (c.GroupId.IntegerValue != -1)
                        {
                            Group grp = doc.GetElement(c.GroupId) as Group;

                            if (!grouptypes.Contains(grp.GroupType))
                            {
                                grouptypes.Add(grp.GroupType);
                            }
                            continue;
                        }

                        if (ln.GraphicsStyleType == GraphicsStyleType.Projection)
                        {
                            c.LineStyle = newcat.GetGraphicsStyle(GraphicsStyleType.Projection);
                        }
                        else
                        {
                            c.LineStyle = newcat.GetGraphicsStyle(GraphicsStyleType.Cut);
                        }                        
                    }                    
                } 
            }

            foreach(FilledRegion r in regions)
            {
                if(r.GroupId.IntegerValue != -1)
                {
                    continue;
                }

                ElementTransformUtils.MoveElement(doc, r.Id, XYZ.BasisX);
                ElementTransformUtils.MoveElement(doc, r.Id, XYZ.BasisX.Negate());
            }

            Dictionary<GroupType, GroupType> swap = new Dictionary<GroupType, GroupType>();

            foreach (GroupType g in grouptypes)
            {
                GroupSet groups = g.Groups;

                if (groups.IsEmpty)
                {
                    continue;
                }

                var enumerator = groups.GetEnumerator();
                enumerator.MoveNext();
                Group group = enumerator.Current as Group;

                Group defaultgroup = doc.Create.PlaceGroup(new XYZ(0, 0, 0), g);

                ICollection<ElementId> groupelements = defaultgroup.UngroupMembers();

                foreach (ElementId id in groupelements)
                {
                    if (doc.GetElement(id) is CurveElement)
                    {
                        foreach (Category oldcat in oldcats)
                        {
                            CurveElement c = doc.GetElement(id) as CurveElement;

                            GraphicsStyle ln = c.LineStyle as GraphicsStyle;

                            if (ln == null | forbidden.Contains(ln.GraphicsStyleCategory.Name))
                            {
                                continue;
                            }
                            if (ln.GraphicsStyleCategory.Name == oldcat.Name)
                            {
                                if (ln.GraphicsStyleType == GraphicsStyleType.Projection)
                                {
                                    c.LineStyle = newcat.GetGraphicsStyle(GraphicsStyleType.Projection);
                                }
                                else
                                {
                                    c.LineStyle = newcat.GetGraphicsStyle(GraphicsStyleType.Cut);
                                }
                            }
                        }                        
                    }
                }

                Group newgrp = doc.Create.NewGroup(groupelements);                

                foreach (Group grp in groups)
                {
                    grp.GroupType = newgrp.GroupType;
                }               

                swap.Add(g, newgrp.GroupType);

                doc.Delete(newgrp.Id);

                doc.Delete(defaultgroup.Id);
            }

            foreach(GroupType gt in swap.Keys)
            {
                string name = gt.Name;

                try
                {
                    doc.Delete(gt.Id);
                }
                catch { }               

                swap[gt].Name = name;
            }

            t1.Commit();
        }
        private void ReplaceFamilySubCategories(Document doc, IList<Element> allfamilies, string category, List<Category> oldcats, Category newcat)
        {
            if(allfamilies.Count == 0)
            {
                return;
            }

            foreach (Family family in allfamilies)
            {
                if (!family.IsValidObject)
                {
                    continue;
                }

                if (!family.IsEditable | family.FamilyCategory == null)
                {
                    continue;
                }

                if(family.FamilyCategory.Name != category)
                {
                    continue;
                }

                Document famdoc = doc.EditFamily(family);

                Category cat = famdoc.OwnerFamily.FamilyCategory;

                CategoryNameMap collcat = cat.SubCategories;

                Dictionary<string, Category> categories = new Dictionary<string, Category>();

                foreach (Category c in collcat)
                {
                    categories[c.Name] = c;
                }

                int count = 0;

                foreach (Category c in oldcats)
                {
                    if (categories.ContainsKey(c.Name))
                    {
                        count++;
                    }
                }

                if(count == 0)
                {
                    continue;
                }

                IList<Element> allforms = new FilteredElementCollector(famdoc).OfClass(typeof(GenericForm)).ToElements();          

                Transaction t1 = new Transaction(famdoc, "Change Subcategory");
                t1.Start();

                if (!categories.ContainsKey(newcat.Name))
                {
                    categories[newcat.Name] = famdoc.Settings.Categories.NewSubcategory(cat, newcat.Name);
                }

                foreach (GenericForm form in allforms)
                {
                    if(form.Subcategory == null)
                    {
                        continue;
                    }
                    foreach (Category oldcat in oldcats)
                    {
                        if (form.Subcategory.Name == oldcat.Name)
                        {
                            form.Subcategory = categories[newcat.Name];
                        }
                    }
                }

                t1.Commit();

                ReplaceModelTextSubCategories(famdoc, oldcats, categories[newcat.Name]);

                ReplaceCurveSubcategories(famdoc, oldcats, categories[newcat.Name]);

                IList<Element> allnestedfamilies = new FilteredElementCollector(famdoc).OfClass(typeof(Family)).ToElements();
                
                ReplaceFamilySubCategories(famdoc, allnestedfamilies, category, oldcats, newcat);

                famdoc.LoadFamily(doc, new FamilyOptions());

                famdoc.Close(false);
            }
        }
        private void ReplaceModelTextSubCategories(Document doc,List<Category> oldcats, Category newcat)
        {
            IList<Element> modeltexts = new FilteredElementCollector(doc).OfClass(typeof(ModelText)).ToElements();

            Transaction t1 = new Transaction(doc, "Change ModelText Subcategory");

            t1.Start();

            foreach (ModelText e in modeltexts)
            {
                if (doc.IsFamilyDocument)
                {
                    foreach (Category oldcat in oldcats)
                    {
                        if (e.Subcategory.Name == oldcat.Name)
                        {
                            e.Subcategory = newcat;
                        }
                    }
                }
                else
                {
                    Parameter p = e.LookupParameter("Subcategory");

                    foreach (Category oldcat in oldcats)
                    {
                        if (p.AsElementId() == oldcat.Id)
                        {
                            p.Set(newcat.Id);
                        }
                    }
                }                               
            }

            t1.Commit();
        }
    }
    class FamilyOptions : IFamilyLoadOptions
    {
        public bool OnFamilyFound(bool familyInUse, out bool overwriteParameterValues)
        {
            overwriteParameterValues = true;
            return true;
        }
        public bool OnSharedFamilyFound(Family sharedFamily, bool familyInUse, out FamilySource source, out bool overwriteParameterValues)
        {
            overwriteParameterValues = true;
            source = FamilySource.Family;
            return true;
        }
    }
}
