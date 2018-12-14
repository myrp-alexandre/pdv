using System.Collections.Generic;
using System.Linq;
using TOTVS.PDV.Application.Messages.Dinheiro;
using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Application.Services.Mappers
{
    public static class DinheiroMapper
    {
        public static List<DinheiroResponse> ToResponse(this List<Dinheiro> models)
        {
            if (models == null || !models.Any()) return null;

            var response = new List<DinheiroResponse>();

            foreach (var model in models) response.Add(model.ToResponse());

            return response;
        }

        public static DinheiroResponse ToResponse(this Dinheiro model)
        {
            if (model == null) return null;

            return new DinheiroResponse
            {
                Descricao = model.Descricao,
                Quantidade = model.Quantidade,
                Tipo = (int)model.Tipo,
                UrlImagem = model.UrlImagem,
                Valor = model.Valor
            };
        }
    }
}
