using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Infra.Data.Mappings
{
    internal class TrocoMap
    {
        internal static Action<EntityTypeBuilder<Troco>> Configure()
        {
            return (source) =>
            {
                source.ToTable("Troco");

                source.HasKey(s => s.IdTroco);

                source.Property(s => s.IdTroco)
                   .HasColumnName("IdTroco")
                   .ValueGeneratedOnAdd();

                source.Property(s => s.Quantidade)
                  .IsRequired();

                source.Property(s => s.IdDinheiro)
                  .IsRequired();
            };
        }
    }
}
