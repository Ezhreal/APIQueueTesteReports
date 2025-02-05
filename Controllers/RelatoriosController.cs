using Microsoft.AspNetCore.Mvc;
using APIQueueTesteReports.Models;
using APIQueueTesteReports.Services;

namespace APIQueueTesteReports.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RelatoriosController : ControllerBase
    {
        private readonly IRelatorioService _relatorioService;
        public RelatoriosController (IRelatorioService relatorioService)
        {
            _relatorioService = relatorioService;
        }

        [HttpPost]
        public IActionResult GerarRelatorio([FromBody] Relatorios dados)
        {
            var messageId = _relatorioService.GerarRelatorio(dados);
            return Accepted(messageId);
        }
    }
}
