﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Divulgue.Kernel
{
    public class Prefeitura:Entity
    {
        public string nome { get; set; }

        [ForeignKey("Estado")]
        public int estado_id { get; set; }
        public Estado Estado { get; set; }

        [ForeignKey("Municipio")]
        public int municipio_id { get; set; }
        public Municipio Municipio { get; set; }

    }
}