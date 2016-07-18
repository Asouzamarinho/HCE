using System.ComponentModel.DataAnnotations.Schema;
using Cruzeiro.Core.Model.Enum;

namespace Cruzeiro.Core.Model
{
    [Table("TipoPessoa")]
    public class TipoPessoa
    {
        public TipoPessoaEnum Id { get; set; }
        public string Name { get; set; }
    }
}