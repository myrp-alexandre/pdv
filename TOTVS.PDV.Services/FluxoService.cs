using System;
using System.Collections.Generic;
using System.Linq;
using TOTVS.PDV.Infra.Data.Contracts.Repositories;
using TOTVS.PDV.Services.Contracts;
using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Services
{
    public class FluxoService : IFluxoService
    {
        public FluxoService(IDinheiroRepository dinheiroRepository)
        {
            DinheiroRepository = dinheiroRepository;
        }

        public IDinheiroRepository DinheiroRepository { get; }

        public List<Troco> ObterTroco(float total, float recebido) => Calcular(total, recebido, DinheiroRepository.ObterTodos());

        private List<Troco> Calcular(float total, float recebido, List<Dinheiro> dinheiroList)
        {
            var trocoList = new List<Troco>();
            double trocado = 0;

            dinheiroList = dinheiroList.Where(s => s.Quantidade > 0).OrderByDescending(s => s.Valor).ToList();

            for (int i = 0; i < dinheiroList.Count; i++)
            {
                var dinheiro = dinheiroList[i];
                var restante = Math.Round((recebido - total - trocado), 2);

                if (dinheiro.Valor > restante) continue;

                var quantidadeDinheiro = (int)(restante - Math.Truncate(restante % dinheiro.Valor));

                if (quantidadeDinheiro == 0 || Math.Truncate(restante % dinheiro.Valor) == 0) quantidadeDinheiro = (int)Math.Round(restante / dinheiro.Valor, 2);

                if (dinheiro.Quantidade < quantidadeDinheiro) quantidadeDinheiro = dinheiro.Quantidade;

                trocoList.Add(new Troco(dinheiro, quantidadeDinheiro));

                trocado += Math.Round(dinheiro.Valor * quantidadeDinheiro, 2);
            }

            return trocoList;
        }

    }
}
