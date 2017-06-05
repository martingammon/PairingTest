using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace PairingTest.PairingWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/Scripts/jquery-3.1.1.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/angular.min.js",
                "~/Scripts/angular-route.min.js",
                "~/App_Scripts/Models/QuestionAndAnswer.js",
                "~/App_Scripts/Models/Questionnaire.js",
                "~/App_Scripts/Models/QuestionAndAnswer.js",
                "~/App_Scripts/QuestionnaireConfig.js",
            "~/App_Scripts/QuestionnaireCtrl.js"
            ));


            bundles.Add(new StyleBundle("~/Bundles/Styles").Include(
                "~/Content/bootstrap.min.css"));
        }
    }
}