using APIQueueTesteReports.Models;
using MassTransit;

namespace APIQueueTesteReports.Messenger
{
    // Classe que implementa a interface IMessageService para enviar mensagens para o RabbitMQ.
    public class RabbitMQMessageService : IMessageService
    {
        private readonly IBus _bus;

        public RabbitMQMessageService(IBus bus)
        {
            _bus = bus;
        }
        public Guid EnviarMensagem(Relatorios dados)
        {
            var message = new GeraRelatorio(NewId.NextGuid(), dados);
            _bus.Publish(message);
            return message.Id;
        }
    }
}
