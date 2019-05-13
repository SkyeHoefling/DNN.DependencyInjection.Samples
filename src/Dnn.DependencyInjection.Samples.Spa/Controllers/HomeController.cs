using DotNetNuke.Security;
using DotNetNuke.Web.Api;
using System.Web.Http;

namespace Dnn.DependencyInjection.Samples.Spa.Controllers
{
    [DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.Anonymous)]
    public class HomeController : DnnApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public string Get()
        {
            return "Hello World";
        }
    }
}