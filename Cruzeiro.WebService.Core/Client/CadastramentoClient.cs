using Cruzeiro.Core.Model.Beans;
using Cruzeiro.WebService.Core.DTO;
using ServiceStack.ServiceClient.Web;

namespace Cruzeiro.WebService.Core.Client
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Implementa a API de cadastramento. </summary>
    ///
    /// <remarks>   Danim, 25/05/2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class CadastramentoClient : CruzeiroClientBase
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Associa uma tag a uma pessoa. </summary>
        ///
        /// <remarks>   Danim, 25/05/2016. </remarks>
        ///
        /// <param name="pessoa">   A pessoa. </param>
        /// <param name="epc">      O EPC da tag. </param>
        ///
        /// <returns>   true if it succeeds, false if it fails. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool RegisterTag(PessoaBean pessoa, string epc)
        {
            var client = new JsonServiceClient(Url);
            var response = client.Send(new RegisterTag
                                       {
                                           PessoaId = pessoa.Id,
                                           Epc = epc
                                       });
            return response.Result;
        }
    }
}