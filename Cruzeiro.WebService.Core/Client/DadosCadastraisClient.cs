////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Client\DadosCadastraisClient.cs
//
// summary:	Implements the dados cadastrais client class
////////////////////////////////////////////////////////////////////////////////////////////////////

using Cruzeiro.Core.Model.Beans;
using Cruzeiro.WebService.Core.DTO;
using ServiceStack.ServiceClient.Web;

namespace Cruzeiro.WebService.Core.Client
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   API de acesso aos dados cadastrais. </summary>
    ///
    /// <remarks>   Danim, 25/05/2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class DadosCadastraisClient : CruzeiroClientBase
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Retorna os estabelecimentos. </summary>
        ///
        /// <remarks>   Danim, 25/05/2016. </remarks>
        ///
        /// <returns>   An array of estabelecimento bean. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public EstabelecimentoBean[] GetEstabelecimentos()
        {
            var client = new JsonServiceClient(Url);
            var response = client.Send(new Estabelecimentos());
            return response.All;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Retorna os cursos. </summary>
        ///
        /// <remarks>   Danim, 25/05/2016. </remarks>
        ///
        /// <returns>   An array of curso bean. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public CursoBean[] GetCursos()
        {
            var client = new JsonServiceClient(Url);
            var response = client.Send(new Cursos());
            return response.All;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Retorna as turmas de um estabelecimento e curso. </summary>
        ///
        /// <remarks>   Danim, 25/05/2016. </remarks>
        ///
        /// <param name="estabelecimento">  O estabelecimento. </param>
        /// <param name="curso">            O curso. </param>
        ///
        /// <returns>   An array of turma bean. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public TurmaBean[] GetAllTurmas(EstabelecimentoBean estabelecimento, CursoBean curso)
        {
            var client = new JsonServiceClient(Url);
            var response = client.Send(new Turmas
                                       {
                                           EstabelecimentoId = estabelecimento.Id,
                                           CursoId = curso.Id
                                       });
            return response.All;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Retorna os alunos de uma turma. </summary>
        ///
        /// <remarks>   Danim, 25/05/2016. </remarks>
        ///
        /// <param name="turma">    A turma. </param>
        ///
        /// <returns>   An array of pessoa bean. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public PessoaBean[] GetAlunos(TurmaBean turma)
        {
            var client = new JsonServiceClient(Url);
            var response = client.Send(new Alunos
                                       {
                                           TurmaId = turma.Id
                                       });
            return response.All;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Retorna os funcionarios de um estabelecimento. </summary>
        ///
        /// <remarks>   Danim, 25/05/2016. </remarks>
        ///
        /// <param name="estabelecimento">    A turma. </param>
        ///
        /// <returns>   An array of pessoa bean. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public PessoaBean[] GetFuncionarios(EstabelecimentoBean estabelecimento)
        {
            var client = new JsonServiceClient(Url);
            var response = client.Send(new Funcionarios
                                       {
                                           EstabelecimentoId = estabelecimento.Id
                                       });
            return response.All;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Retorna os visitantes de um estabelecimento. </summary>
        ///
        /// <remarks>   Danim, 25/05/2016. </remarks>
        ///
        /// <param name="estabelecimento">    A turma. </param>
        ///
        /// <returns>   An array of pessoa bean. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public PessoaBean[] GetVisitantes(EstabelecimentoBean estabelecimento)
        {
            var client = new JsonServiceClient(Url);
            var response = client.Send(new Visitantes
                                       {
                                           EstabelecimentoId = estabelecimento.Id
                                       });
            return response.All;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Cria novo visitante . </summary>
        ///
        /// <remarks>   Danim, 25/05/2016. </remarks>
        ///
        /// <param name="pessoa">    A pessoa. </param>
        ///
        /// <returns>   resultado PessoaBean. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public PessoaBean CreateVisitante(PessoaBean pessoa)
        {
            var client = new JsonServiceClient(Url);
            var response = client.Send(new CreateVisitante
            {
                EstabelecimentoId = pessoa.EstabelecimentoId,
                Name = pessoa.Name,
                Documento = pessoa.Documento
            });
            return response.Result;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Cria novo visitante . </summary>
        ///
        /// <remarks>   Danim, 03/06/2016. </remarks>
        ///
        /// <param name="estabelecimento">  O estabelecimento. </param>
        /// <param name="name">             O nome. </param>
        /// <param name="documento">        O documento. </param>
        ///
        /// <returns>   resultado PessoaBean. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public PessoaBean CreateVisitante(EstabelecimentoBean estabelecimento, string name, string documento)
        {
            var client = new JsonServiceClient(Url);
            var response = client.Send(new CreateVisitante
            {
                EstabelecimentoId = estabelecimento.Id,
                Name = name,
                Documento = documento
            });
            return response.Result;
        }

        public bool RemoveVisitante(PessoaBean pessoa)
        {
            var client = new JsonServiceClient(Url);
            var response = client.Send(new RemoveVisitante
            {
                PessoaId = pessoa.Id
            });
            return response.Result;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Retorna pessoa by epc. </summary>
        ///
        /// <remarks>   Danim, 05/06/2016. </remarks>
        ///
        /// <param name="epc">  O epc. </param>
        ///
        /// <returns>   A pessoa by epc. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public PessoaBean GetPessoaByEpc(string epc)
        {
            var client = new JsonServiceClient(Url);
            var response = client.Send(new GetPessoaByEpc
            {
                Epc = epc
            });
            return response.Result;
        }
    }
}
