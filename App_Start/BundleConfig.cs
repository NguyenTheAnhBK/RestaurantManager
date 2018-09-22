using System.Web;
using System.Web.Optimization;

namespace FrontEnd
{
    public class BundleConfig
    {
        private static object bundels;

        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Assets/css").Include("~/Content/Assets/css/freelancer.min.css",
                "~/Content/Assets/vendor/magnific-popup/magnific-popup.css",
                "~/Content/Assets/vendor/bootstrap/css/bootstrap.min.css",
                "~/Content/Assets/vendor/fontawesome-free/css/all.min.css"));

            bundles.Add(new StyleBundle("~/Assets/js").Include("~/Content/Assets/vendor/jquery/jquery.min.js",
          "~/Content/Assets/vendor/bootstrap/js/bootstrap.bundle.min.js",
          "~/Content/Assets/vendor/jquery-easing/jquery.easing.min.js",
          "~/Content/Assets/vendor/magnific-popup/jquery.magnific-popup.min.js",
          "~/Content/Assets/js/jqBootstrapValidation.js",
          "~/Content/Assets/js/contact_me.js",
          "~/Content/Assets/js/freelancer.min.js"));
        }
    }
}
