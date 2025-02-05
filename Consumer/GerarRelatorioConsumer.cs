using APIQueueTesteReports.Models;
using MassTransit;

namespace APIQueueTesteReports.Consumer
{
    // Classe que define o consumidor de mensagens GerarRelatorio.
    // Esta classe implementa a interface IConsumer<GerarRelatorio>, o que significa
    // que ela irá consumir mensagens do tipo GerarRelatorio.
    public class GerarRelatorioConsumer : IConsumer<GeraRelatorio>
    {
        // Este é o método que será executado quando uma mensagem do tipo GerarRelatorio
        // for recebida na fila. O MassTransit irá chamar este método automaticamente.
        // O parâmetro context contém informações sobre a mensagem, como a própria mensagem,
        // metadados, etc.
        public Task Consume(ConsumeContext<GeraRelatorio> context)
        {
            var message = context.Message;

            Console.WriteLine($"Relatório {message.Dados.Tipo} gerado (ID: {message.Id})");
            Console.WriteLine($"Período: {message.Dados.DataInicio} - {message.Dados.DataFim}");

            return Task.CompletedTask;
        }
    }
}
