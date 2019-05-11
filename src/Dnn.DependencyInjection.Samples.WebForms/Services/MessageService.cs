using Dnn.DependencyInjection.Samples.WebForms.Services.Interfaces;

namespace Dnn.DependencyInjection.Samples.WebForms.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from Dependency Injection World!";
        }
    }
}