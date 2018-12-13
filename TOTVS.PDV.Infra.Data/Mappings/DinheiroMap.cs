using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Infra.Data.Mappings
{
    internal class DinheiroMap
    {
        internal static Action<EntityTypeBuilder<Dinheiro>> Configure()
        {
            return (source) =>
            {
                source.ToTable("Dinheiro");

                source.HasKey(s => s.IdDinheiro);

                source.Property(s => s.IdDinheiro)
                    .HasColumnName("IdDinheiro")
                    .ValueGeneratedOnAdd();

                source.Property(s => s.Valor)
                    .IsRequired();

                source.Property(s => s.Quantidade)
                    .IsRequired();

                source.Property(s => s.Tipo)
                    .IsRequired();

                source.Property(s => s.UrlImagem)
                    .HasMaxLength(250)
                    .IsRequired();

                source.Property(s => s.Descricao)
                    .HasMaxLength(80)
                    .IsRequired();

                source.Property(s => s.Ativo)
                    .IsRequired();

                source.HasMany(s => s.TrocoList)
                    .WithOne(s => s.Dinheiro)
                    .HasForeignKey(s => s.IdDinheiro);
            };
        }
    }
}
