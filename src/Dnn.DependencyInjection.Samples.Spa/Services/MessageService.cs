using Dnn.DependencyInjection.Samples.Spa.Services.Interfaces;

namespace Dnn.DependencyInjection.Samples.Spa.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from Dependency Injection World!!";
        }
    }
}