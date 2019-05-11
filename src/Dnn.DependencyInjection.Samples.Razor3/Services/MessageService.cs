
using Dnn.DependencyInjection.Samples.Razor3.Services.Interfaces;

namespace Dnn.DependencyInjection.Samples.Razor3.Services
{
    internal class MessageService : IMessageService
    {
        public string GetMessage() => "Hello text has changed from Dependency Injection World!";
    }
}
