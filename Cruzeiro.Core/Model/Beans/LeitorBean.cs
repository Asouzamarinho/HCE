namespace Cruzeiro.Core.Model.Beans
{
    public class LeitorBean : SyncNamedBean
    {
        public int EstabelecimentoId { get; set; }

        public string Address { get; set; }
        public string AntennasIn { get; set; }
        public string AntennasOut { get; set; }
    }
}
