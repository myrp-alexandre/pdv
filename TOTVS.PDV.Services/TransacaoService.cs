using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using TOTVS.PDV.Infra.Data.Contracts.Repositories;
using TOTVS.PDV.Services.Contracts;
using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Services
{
    public class TransacaoService : ITransacaoService
    {
        public TransacaoService(IDinheiroRepository dinheiroRepository, ITrocoRepository trocoRepository, ITransacaoRepository transacaoRepository)
        {
            DinheiroRepository = dinheiroRepository;
            TrocoRepository = trocoRepository;
            TransacaoRepository = transacaoRepository;
        }

        public IDinheiroRepository DinheiroRepository { get; }
        public ITrocoRepository TrocoRepository { get; }
        public ITransacaoRepository TransacaoRepository { get; }

        public Transacao Adicionar(float total, float recebido)
        {
            using (var scope = new TransactionScope())
            {
                List<Troco> trocoList = CalcularTroco(total, recebido, DinheiroRepository.ObterTodos());
                Transacao transacao = null;

                if (trocoList != null && trocoList.Any())
                {
                    transacao = new Transacao(total, recebido, trocoList);
                    TransacaoRepository.Adicionar(transacao);

                    foreach (Troco trocoItem in trocoList)
                    {
                        for (int i = 0; i < trocoItem.Quantidade; i++) trocoItem.Dinheiro.Retirar();

                        DinheiroRepository.Alterar(trocoItem.Dinheiro);
                    }
                }

                scope.Complete();

                return transacao;
            }
        }

        private List<Troco> CalcularTroco(float total, float recebido, List<Dinheiro> dinheiroList)
        {
            var trocoList = new List<Troco>();
            double trocado = 0;

            dinheiroList = dinheiroList.Where(s => s.Quantidade > 0).OrderByDescending(s => s.Valor).ToList();

            for (int i = 0; i < dinheiroList.Count; i++)
            {
                var dinheiro = dinheiroList[i];
                var restante = Math.Round((recebido - total - trocado), 2);

                if (dinheiro.Valor > restante) continue;

                var quantidadeDinheiro = (int)((restante - Math.Truncate(restante % dinheiro.Valor)) / dinheiro.Valor);

                if (quantidadeDinheiro == 0 || Math.Truncate(restante % dinheiro.Valor) == 0) quantidadeDinheiro = (int)Math.Round(restante / dinheiro.Valor, 2);

                if (dinheiro.Quantidade < quantidadeDinheiro) quantidadeDinheiro = dinheiro.Quantidade;

                trocoList.Add(new Troco(dinheiro, quantidadeDinheiro));

                trocado += Math.Round(dinheiro.Valor * quantidadeDinheiro, 2);
            }

            return trocoList;
        }

    }
}
