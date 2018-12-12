using System.Collections.Generic;
using TOTVS.PDV.Infra.Data.Contracts.Repository;
using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Infra.Data.Repository
{
    public class DinheiroRepository : IDinheiroRepository
    {
        public List<Dinheiro> ObterTodos()
        {
            //TODO: Adicionar persistência
            var dinheiroList = new List<Dinheiro>();

            dinheiroList.Add(new Dinheiro(100f, int.MaxValue, Dinheiro.TipoDinheiro.Cedula, "https://upload.wikimedia.org/wikipedia/pt/d/d2/Nova_familia-100.jpg", "100 reais"));
            dinheiroList.Add(new Dinheiro(050f, int.MaxValue, Dinheiro.TipoDinheiro.Cedula, "https://upload.wikimedia.org/wikipedia/pt/7/7c/Nova_familia-50.jpg", "50 reais"));
            dinheiroList.Add(new Dinheiro(020f, int.MaxValue, Dinheiro.TipoDinheiro.Cedula, "https://upload.wikimedia.org/wikipedia/pt/2/28/Nova_familia-20.jpg", "20 reais"));
            dinheiroList.Add(new Dinheiro(010f, int.MaxValue, Dinheiro.TipoDinheiro.Cedula, "https://upload.wikimedia.org/wikipedia/pt/d/de/Nova_familia-10.jpg", "10 reais"));
            dinheiroList.Add(new Dinheiro(005f, int.MaxValue, Dinheiro.TipoDinheiro.Cedula, "https://upload.wikimedia.org/wikipedia/pt/b/bd/Anverso_da_c%C3%A9dula_de_5_reais.PNG", "5 reais"));
            dinheiroList.Add(new Dinheiro(002f, int.MaxValue, Dinheiro.TipoDinheiro.Cedula, "https://upload.wikimedia.org/wikipedia/pt/1/1e/Anverso_da_c%C3%A9dula_de_dois_reais.PNG", "2 reais"));

            dinheiroList.Add(new Dinheiro(1.00f, int.MaxValue, Dinheiro.TipoDinheiro.Moeda, "https://upload.wikimedia.org/wikipedia/commons/d/d6/Brasil_coin_1_real.jpg", "1 real"));
            dinheiroList.Add(new Dinheiro(0.50f, int.MaxValue, Dinheiro.TipoDinheiro.Moeda, "https://upload.wikimedia.org/wikipedia/commons/e/e5/Moeda_de_50_centavos_da_2%C2%AA_gera%C3%A7%C3%A3o.png", "50 centavos"));
            dinheiroList.Add(new Dinheiro(0.25f, int.MaxValue, Dinheiro.TipoDinheiro.Moeda, "https://upload.wikimedia.org/wikipedia/commons/b/bc/Moeda_de_25_centavos_da_2%C2%AA_gera%C3%A7%C3%A3o.png", "25 centavos"));
            dinheiroList.Add(new Dinheiro(0.10f, int.MaxValue, Dinheiro.TipoDinheiro.Moeda, "https://upload.wikimedia.org/wikipedia/commons/3/31/Moeda_de_10_centavos_da_2%C2%AA_gera%C3%A7%C3%A3o.png", "10 centavos"));
            dinheiroList.Add(new Dinheiro(0.50f, int.MaxValue, Dinheiro.TipoDinheiro.Moeda, "https://upload.wikimedia.org/wikipedia/commons/5/5f/Moeda_de_5_centavos_da_2%C2%AA_gera%C3%A7%C3%A3o.png", "5 centavos"));

            //Desativar 1 centavo que não está mais em circulação
            dinheiroList.Add(new Dinheiro(0.01f, int.MaxValue, Dinheiro.TipoDinheiro.Moeda, "https://upload.wikimedia.org/wikipedia/commons/c/ce/Moeda_de_1_centavo_da_2%C2%AA_gera%C3%A7%C3%A3o.jpg", "1 centavo"));

            return dinheiroList;
        }
    }
}
