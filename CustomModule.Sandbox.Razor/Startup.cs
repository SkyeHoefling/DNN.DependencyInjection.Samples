using CustomModule.Sandbox.Razor.Models;
using CustomModule.Sandbox.Razor.Services;
using CustomModule.Sandbox.Razor.Services.Interfaces;
using DotNetNuke.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace CustomModule.Sandbox.Razor
{
    class Startup : IServiceRegistration
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<IndexModel>();
        }
    }
}
