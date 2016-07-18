using ServiceStack.ServiceHost;

namespace Cruzeiro.WebService.Core.DTO
{
    public class RegisterTag : IReturn<BoolResponse>
    {
        public int PessoaId { get; set; }
        public string Epc { get; set; }
    }
}