using APIQueueTesteReports.Models;

namespace APIQueueTesteReports.Messenger
{
    // Interface que define o contrato para o serviço de mensagens.
    // Define as operações para enviar mensagens para a fila.
    public interface IMessageService
    {
        Guid EnviarMensagem(Relatorios dados);
    }
}
