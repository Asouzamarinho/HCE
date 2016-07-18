using TotalTag.Common.Tools.Register;

namespace Cruzeiro.Core.Model
{
    public class PortalConfig
    {
        [RegistryProperty(Default = "localhost")]
        public string WebServiceUrl { get; set; }
        
        [RegistryProperty(Default = "Teste")]
        public string PortalName { get; set; }
    }
}