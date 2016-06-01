using System.Web;
using System.Web.Optimization;

namespace CiC
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            //            "~/Scripts/jquery-ui-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.unobtrusive*",
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
                        "~/Scripts/plugins/jquery.flexslider.js",
                        "~/Scripts/plugins/jquery.selectbox-0.1.3.min.js",
                        "~/Scripts/plugins/jquery.magnific-popup.js",
                        "~/Scripts/plugins/waypoints.min.js",
                        "~/Scripts/plugins/jquery.counterup.js",
                        "~/Scripts/plugins/wow.min.js",
                        "~/Scripts/plugins/navbar.js",
                        "~/Scripts/plugins/moment.min.js",
                        "~/Scripts/plugins/fullcalendar.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include("~/Scripts/jquery.js", "~/Scripts/custom.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/template").Include("~/Content/template/style.css"));

            bundles.Add(new StyleBundle("~/Content/template/colors").Include("~/Content/template/colors/default.css"));

            bundles.Add(new StyleBundle("~/Content/template/plugins").Include(
                        "~/Content/template/plugins/animate.css",
                        "~/Content/template/plugins/flexslider.css",
                        "~/Content/template/plugins/fullcalendar.min.css",
                        "~/Content/template/plugins/headhesive.css",
                        "~/Content/template/plugins/magnific-popup.css",
                        "~/Content/template/plugins/select_option1.css"));

            bundles.Add(new StyleBundle("~/Content/template/bootstrap").Include("~/Content/template/bootstrap/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/fonts").Include("~/Content/fonts/font-awesome/css/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}