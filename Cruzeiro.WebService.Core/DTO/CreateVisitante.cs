using Cruzeiro.Core.Model;
using Cruzeiro.Core.Model.Beans;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface.ServiceModel;

namespace Cruzeiro.WebService.Core.DTO
{
    public class CreateVisitante : IReturn<CreateVisitanteResponse>
    {
        public string Name { get; set; }
        public string Documento { get; set; }
        public int? EstabelecimentoId { get; set; }
    }

    public class CreateVisitanteResponse
    {
        public ResponseStatus ResponseStatus { get; set; }  //Automatic exception handling

        public PessoaBean Result { get; set; }
    }
}