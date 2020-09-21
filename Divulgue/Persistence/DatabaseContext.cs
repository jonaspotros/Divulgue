using Divulgue.Kernel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Divulgue.Persistence
{
    public class DatabaseContext: DbContext
    {
        public DbSet<Estado> estados { get; set; }
        public DbSet<Municipio> municipios { get; set; }

    }
}