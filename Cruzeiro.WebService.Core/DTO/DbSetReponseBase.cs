using ServiceStack.ServiceInterface.ServiceModel;

namespace Cruzeiro.WebService.Core.DTO
{
    public class DbSetReponseBase<T>
    {
        public ResponseStatus ResponseStatus { get; set; } //Automatic exception handling

        public T One { get; set; }
        public T[] All { get; set; }
    }
}