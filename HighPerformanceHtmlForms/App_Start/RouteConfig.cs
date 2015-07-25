using System.Web.Mvc;
using System.Web.Routing;

namespace HighPerformanceHtmlForms
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                "Default", "{controller}/{action}/{id}", new { Controller = "Person", Action = "PersonEdit", id = UrlParameter.Optional });
        }
    }
}
