using Cruzeiro.Core.Model.Beans;
using ServiceStack.ServiceHost;

namespace Cruzeiro.WebService.Core.DTO
{
    [Route("/Alunos")]
    public class Alunos : IReturn<DbSetReponseBase<PessoaBean>>
    {
        public int TurmaId { get; set; }
    }
}