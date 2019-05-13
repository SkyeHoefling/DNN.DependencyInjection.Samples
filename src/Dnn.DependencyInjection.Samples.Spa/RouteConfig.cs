using DotNetNuke.Web.Api;

namespace Dnn.DependencyInjection.Samples.Spa
{
    public class RouteConfig : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute("Dnn.DependencyInjection.Samples/Spa", "default", "{controller}/{action}", new[]
            {"Dnn.DependencyInjection.Samples.Spa.Controllers"});
        }
    }
}
