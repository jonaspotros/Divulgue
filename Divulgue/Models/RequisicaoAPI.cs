using System.ComponentModel.DataAnnotations;

namespace Divulgue.Models
{
    /// <summary>
    /// Classe de Requisiçao da API
    /// </summary>
    public class RequisicaoAPI
    {
        /// <summary>
        /// string gerada pela aplicação cliente
        /// </summary>
        [Required]
        public string Id { get; set; }
        /// <summary>
        /// Token de segurança obtido após autênticação
        /// </summary>
        [Required]
        public string Token { get; set; }
        /// <summary>
        /// Objeto transformado em json
        /// </summary>
        [Required]
        public object Objeto { get; set; }
    }
}