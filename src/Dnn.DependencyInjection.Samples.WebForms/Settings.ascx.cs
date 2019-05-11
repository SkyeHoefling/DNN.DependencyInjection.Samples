using System;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Entities.Modules;


namespace Dnn.DependencyInjection.Samples.WebForms
{

    public partial class Settings : ModuleSettingsBase
    {

        #region Base Method Implementations

        public override void LoadSettings()
        {
            try
            {

            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }

        public override void UpdateSettings()
        {
            try
            {

            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }

        #endregion

    }

}

