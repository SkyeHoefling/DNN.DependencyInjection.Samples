using Dnn.DependencyInjection.Samples.Razor3.Models;
using Dnn.DependencyInjection.Samples.Razor3.Services;
using Dnn.DependencyInjection.Samples.Razor3.Services.Interfaces;
using DotNetNuke.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Dnn.DependencyInjection.Samples.Razor3
{
    public class Startup : IDnnStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IMessageService, MessageService>();

            // IndexModel registration is required for 
            // constructor injection to work
            services.AddScoped<IndexModel>();
        }
    }
}