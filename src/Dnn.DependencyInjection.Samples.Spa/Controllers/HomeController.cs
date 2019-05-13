using Dnn.DependencyInjection.Samples.Spa.Models;
using DotNetNuke.Security;
using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using System.Web.Mvc;

namespace Dnn.DependencyInjection.Samples.Spa.Controllers
{
    [DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.Anonymous)]
    [DnnHandleError]
    public class HomeController : DnnController
    {
        public ActionResult Index()
        {
            var model = new HelloWorld
            {
                Message = "Hello World"
            };
            return View(model);
        }
    }
}