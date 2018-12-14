using System;
using TOTVS.PDV.Infra.Data.Context;
using TOTVS.PDV.Infra.Data.Contracts.Repositories;
using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Infra.Data.Repositories
{
    public class TransacaoRepository : ITransacaoRepository
    {
        public DbContextPDV DbContextPDV { get; }

        public TransacaoRepository(DbContextPDV dbContextPDV) => DbContextPDV = dbContextPDV;

        public Transacao Adicionar(Transacao Transacao)
        {
            try
            {
                var entry = DbContextPDV.Transacao.Add(Transacao);
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
