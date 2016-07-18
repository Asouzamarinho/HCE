using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Cruzeiro.Core.Model.Beans;

namespace Cruzeiro.Core.Model
{
    [Table("Pessoa")]
    public class Pessoa : PessoaBean
    {
        public virtual Estabelecimento Estabelecimento { get; set; }
        public virtual Turma Turma { get; set; }
        public virtual ICollection<EventoPortal> EventoPortals { get; set; }
        public virtual ICollection<RegraPortal> RegraPortals { get; set; }
    }
}