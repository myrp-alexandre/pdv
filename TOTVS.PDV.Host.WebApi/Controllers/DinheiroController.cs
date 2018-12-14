using Microsoft.AspNetCore.Mvc;
using TOTVS.PDV.Application.Messages;
using TOTVS.PDV.Application.Messages.Dinheiro;
using TOTVS.PDV.Application.Services.Contracts;

namespace TOTVS.PDV.Host.WebApi.Controllers
{
    [Route("api/dinheiro"), Produces("application/json")]
    [ApiController]
    public class DinheiroController : Controller
    {
        public IDinheiroApplicationService DinheiroApplicationService { get; }

        public DinheiroController(IDinheiroApplicationService dinheiroApplicationService) => DinheiroApplicationService = dinheiroApplicationService;

        [HttpGet, Route("")]
        public IActionResult ObterTodos() => DinheiroApplicationService.ObterTodos();
    }
}