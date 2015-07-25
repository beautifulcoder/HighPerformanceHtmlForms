using System.Web.Optimization;

namespace HighPerformanceHtmlForms
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

#if !DEBUG
            BundleTable.EnableOptimizations = true;
#endif

        }
    }
}
