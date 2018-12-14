using Microsoft.AspNetCore.Mvc;
using TOTVS.PDV.Application.Messages.Transacao;
using TOTVS.PDV.Application.Services.Contracts;

namespace TOTVS.PDV.Host.WebApi.Controllers
{
    [Route("api/transacao"), Produces("application/json")]
    [ApiController]
    public class TransacaoController : Controller
    {
        public ITransacaoApplicationService TransacaoApplicationService { get; }

        public TransacaoController(ITransacaoApplicationService transacaoApplicationService) => TransacaoApplicationService = transacaoApplicationService;

        [HttpPost, Route("")]
        public IActionResult Adicionar(TransacaoRequest request) => TransacaoApplicationService.Adicionar(request);
    }
}