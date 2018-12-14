using TOTVS.PDV.Application.Messages;
using TOTVS.PDV.Application.Messages.Transacao;

namespace TOTVS.PDV.Application.Services.Contracts
{
    public interface ITransacaoApplicationService
    {
        ResultResponseMessage<TransacaoResponse> Adicionar(TransacaoRequest request);
    }
}
