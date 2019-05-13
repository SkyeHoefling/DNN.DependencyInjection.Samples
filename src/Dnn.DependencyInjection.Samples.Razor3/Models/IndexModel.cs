using Dnn.DependencyInjection.Samples.Razor3.Services.Interfaces;

namespace Dnn.DependencyInjection.Samples.Razor3.Models
{
    public class IndexModel
    {
        protected IMessageService MessageService { get; }

        public IndexModel(IMessageService messageService)
        {
            MessageService = messageService;
        }

        public string Title => MessageService.GetMessage();
    }
}