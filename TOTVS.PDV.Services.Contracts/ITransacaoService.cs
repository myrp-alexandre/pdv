using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Services.Contracts
{
    public interface ITransacaoService
    {
        Transacao Adicionar(float total, float recebido);
    }
}
