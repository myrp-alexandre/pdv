using System.Collections.Generic;
using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Services.Contracts
{
    public interface IFluxoService
    {
        List<Troco> ObterTroco(float total, float recebido);
    }
}
