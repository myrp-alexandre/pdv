using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TOTVS.PDV.Infra.Data.Context;
using TOTVS.PDV.Infra.Data.Contracts.Repositories;
using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Infra.Data.Repositories
{
    public class DinheiroRepository : IDinheiroRepository
    {
        public DbContextPDV DbContextPDV { get; }
        public DinheiroRepository(DbContextPDV dbContextPDV)
        {
            DbContextPDV = dbContextPDV;
        }

        public Dinheiro Adicionar(Dinheiro dinheiro)
        {
            try
            {
                var entry = DbContextPDV.Dinheiro.Add(dinheiro);
                DbContextPDV.SaveChanges();
                return entry.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dinheiro Alterar(Dinheiro dinheiro)
        {
            try
            {
                DbContextPDV.Entry(dinheiro).State = EntityState.Modified;
                DbContextPDV.SaveChanges();
                return dinheiro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Dinheiro> ObterTodos() => DbContextPDV.Dinheiro.ToList();
    }
}
