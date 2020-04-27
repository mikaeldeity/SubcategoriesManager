using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubcategoriesMerger.Dialogs
{
    public partial class CategoriesDialog : System.Windows.Forms.Form
    {
        public CategoriesDialog()
        {
            InitializeComponent();
        }
        private void CategoriesDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Merge.category = CategoriesDropdown.SelectedItem.ToString();

            if (SubCategoriesDropDown.Items.Count > 0)
            {
                SubcategoriesList.Items.Clear();
            }

            Merge.subcatsdict.Clear();

            List<string> subcategories = new List<string>();

            //Merge.subcatsdict.Add("<None>", Merge.catdict[Merge.category]);
            //subcategories.Add("<None>");
            //SubcategoriesList.Items.Add("<None>", false);

            string[] forbidden = new string[] { "<Area Boundary>","<Fabric Envelope>","<Fabric Sheets>","<Room Separation>","<Sketch>", "<Space Separation>","Axis of Rotation"};

            foreach (Category subcategory in Merge.catdict[Merge.category].SubCategories)
            {
                if (!forbidden.Contains(subcategory.Name))
                {
                    Merge.subcatsdict.Add(subcategory.Name, subcategory);
                    subcategories.Add(subcategory.Name);
                    SubcategoriesList.Items.Add(subcategory.Name, false);
                }                
            }

            subcategories.Sort();           

            SubcategoriesList.Sorted = true;

            SubCategoriesDropDown.DataSource = subcategories;
        }
        private void MergeButton_Click(object sender, EventArgs e)
        {
            var coll = SubcategoriesList.CheckedItems;

            Merge.oldsubcategories.Clear();

            foreach (var obj in coll)
            {
                Merge.oldsubcategories.Add(Merge.subcatsdict[(string)obj]);
            }            

            if(Merge.oldsubcategories.Count == 0)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
            else
            {
                Merge.newsubcategory = Merge.subcatsdict[SubCategoriesDropDown.SelectedItem.ToString()];

                DialogResult = DialogResult.OK;

                Close();
            }            
        }

        private void CategoriesDialog_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Developed by Mikael Santrolli\n\nmikael.santrolli@gmail.com", "Subcategories Manager" );
        }
    }
}
