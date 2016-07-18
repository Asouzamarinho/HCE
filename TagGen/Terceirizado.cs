using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagGen
{
    public class Terceirizado
    {
        [Key]
        public int Id { get; set; }

        public string Empresa { get; set; }

        public string Nome { get; set; }

        public string Identificacao { get; set; }

        public string Patente { get; set; }

        public string EPC { get; set; }
    }
}
