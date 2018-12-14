using System.Runtime.Serialization;
using TOTVS.PDV.Application.Messages.Dinheiro;

namespace TOTVS.PDV.Application.Messages.Troco
{
    [DataContract]
    public class TrocoResponse
    {
        /// <summary>
        /// Quantidade de dinheiro para o troco
        /// </summary>
        /// <example>5, 10, 48</example>
        [DataMember(Name ="quantidade")]
        public int Quantidade { get; set; }
        
        /// <summary>
        /// Objeto da entidade Dinheiro 
        /// </summary>
        /// <example>Objeto</example>
        [DataMember(Name = "dinheiro")]
        public DinheiroResponse Dinheiro { get; set; }
    }
}