using System.Collections.Generic;
using TOTVS.PDV.Infra.Data.Contracts.Repositories;
using TOTVS.PDV.Services.Contracts;
using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Services
{
    public class DinheiroService : IDinheiroService
    {
        public DinheiroService(IDinheiroRepository dinheiroRepository) => DinheiroRepository = dinheiroRepository;

        public IDinheiroRepository DinheiroRepository { get; }

        public List<Dinheiro> ObterTodos() => DinheiroRepository.ObterTodos();
    }
}
