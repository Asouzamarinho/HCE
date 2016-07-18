using Cruzeiro.Core.Model.Beans;
using ServiceStack.ServiceHost;

namespace Cruzeiro.WebService.Core.DTO
{
    [Route("/Visitantes")]
    public class Visitantes : IReturn<DbSetReponseBase<PessoaBean>>
    {
        public int EstabelecimentoId { get; set; }
    }
}