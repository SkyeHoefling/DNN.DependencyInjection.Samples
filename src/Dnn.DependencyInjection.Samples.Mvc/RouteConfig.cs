using DotNetNuke.Web.Mvc.Routing;

namespace Dnn.DependencyInjection.Samples.Mvc
{
    public class RouteConfig : IMvcRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapRoute("Dnn.DependencyInjection.Samples.Mvc", "Dnn.DependencyInjection.Samples.Mvc", "{controller}/{action}", new[]
            {"Dnn.DependencyInjection.Samples.Mvc.Controllers"});
        }
    }
}
