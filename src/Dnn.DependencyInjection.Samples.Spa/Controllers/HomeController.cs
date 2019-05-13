using Dnn.DependencyInjection.Samples.Spa.Services.Interfaces;
using DotNetNuke.Security;
using DotNetNuke.Web.Api;
using System.Web.Http;

namespace Dnn.DependencyInjection.Samples.Spa.Controllers
{
    [DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.Anonymous)]
    public class HomeController : DnnApiController
    {
        protected IMessageService MessageService { get; }

        public HomeController(IMessageService messageService)
        {
            MessageService = messageService;
        }

        [AllowAnonymous]
        [HttpGet]
        public string Get()
        {
            return MessageService.GetMessage();
        }
    }
}