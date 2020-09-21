using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Divulgue.Kernel
{
    public class Estado: Entity
    {
        public string nome { get; set; }
        public int codigo_ibge { get; set; }
        public char sigla { get; set; }
    }
}