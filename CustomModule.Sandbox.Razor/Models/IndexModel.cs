using CustomModule.Sandbox.Razor.Services.Interfaces;

namespace CustomModule.Sandbox.Razor.Models
{
    public class IndexModel
    {
        protected IMessageService MessageService { get; }
        public IndexModel(IMessageService messageService)
        {
            MessageService = messageService;
        }

        public string Message => MessageService.GetMessage();
    }
}
