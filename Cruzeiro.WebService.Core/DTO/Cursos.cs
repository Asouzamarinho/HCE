using Cruzeiro.Core.Model.Beans;
using ServiceStack.ServiceHost;

namespace Cruzeiro.WebService.Core.DTO
{
    [Route("/Cursos")]
    public class Cursos : IReturn<DbSetReponseBase<CursoBean>>
    {
    }
}