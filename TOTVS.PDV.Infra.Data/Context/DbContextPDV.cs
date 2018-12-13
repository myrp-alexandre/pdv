using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using TOTVS.PDV.Infra.Data.Mappings;
using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Infra.Data.Context
{
    public class DbContextPDV : DbContext
    {
        public DbContextPDV(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Dinheiro> Dinheiro { get; set; }
        public DbSet<Transacao> Transacao { get; set; }
        public DbSet<Troco> Troco { get; set; }



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Data Source=totvs_pdv.db");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity(DinheiroMap.Configure());
            modelBuilder.Entity(TransacaoMap.Configure());
            modelBuilder.Entity(TrocoMap.Configure());

            modelBuilder.AddInitialData();
        }
    }
}
