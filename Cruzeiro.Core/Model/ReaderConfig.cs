using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Cruzeiro.Core.Model.Beans;
using Cruzeiro.Core.Model.Enum;

namespace Cruzeiro.Core.Model
{
    [Table("ReaderConfig")]
    public class ReaderConfig : SyncBean
    {
        public int EstabelecimentoId { get; set; }

        public int Portal { get; set; }
        public ReaderTypeEnum ReaderType { get; set; }
        public string Address { get; set; }

        public string AntennasStr
        {
            get { return string.Join(";", Antennas); }
            set
            {
                Antennas =
                    value.Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
        }

        [NotMapped]
        public int[] Antennas { get; set; }

        public virtual Estabelecimento Estabelecimento { get; set; }
    }
}