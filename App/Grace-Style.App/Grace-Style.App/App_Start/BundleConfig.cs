using System.Web;
using System.Web.Optimization;

namespace Grace_Style.App
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Styles

            bundles.Add(new StyleBundle("~/Styles/css").Include(
                "~/Styles/animation.css",
                "~/Styles/site.css"));

            bundles.Add(new StyleBundle("~/Styles/backgroundmodule").Include(
                "~/Styles/Background/backgroundanimation.css",
                "~/Styles/Background/backgroundxxs.css",
                "~/Styles/Background/backgroundxs.css",
                "~/Styles/Background/backgroundsm.css",
                "~/Styles/Background/backgroundmd.css",
                "~/Styles/Background/backgroundlg.css",
                "~/Styles/Background/backgroundxl.css",
                "~/Styles/Background/backgroundxxl.css",
                "~/Styles/Background/backgroundsite.css"));

            #endregion Styles


            #region Scripts

            bundles.Add(new ScriptBundle("~/Script/jquery").Include(
                        "~/Scripts/jQuery/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/Script/backgroundmodule").Include(
                        "~/Scripts/Background/backgroundModel.js",
                        "~/Scripts/Background/backgroundView.js",
                        "~/Scripts/Background/backgroundController.js"));

            bundles.Add(new ScriptBundle("~/Script/framework").Include(
                        "~/Scripts/Framework/htmlElements.js",
                        "~/Scripts/Framework/model.js",
                        "~/Scripts/Framework/view.js",
                        "~/Scripts/Framework/controller.js"));

            #endregion Scripts

            BundleTable.EnableOptimizations = true;
        }
    }
}
