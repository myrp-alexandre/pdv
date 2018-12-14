using System;
using TOTVS.PDV.Application.Messages;
using TOTVS.PDV.Application.Messages.Transacao;
using TOTVS.PDV.Application.Services.Contracts;
using TOTVS.PDV.Application.Services.Mappers;
using TOTVS.PDV.Services.Contracts;

namespace TOTVS.PDV.Application.Services
{
    public class TransacaoApplicationService : ITransacaoApplicationService
    {
        public TransacaoApplicationService(ITransacaoService transacaoService) => TransacaoService = transacaoService;
        
        public ITransacaoService TransacaoService { get; }

        public ResultResponseMessage<TransacaoResponse> Adicionar(TransacaoRequest request)
        {
            try
            {
                TransacaoResponse response = TransacaoService.Adicionar(request.Total, request.Recebido).ToResponse();

                return new ResultResponseMessage<TransacaoResponse>(response);
            }
            catch (Exception ex)
            {
                return new ResultResponseMessage<TransacaoResponse>(null).CreateResponseInternalServerError(ex.Message);
            }
        }
    }
}
