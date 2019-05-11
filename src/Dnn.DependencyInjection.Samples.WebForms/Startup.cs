using DotNetNuke.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dnn.DependencyInjection.Samples.WebForms
{
    public class Startup : IServiceRegistration
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMessageService, MessageService>();
        }

        private class MessageService : IMessageService
        {
            public string GetMessage()
            {
                return "Hello from Dependency Injection World!";
            }
        }
    }

    public interface IMessageService
    {
        string GetMessage();
    }
}