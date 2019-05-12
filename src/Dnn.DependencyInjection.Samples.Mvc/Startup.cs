using Dnn.DependencyInjection.Samples.Mvc.Services;
using Dnn.DependencyInjection.Samples.Mvc.Services.Interfaces;
using DotNetNuke.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Dnn.DependencyInjection.Samples.Mvc
{
    public class Startup : IDnnStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMessageService, MessageService>();
        }
    }
}