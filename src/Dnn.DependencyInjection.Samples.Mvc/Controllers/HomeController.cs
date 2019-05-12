using Dnn.DependencyInjection.Samples.Mvc.Models;
using Dnn.DependencyInjection.Samples.Mvc.Services.Interfaces;
using DotNetNuke.Security;
using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using System.Web.Mvc;

namespace Dnn.DependencyInjection.Samples.Mvc.Controllers
{
    [DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.Anonymous)]
    [DnnHandleError]
    public class HomeController : DnnController
    {
        protected IMessageService MessageService { get; }

        public HomeController(IMessageService messageService)
        {
            MessageService = messageService;
        }

        public ActionResult Index()
        {
            var model = new HelloWorld
            {
                Message = MessageService.GetMessage()
            };
            return View(model);
        }
    }
}