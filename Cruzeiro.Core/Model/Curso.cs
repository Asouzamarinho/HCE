using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Cruzeiro.Core.Model.Beans;

namespace Cruzeiro.Core.Model
{
    [Table("Curso")]
    public class Curso : CursoBean
    {
        public virtual ICollection<Turma> Turmas { get; set; }
    }
}