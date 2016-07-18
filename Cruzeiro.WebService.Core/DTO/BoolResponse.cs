using ServiceStack.ServiceInterface.ServiceModel;

namespace Cruzeiro.WebService.Core.DTO
{
    public class BoolResponse
    {
        public ResponseStatus ResponseStatus { get; set; } //Automatic exception handling

        public bool Result { get; set; }
    }
}