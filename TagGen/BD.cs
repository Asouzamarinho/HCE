using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace TagGen
{
    public class BD : DbContext
    {
        public DbSet<Terceirizado> Terceirizados { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Visitante> Visitantes { get; set; }
    }

    public class Terceirizado
    {
        [Key] public int Id { get; set; }
        public string Empresa { get; set; }
        public string Nome { get; set; }
        public string Identificacao { get; set; }
        //public string Patente { get; set; }
        public string EPC { get; set; }
    }

    public class Veiculo
    {
        [Key] public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Motorista { get; set; }
        public string EPC { get; set; }
    }

    public class Visitante
    {
        [Key] public int Id { get; set; }
        public string Nome { get; set; }
        public string Identificacao { get; set; }
        public string Leito { get; set; }
        public string Tipo { get; set; }
        public string EPC { get; set; }
    }
}
