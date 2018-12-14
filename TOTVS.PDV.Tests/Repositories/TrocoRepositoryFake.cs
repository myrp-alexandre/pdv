using System;
using TOTVS.PDV.Infra.Data.Contracts.Repositories;
using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Tests.Repositories
{
    public class TrocoRepositoryFake : ITrocoRepository
    {
        public Troco Adicionar(Troco troco)
        {
            return troco;
        }
    }
}
