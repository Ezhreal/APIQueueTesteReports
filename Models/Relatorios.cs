namespace APIQueueTesteReports.Models
{
    // Modelo (Model) que representa os dados de um relatório.
    public class Relatorios
    {
        public string Tipo { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }

        public Relatorios() { } // Construtor sem parâmetros (essencial)

        public Relatorios(string tipo, DateTime dataInicio, DateTime dataFim)
        {
            Tipo = tipo;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }
    }
}
