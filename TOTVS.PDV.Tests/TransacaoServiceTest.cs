using System.Linq;
using TOTVS.PDV.Services;
using TOTVS.PDV.Services.Contracts;
using TOTVS.PDV.Tests.Repositories;
using Xunit;

namespace TOTVS.PDV.Tests
{
    public class TransacaoServiceTest
    {
        public ITransacaoService TransacaoService => new TransacaoService(new DinheiroRepositoryFake(), new TrocoRepositoryFake(), new TransacaoRepositoryFake());
        
        [Fact]
        public void Valores_Iguais_NaoDevemRetornarTroco()
        {
            var result = TransacaoService.Adicionar(100, 100);

            Assert.Equal(0, result.ValorRestante);
        }

        [Fact]
        public void Valores_Diferentes_DeveRetornarMoedas()
        {
            var result = TransacaoService.Adicionar(10.05f, 10.18f);

            Assert.True(result.TrocoList.FirstOrDefault(s => s.Dinheiro.Tipo == Services.Models.Dinheiro.TipoDinheiro.Moeda) != null);
        }
    }
}
