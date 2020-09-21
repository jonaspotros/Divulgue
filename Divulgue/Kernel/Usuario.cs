using System.ComponentModel.DataAnnotations.Schema;

namespace Divulgue.Kernel
{
    public class Usuario : Entity
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }

        [ForeignKey("Prefeitura")]
        public int prefeitura_id { get; set; }
        public Prefeitura Prefeitura { get; set; }
        
    }
}