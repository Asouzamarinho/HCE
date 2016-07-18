using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Cruzeiro.Core.Model.Beans;

namespace Cruzeiro.Core.Model
{
    [Table("EventoPortal")]
    public class EventoPortal : EventoBean
    {
        [Key]
        public new int Id { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}