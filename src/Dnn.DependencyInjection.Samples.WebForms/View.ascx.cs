using Dnn.DependencyInjection.Samples.WebForms.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using DotNetNuke.Common;
using DotNetNuke.Entities.Modules;

namespace Dnn.DependencyInjection.Samples.WebForms
{
    public partial class View : PortalModuleBase
    {
        protected IMessageService MessageService { get; }

        public View()
        {
            MessageService = Globals.DependencyProvider.GetService<IMessageService>();
        }

        protected void Page_Load(object sender, System.EventArgs e)
        {
            if (IsPostBack)
                return;

            ContentLiteral.Text = MessageService.GetMessage();
        }
    }
}
