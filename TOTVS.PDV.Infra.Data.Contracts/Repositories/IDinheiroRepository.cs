using System.Collections.Generic;
using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Infra.Data.Contracts.Repositories
{
    public interface IDinheiroRepository
    {
        List<Dinheiro> ObterTodos();
        Dinheiro Adicionar(Dinheiro dinheiro);
        Dinheiro Alterar(Dinheiro dinheiro);
    }
}
