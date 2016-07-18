using Cruzeiro.Core.Model.Beans;
using ServiceStack.ServiceHost;

namespace Cruzeiro.WebService.Core.DTO
{
    [Route("/Turmas")]
    public class Turmas : IReturn<DbSetReponseBase<TurmaBean>>
    {
        public int EstabelecimentoId { get; set; }
        public int CursoId { get; set; }
    }
}