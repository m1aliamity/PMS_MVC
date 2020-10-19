using System.Web;
using System.Web.Optimization;

namespace PMS
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/Layoutjquery").Include(
                        "~/Include/bootstrap/JS/jquery-{version}.js",
                        "~/Include/bootstrap/JS/bootstrap.min.js"
                        ));

            bundles.Add(new StyleBundle("~/bundles/Layoutcss").Include(
                        "~/Content/bootstrap.min.css",
                         "~/Include/Global/Header/CSS/sm-mint/sm-mint.css",
                         "~/Include/Global/Header/CSS/sm-core-css.css"
                        ));
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Include/bootstrap/JS/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Include/bootstrap/JS/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Include/bootstrap/JS/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Include/bootstrap/JS/bootstrap.js",
                      "~/Include/Global/Header/JS/jquery.smartmenus.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
