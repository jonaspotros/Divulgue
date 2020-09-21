using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Divulgue.Kernel
{
    public class Prefeitura:Entity
    {
        public string nome { get; set; }
        public string estado { get; set; }
        public string municipio { get; set; }

    }
}