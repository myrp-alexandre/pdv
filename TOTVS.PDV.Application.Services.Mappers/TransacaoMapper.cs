using TOTVS.PDV.Application.Messages.Transacao;
using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Application.Services.Mappers
{
    public static class TransacaoMapper
    {
        public static TransacaoResponse ToResponse(this Transacao model)
        {
            if (model == null) return null;

            return new TransacaoResponse
            {
                Recebido = model.Recebido,
                ValorRestante = model.ValorRestante,
                Total = model.Total,
                TrocoList = model.TrocoList.ToResponse()
            };
        }
    }
}
