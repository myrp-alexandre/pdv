using System;
using TOTVS.PDV.Infra.Data.Context;
using TOTVS.PDV.Infra.Data.Contracts.Repositories;
using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Infra.Data.Repositories
{
    public class TrocoRepository : ITrocoRepository
    {
        public DbContextPDV DbContextPDV { get; }

        public TrocoRepository(DbContextPDV dbContextPDV) => DbContextPDV = dbContextPDV;

        public Troco Adicionar(Troco Troco)
        {
            try
            {
                var entry = DbContextPDV.Troco.Add(Troco);
                DbContextPDV.SaveChanges();
                return entry.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
