using System;
using Cruzeiro.Core.Model.Beans;
using ServiceStack.ServiceHost;

namespace Cruzeiro.WebService.Core.DTO
{
    [Route("/GetQfs")]
    public class GetQfs : IReturn<DbSetReponseBase<PessoaBean>>
    {
        public DateTime DateTime { get; set; }
        public int Count { get; set; }
    }
}