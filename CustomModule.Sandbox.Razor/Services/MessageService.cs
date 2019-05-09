using CustomModule.Sandbox.Razor.Services.Interfaces;

namespace CustomModule.Sandbox.Razor.Services
{
    internal class MessageService : IMessageService
    {
        public string GetMessage() => "Hello text has changed from Dependency Injection World!";
    }
}
