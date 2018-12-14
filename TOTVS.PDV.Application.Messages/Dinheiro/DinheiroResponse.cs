using System.Runtime.Serialization;

namespace TOTVS.PDV.Application.Messages.Dinheiro
{
    [DataContract]
    public class DinheiroResponse
    {
        /// <summary>
        /// Valor contábil da cédula ou moeda
        /// </summary>
        /// <example>0.5f, 0.1f, 10, 100</example>
        [DataMember(Name = "valor")]
        public float Valor { get; set; }

        /// <summary>
        /// Quantidade disponível para realizar transação
        /// </summary>
        /// <example>100, 200, 1000</example>
        [DataMember(Name = "quantidade")]
        public int Quantidade { get; set; }

        /// <summary>
        /// Tipo do dinheiro: cédula ou moeda
        /// </summary>
        /// <example>1 = cédula, 2 = Moeda</example>
        [DataMember(Name = "tipo")]
        public int Tipo { get; set; }

        /// <summary>
        /// Url completa com uma imagem da cédula ou moeda
        /// </summary>
        /// <example>1 = cédula, 2 = Moeda</example>
        [DataMember(Name = "urlImagem")]
        public string UrlImagem { get; set; }

        /// <summary>
        /// Descritivo da cédula ou moeda
        /// </summary>
        /// <example>1 real, 25 centavos</example>
        [DataMember(Name = "descricao")]
        public string Descricao { get; set; }
    }
}
