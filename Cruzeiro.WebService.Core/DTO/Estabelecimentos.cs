using Cruzeiro.Core.Model.Beans;
using ServiceStack.ServiceHost;

namespace Cruzeiro.WebService.Core.DTO
{
    [Route("/Estabelecimentos")]
    public class Estabelecimentos : IReturn<DbSetReponseBase<EstabelecimentoBean>>
    {
    }
}