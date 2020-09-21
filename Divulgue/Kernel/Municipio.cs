using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Divulgue.Kernel
{
    public class Municipio: Entity
    {
        public string nome { get; set; }
        public int codigo_ibge { get; set; }
        
        [ForeignKey("Estado")]
        public int estado_id { get; set; }
        public Estado Estado { get; set; }
    }
}