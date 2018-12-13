using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Infra.Data.Mappings
{
    internal class TransacaoMap
    {
        internal static Action<EntityTypeBuilder<Transacao>> Configure()
        {
            return (source) =>
            {
                source.ToTable("Transacao");

                source.HasKey(s => s.IdTransacao);

                source.Property(s => s.IdTransacao)
                    .HasColumnName("IdTransacao")
                    .ValueGeneratedOnAdd();

                source.Property(s => s.Total)
                    .IsRequired();

                source.Property(s => s.Recebido)
                    .IsRequired();

                source.Property(s => s.ValorRestante)
                    .IsRequired();

                source.HasMany(s => s.TrocoList)
                    .WithOne(s => s.Transacao)
                    .HasForeignKey(s => s.IdTransacao);
            };
        }
    }
}
