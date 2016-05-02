using LineupOptimizer.Framework;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace LineupOptimizer
{
    public class MvcApplication : System.Web.HttpApplication
    {

        private static void RegisterRoutes(RouteCollection routes)
        {
            var controllerNamespaces = new[] { "LineupOptimizer.Mvc.Controllers" };
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                "LODefault", 
                "{controller}/{action}/{id}", 
                new {controller = "Home", action = "Index", id = UrlParameter.Optional, namespaces =  controllerNamespaces});
        }

        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ViewEngines.Engines.Clear();
            var engine = new LOViewEngine();
            ViewEngines.Engines.Add(engine);

        }
    }
}
