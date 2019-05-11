using Dnn.DependencyInjection.Samples.WebForms.Services.Interfaces;
using DotNetNuke.Common;
using DotNetNuke.Entities.Modules;
using Microsoft.Extensions.DependencyInjection;

namespace Dnn.DependencyInjection.Samples.WebForms
{

    public partial class View : PortalModuleBase
    {
        protected IMessageService MessageService { get; }
        public View()
        {
            MessageService = Globals.DependencyProvider.GetService<IMessageService>(); 
        }

        protected void Page_load(object sender, System.EventArgs e)
        {
            if (IsPostBack)
                return;

            ContentLiteral.Text = MessageService.GetMessage();
        }
        

    }

}
