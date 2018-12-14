using System;
using System.Collections.Generic;
using TOTVS.PDV.Application.Messages;
using TOTVS.PDV.Application.Messages.Dinheiro;
using TOTVS.PDV.Application.Services.Contracts;
using TOTVS.PDV.Application.Services.Mappers;
using TOTVS.PDV.Services.Contracts;

namespace TOTVS.PDV.Application.Services
{
    public class DinheiroApplicationService : IDinheiroApplicationService
    {
        public IDinheiroService DinheiroService { get; }

        public DinheiroApplicationService(IDinheiroService dinheiroService) => DinheiroService = dinheiroService;

        public ResultResponseMessage<List<DinheiroResponse>> ObterTodos()
        {
            try
            {
                List<DinheiroResponse> response = DinheiroService.ObterTodos().ToResponse();

                return new ResultResponseMessage<List<DinheiroResponse>>(response);
            }
            catch(Exception ex)
            {
                return new ResultResponseMessage<List<DinheiroResponse>>(null).CreateResponseInternalServerError(ex.Message);
            }
        }
    }
}
