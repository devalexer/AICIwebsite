﻿using System.Web;
using System.Web.Optimization;

namespace AICIwebsite
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/js/agency.js",
                        "~/Scripts/js/agency.min.js",
                        "~/Scripts/js/contact_me.js",
                        "~/Scripts/jqBootstrapValidation.js",
                        "~/Content/vendor/bootstrap/js/bootstrap.js",
                        "~/Content/vendor/bootstrap/js/bootstrap.min.js",
                        "~/Content/vendor/jquery/jquery.js",
                        "~/Content/vendor/jquery/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/agency.css",
                      "~/Content/css/agency.min.css",
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/site.css",
                      "~/Content/vendor/bootstrap/css/bootstrap.css",
                      "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                      "~/Content/vendor/font-awesome/css/font-awesome.css",
                      "~/Content/vendor/font-awesome/css/font-awesome.min.css"));
        }
    }
}
