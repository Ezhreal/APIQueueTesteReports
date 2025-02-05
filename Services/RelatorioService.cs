using APIQueueTesteReports.Messenger;
using APIQueueTesteReports.Models;

namespace APIQueueTesteReports.Services
{
    // Classe que implementa a interface IRelatorioService.
    // Contém a lógica de negócios para gerar relatórios.
    public class RelatorioService : IRelatorioService
    {
        private readonly IMessageService _messageService;

        public RelatorioService(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public Guid GerarRelatorio(Relatorios dados)
        {
            return _messageService.EnviarMensagem(dados);
        }
    }
}
