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

            PushButtonData b1Data = new PushButtonData("Manage", "Manage", thisAssemblyPath, "SubcategoriesMerger.Merge");
            PushButton pb1 = ribbonPanel.AddItem(b1Data) as PushButton;
            pb1.ToolTip = "Merge or replace Subcategories in the Project.";
            BitmapImage pb1Image = new BitmapImage(new Uri("pack://application:,,,/SubcategoriesMerger;component/Resources/SubcategoriesManager.png"));
            pb1.LargeImage = pb1Image;

            PushButtonData b2Data = new PushButtonData("Unused", "Unused", thisAssemblyPath, "SubcategoriesMerger.Purge");
            PushButton pb2 = ribbonPanel.AddItem(b2Data) as PushButton;
            pb2.ToolTip = "Unused Subcategories in the Project.";
            BitmapImage pb2Image = new BitmapImage(new Uri("pack://application:,,,/SubcategoriesMerger;component/Resources/SubcategoriesManager.png"));
            pb2.LargeImage = pb2Image;
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
