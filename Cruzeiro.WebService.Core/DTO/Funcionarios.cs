using Cruzeiro.Core.Model.Beans;
using ServiceStack.ServiceHost;

namespace Cruzeiro.WebService.Core.DTO
{
    [Route("/Funcionarios")]
    public class Funcionarios : IReturn<DbSetReponseBase<PessoaBean>>
    {
        public int EstabelecimentoId { get; set; }
    }
}