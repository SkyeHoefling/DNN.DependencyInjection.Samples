using DotNetNuke.Web.Mvc.Routing;

namespace Dnn.DependencyInjection.Samples.Spa
{
    public class RouteConfig : IMvcRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapRoute("Dnn.DependencyInjection.Samples.Spa", "Dnn.DependencyInjection.Samples.Spa", "{controller}/{action}", new[]
            {"Dnn.DependencyInjection.Samples.Spa.Controllers"});
        }
    }
}
