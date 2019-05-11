using Dnn.DependencyInjection.Samples.WebForms.Services;
using Dnn.DependencyInjection.Samples.WebForms.Services.Interfaces;
using DotNetNuke.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Dnn.DependencyInjection.Samples.WebForms
{
    public class Startup : IServiceRegistration
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IMessageService, MessageService>();
        }
    }
}