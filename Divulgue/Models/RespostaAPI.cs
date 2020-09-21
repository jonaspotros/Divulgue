using System;
using System.ComponentModel.DataAnnotations;

namespace Divulgue.Models
{
    /// <summary>
    /// Objeto de respota para requisições na API
    /// </summary>
    public class RespostaAPI
    {
        /// <summary>
        /// Identificador único da resposta
        /// </summary>
        [Required]
        public string Id { get { return Guid.NewGuid().ToString(); } }
        /// <summary>
        /// Objeto em json
        /// </summary>
        public object Objeto { get; set; }
        /// <summary>
        /// Se verdadeiro, ocorreu um erro na requisição
        /// </summary>
        [Required]
        public bool Erro { get; set; }
        /// <summary>
        /// Mensagem do erro ocorrido
        /// </summary>
        public string Mensagem { get; set; }
    }
}