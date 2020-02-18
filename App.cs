using Autodesk.Revit.UI;
using System;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace SubcategoriesMerger
{
    public class App : IExternalApplication
    {
        static void AddRibbonPanel(UIControlledApplication application)
        {
            RibbonPanel ribbonPanel = application.CreateRibbonPanel("Subcategories");
            string thisAssemblyPath = Assembly.GetExecutingAssembly().Location;
            PushButtonData b4Data = new PushButtonData("Manage", "Manage", thisAssemblyPath, "SubcategoriesMerger.Merge");
            PushButton pb4 = ribbonPanel.AddItem(b4Data) as PushButton;
            pb4.ToolTip = "Merge or replace Subcategories in the Project.";
            BitmapImage pb4Image = new BitmapImage(new Uri("pack://application:,,,/SubcategoriesMerger;component/Resources/SubcategoriesMerger.png"));
            pb4.LargeImage = pb4Image;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            AddRibbonPanel(application);

            return Result.Succeeded;
        }
    }
}
