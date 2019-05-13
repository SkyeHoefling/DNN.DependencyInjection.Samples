using Dnn.DependencyInjection.Samples.Razor3.Services.Interfaces;

namespace Dnn.DependencyInjection.Samples.Razor3.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Dependency Injection World!!";
        }
    }
}