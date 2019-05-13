using Dnn.DependencyInjection.Samples.Spa.Services;
using Dnn.DependencyInjection.Samples.Spa.Services.Interfaces;
using DotNetNuke.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Dnn.DependencyInjection.Samples.Spa
{
    public class Startup : IDnnStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMessageService, MessageService>();
        }
    }
}