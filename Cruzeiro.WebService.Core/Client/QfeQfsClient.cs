using System;
using Cruzeiro.Core.Model.Beans;
using Cruzeiro.WebService.Core.DTO;
using ServiceStack.ServiceClient.Web;

namespace Cruzeiro.WebService.Core.Client
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A qfe qfs client. </summary>
    ///
    /// <remarks>   Danim, 31/05/2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class QfeQfsClient : CruzeiroClientBase
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets a qfe. </summary>
        ///
        /// <remarks>   Danim, 31/05/2016. </remarks>
        ///
        /// <param name="dateTime"> The date time. </param>
        /// <param name="count">    Number of. </param>
        ///
        /// <returns>   An array of pessoa bean. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public PessoaBean[] GetQfe(DateTime dateTime, int count)
        {
            var client = new JsonServiceClient(Url);
            var response = client.Send(new GetQfe
                                       {
                                           DateTime = dateTime,
                                           Count = count
                                       });
            return response.All;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets the qfs. </summary>
        ///
        /// <remarks>   Danim, 31/05/2016. </remarks>
        ///
        /// <param name="dateTime"> The date time. </param>
        /// <param name="count">    Number of. </param>
        ///
        /// <returns>   An array of pessoa bean. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public PessoaBean[] GetQfs(DateTime dateTime, int count)
        {
            var client = new JsonServiceClient(Url);
            var response = client.Send(new GetQfe
                                       {
                                           DateTime = dateTime,
                                           Count = count
                                       });
            return response.All;
        }
    }
}