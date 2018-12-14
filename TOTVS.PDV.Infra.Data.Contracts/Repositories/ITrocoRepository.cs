using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Infra.Data.Contracts.Repositories
{
    public interface ITrocoRepository
    {
        Troco Adicionar(Troco troco);
    }
}
