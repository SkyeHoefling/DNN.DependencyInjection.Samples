using Dnn.DependencyInjection.Samples.Mvc.Services.Interfaces;

namespace Dnn.DependencyInjection.Samples.Mvc.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from Dependency Injection World!";
        }
    }
}