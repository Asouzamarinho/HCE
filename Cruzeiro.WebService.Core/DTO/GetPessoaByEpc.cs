using Cruzeiro.Core.Model.Beans;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface.ServiceModel;

namespace Cruzeiro.WebService.Core.DTO
{
    public class GetPessoaByEpc : IReturn<GetPessoaByEpcReponse>
    {
        public string Epc { get; set; }
    }

    public class GetPessoaByEpcReponse
    {
        public ResponseStatus ResponseStatus { get; set; } //Automatic exception handling

        public PessoaBean Result { get; set; }
    }
}