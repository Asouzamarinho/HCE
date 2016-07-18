using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Cruzeiro.Core.Model.Beans;

namespace Cruzeiro.Core.Model
{
    [Table("Estabelecimento")]
    public class Estabelecimento : EstabelecimentoBean
    {
        public virtual ICollection<Turma> Turmas { get; set; }
        public virtual ICollection<Pessoa> PessoaPortals { get; set; }
        public virtual ICollection<Leitor> Leitors { get; set; }
    }
}