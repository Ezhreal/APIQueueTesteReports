namespace APIQueueTesteReports.Models
{
    // Modelo (Model) que representa a mensagem enviada para a fila do RabbitMQ.
        public class GeraRelatorio
    {
        public Guid Id { get; set; }
        public Relatorios Dados { get; set; }

        public GeraRelatorio(Guid id, Relatorios dados) {
            Id = id;
            Dados = dados;

        }  
    }
}
