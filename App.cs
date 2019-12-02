using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.IO;
using System.Windows.Media.Imaging;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;

namespace SubcategoriesManager
{
    public class App : IExternalApplication
    {
        static void AddRibbonPanel(UIControlledApplication application)
        {
            RibbonPanel ribbonPanel = application.CreateRibbonPanel("Subcategories");
            string thisAssemblyPath = Assembly.GetExecutingAssembly().Location;
            PushButtonData b4Data = new PushButtonData("Manage", "Manage", thisAssemblyPath, "SubcategoriesManager.Merge");
            PushButton pb4 = ribbonPanel.AddItem(b4Data) as PushButton;
            pb4.ToolTip = "Manage Subcategories in the Project.";
            BitmapImage pb4Image = new BitmapImage(new Uri(thisAssemblyPath.Replace("SubcategoriesManager.dll", "") + "SubcategoriesManager.png"));
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
