using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Infra.Data.Contracts.Repositories
{
    public interface ITransacaoRepository
    {
        Transacao Adicionar(Transacao transacao);
    }
}
