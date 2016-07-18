using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Cruzeiro.Core.Model.Beans;

namespace Cruzeiro.Core.Model
{
    [Table("Turma")]
    public class Turma : TurmaBean
    {
        public int EstabelecimentoId { get; set; }
        public int CursoId { get; set; }

        public virtual Estabelecimento Estabelecimento { get; set; }
        public virtual Curso Curso { get; set; }

        public virtual ICollection<RegraPortal> RegraPortals { get; set; }
        public virtual ICollection<Pessoa> PessoaPortals { get; set; }
    }
}