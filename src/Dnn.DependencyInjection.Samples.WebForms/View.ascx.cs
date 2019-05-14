using DotNetNuke.Entities.Modules;

namespace Dnn.DependencyInjection.Samples.WebForms
{
    public partial class View : PortalModuleBase
    {
        protected void Page_load(object sender, System.EventArgs e)
        {
            if (IsPostBack)
                return;

            ContentLiteral.Text = "Hello World";
        }
    }
}
