using System.Web;
using System.Web.Optimization;

namespace superHeroApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/core/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                        "~/Scripts/core/popper.min.js"));         

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/core/bootstrap-material-design.min.js", 
                      "~/Scripts/core/material-kit.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/material-kit.css", "~/Content/demo/demo.css"));
        }
    }
}
