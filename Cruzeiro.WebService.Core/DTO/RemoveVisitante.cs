using ServiceStack.ServiceHost;

namespace Cruzeiro.WebService.Core.DTO
{
    public class RemoveVisitante : IReturn<BoolResponse>
    {
        public int PessoaId { get; set; }
    }
}