using Microsoft.AspNetCore.Mvc;
using TOTVS.PDV.Application.Messages.Dinheiro;

namespace TOTVS.PDV.Host.WebApi.Controllers
{
    [Produces("application/json"), Route("api/[controller]")]
    public class DinheiroController : Controller
    {
        [HttpPost, Route("")]
        public IActionResult Adicionar([FromBody]DinheiroRequest request) => null;

        //[HttpPut, Route("")]
        //public IActionResult Atualizar([FromBody]RegraAtualizarMessageRequest request) => RegraApplicationService.Atualizar(request);

        //[HttpGet, Route("paginado")]
        //public IActionResult ObterPaginados([FromQuery] PaginadosMessageRequest request) => RegraApplicationService.ObterPaginados(request);
    }
}