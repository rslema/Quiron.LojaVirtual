using System.Web;
using System.Web.Optimization;

namespace Quiron.LojaVirtual.Web.V2
//{
//    public class BundleConfig
//    {
//        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
//        public static void RegisterBundles(BundleCollection bundles)
//        {
//            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
//                        "~/Scripts/jquery-{version}.js"));

//            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
//                        "~/Scripts/jquery.validate*"));

//            // Use the development version of Modernizr to develop with and learn from. Then, when you're
//            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
//            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
//                        "~/Scripts/modernizr-*"));

//            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
//                      "~/Scripts/bootstrap.js",
//                      "~/Scripts/respond.js"));

//            bundles.Add(new StyleBundle("~/Content/css").Include(
//                      "~/Content/bootstrap.css",
//                      "~/Content/site.css"));
//        }
//    }
//}
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/css").Include(
                      "~/css/*.css"));

            bundles.Add(new ScriptBundle("~/js").Include(
                     "~/js/jquery.js",
                      "~/js/bootstrap.js"));


            // <!-- SmartMenu http://www.smartmenus.org/ -->
            bundles.Add(new StyleBundle("~/Content/startmenu").Include(
                 "~/Content/sm-core-css.css",
         //    "~/Content/sm-simple/sm-simple.css"
                        "~/Content/sm-mint/sm-mint.css"
             ));

            bundles.Add(new ScriptBundle("~/Scripts/startmenu").Include(
                //"~/js/jquery.navgoco.js",
                "~/Scripts/jquery.smartmenus.js"));

            bundles.Add(new ScriptBundle("~/Scripts/jsprojetos").Include(
                    "~/Scripts/menu.js"));



            BundleTable.EnableOptimizations = false;
        }
    }
}
