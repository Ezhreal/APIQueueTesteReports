using APIQueueTesteReports.Models;

namespace APIQueueTesteReports.Services
{
    // Interface que define o contrato para o serviço de relatório.
    // Define as operações que o serviço deve ser capaz de realizar.
    public interface IRelatorioService
    {
        Guid GerarRelatorio(Relatorios dados);
    }
}
