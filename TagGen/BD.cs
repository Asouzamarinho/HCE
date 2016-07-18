using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TagGen
{
    public class BD : DbContext
    {
        public DbSet<Terceirizado> Terceirizados { get; set; }
    }
}
