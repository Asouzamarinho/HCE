using Cruzeiro.WebService.Core.Server;
using ServiceStack.WebHost.Endpoints;

namespace Cruzeiro.WebService.Console
{
    public class CruzeiroTagHost : AppHostHttpListenerBase
    {
        public CruzeiroTagHost()
            : base("HttpListener Self-Host", typeof(CruzeiroWebServiceServer).Assembly) { }

        public override void Configure(Funq.Container container)
        {
        }
    }
}