using System.Collections.Generic;
using TOTVS.PDV.Application.Messages;
using TOTVS.PDV.Application.Messages.Dinheiro;

namespace TOTVS.PDV.Application.Services.Contracts
{
    public interface IDinheiroApplicationService
    {
        ResultResponseMessage<List<DinheiroResponse>> ObterTodos();
    }
}
