using System;
using System.ComponentModel.DataAnnotations.Schema;
using Cruzeiro.Core.Model.Beans;

namespace Cruzeiro.Core.Model
{
    [Table("RegraPortal")]
    public class RegraPortal : RegraBean, IComparable<RegraPortal>
    {
        public virtual Turma Turma { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        public int CompareTo(RegraPortal other)
        {
            if (PessoaId.HasValue != other.PessoaId.HasValue)
            {
                return PessoaId.HasValue ? -1 : 1;
            }
            if (DataEspecifica.HasValue != other.DataEspecifica.HasValue)
            {
                return DataEspecifica.HasValue ? -1 : 1;
            }
            return Entrada.CompareTo(other.Entrada);
        }
    }
}