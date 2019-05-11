using System;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Services.Localization;
using DotNetNuke.Security;


namespace Samples.Modules.WebForms.HelloWorld
{

    public partial class View : PortalModuleBase
    {

        protected void Page_load(object sender, System.EventArgs e)
        {
            if (IsPostBack)
                return;

            ContentLiteral.Text = $"{UserInfo.UserID}";
        }
        

    }

}
