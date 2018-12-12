using System.Collections.Generic;
using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Infra.Data.Contracts.Repository
{
    public interface IDinheiroRepository
    {
        List<Dinheiro> ObterTodos();
    }
}
