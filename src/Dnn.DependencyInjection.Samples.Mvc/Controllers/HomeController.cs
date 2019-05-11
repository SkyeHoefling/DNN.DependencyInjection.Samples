/*
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
*/
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
            var model = new HelloWorldModel
            {
                Message = MessageService.GetMessage()
            };
            return View(model);
        }

        public ActionResult Edit()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}