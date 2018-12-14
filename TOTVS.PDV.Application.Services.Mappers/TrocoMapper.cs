using System.Collections.Generic;
using System.Linq;
using TOTVS.PDV.Application.Messages.Troco;
using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Application.Services.Mappers
{
    public static class TrocoMapper
    {
        public static List<TrocoResponse> ToResponse(this List<Troco> models)
        {
            if (models == null || !models.Any()) return null;

            var response = new List<TrocoResponse>();

            foreach (var model in models) response.Add(model.ToResponse());

            return response;
        }

        public static TrocoResponse ToResponse(this Troco model)
        {
            if (model == null) return null;

            return new TrocoResponse
            {
                Quantidade = model.Quantidade,
                Dinheiro = model.Dinheiro.ToResponse()
            };
        }
    }
}
