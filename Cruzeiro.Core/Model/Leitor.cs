using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Cruzeiro.Core.Model.Beans;

namespace Cruzeiro.Core.Model
{
    [Table("Leitor")]
    public class Leitor : LeitorBean
    {
        [Key]
        public new int Id { get; set; }

        public virtual  Estabelecimento Estabelecimento { get; set; }
    }
}