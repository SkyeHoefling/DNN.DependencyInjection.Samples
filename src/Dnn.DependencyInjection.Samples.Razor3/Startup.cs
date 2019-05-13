using Dnn.DependencyInjection.Samples.Razor3.Models;
using DotNetNuke.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Dnn.DependencyInjection.Samples.Razor3
{
    public class Startup : IDnnStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IndexModel>();
        }
    }
}