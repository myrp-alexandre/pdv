using TOTVS.PDV.Infra.Data.Contracts.Repositories;
using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Tests.Repositories
{
    public class TransacaoRepositoryFake : ITransacaoRepository
    {
        public Transacao Adicionar(Transacao transacao)
        {
            return transacao;
        }
    }
}
