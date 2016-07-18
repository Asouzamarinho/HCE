using System;
using System.Linq;
using Cruzeiro.Core.Bll;
using Cruzeiro.Core.Model;
using Cruzeiro.Core.Model.Beans;
using Cruzeiro.Core.Model.Context;
using Cruzeiro.Core.Model.Enum;
using Cruzeiro.WebService.Core.DTO;
using ServiceStack.ServiceInterface;
using Cruzeiro.WebService.Core.Tools;

namespace Cruzeiro.WebService.Core.Server
{
    public class CruzeiroWebServiceServer : Service
    {
        public object Any(Estabelecimentos request)
        {
            return new DbSetReponseBase<EstabelecimentoBean>
                   {
                       All = new CruzeiroContext().Estabelecimentos.AsEnumerable()
                                                  .ConvertToBean<EstabelecimentoBean>().ToArray()
                   };
        }

        public object Any(Cursos request)
        {
            return new DbSetReponseBase<CursoBean>
                   {
                       All = new CruzeiroContext().Cursos.AsEnumerable()
                                                  .ConvertToBean<CursoBean>().ToArray()
                   };
        }

        public object Any(Turmas request)
        {
            return new DbSetReponseBase<TurmaBean>
                   {
                       All =
                           new CruzeiroContext().Turmas.AsEnumerable()
                                                .Where(_ => _.EstabelecimentoId == request.EstabelecimentoId &&
                                                            _.CursoId == request.CursoId)
                                                .ConvertToBean<TurmaBean>().ToArray()
                   };
        }

        public object Any(Alunos request)
        {
            var turmaId = request.TurmaId;
            return new DbSetReponseBase<PessoaBean>
                   {
                       All =
                           new CruzeiroContext().Pessoas.AsEnumerable()
                                                .Where(
                                                    _ => _.TipoPessoaId == TipoPessoaEnum.ALUNO && _.TurmaId == turmaId)
                                                .ConvertToBean<PessoaBean>().ToArray()
                   };
        }

        public object Any(Funcionarios request)
        {
            var estabelecimentoId = request.EstabelecimentoId;
            return new DbSetReponseBase<PessoaBean>
                   {
                       All =
                           new CruzeiroContext().Pessoas.AsEnumerable()
                                                .Where(
                                                    _ =>
                                                    _.TipoPessoaId == TipoPessoaEnum.FUNCIONARIO &&
                                                    _.EstabelecimentoId == estabelecimentoId)
                                                .ConvertToBean<PessoaBean>().ToArray()
                   };
        }

        public object Any(Visitantes request)
        {
            var estabelecimentoId = request.EstabelecimentoId;
            return new DbSetReponseBase<PessoaBean>
                   {
                       All =
                           new CruzeiroContext().Pessoas.AsEnumerable()
                                                .Where(
                                                    _ =>
                                                    _.TipoPessoaId == TipoPessoaEnum.VISITANTE &&
                                                    _.EstabelecimentoId == estabelecimentoId)
                                                .ConvertToBean<PessoaBean>().ToArray()
                   };
        }

        public object Any(CreateVisitante request)
        {
            Pessoa pessoa;
            try
            {
                var context = new CruzeiroContext();
                pessoa = new Pessoa
                         {
                             EstabelecimentoId = request.EstabelecimentoId,
                             Name = request.Name,
                             Documento = request.Documento,
                             TipoPessoaId = TipoPessoaEnum.VISITANTE
                         };
                context.Pessoas.Add(pessoa);
                context.SaveChanges();
            }
            catch
            {
                pessoa = null;
            }
            return new CreateVisitanteResponse
                   {
                       Result = pessoa != null
                                    ? new PessoaBean
                                      {
                                          Id = pessoa.Id,
                                          Documento = pessoa.Documento,
                                          EstabelecimentoId = pessoa.EstabelecimentoId,
                                          Name = pessoa.Name
                                      }
                                    : null
                   };
        }

        public object Any(RegisterTag request)
        {
            bool ok;
            var context = new CruzeiroContext();
            using (var tr = context.Database.BeginTransaction())
            {
                try
                {
                    var pessoa = context.Pessoas.Find(request.PessoaId);
                    pessoa.Epc = request.Epc;
                    context.SaveChanges();
                    tr.Commit();
                    ok = true;
                }
                catch
                {
                    tr.Rollback();
                    ok = false;
                }
            }
            return new BoolResponse
                   {
                       Result = ok
                   };
        }

        public object Any(GetQfe request)
        {
            var pessoas = new CruzeiroContext().Pessoas.AsEnumerable().ToArray();
            return new DbSetReponseBase<PessoaBean>
                   {
                       All = pessoas.Take(Math.Min(request.Count, pessoas.Length)).ToArray()
                                    .ConvertToBean<PessoaBean>().ToArray()
                   };
        }

        public object Any(GetQfs request)
        {
            var pessoas = new CruzeiroContext().Pessoas.AsEnumerable().ToArray();
            return new DbSetReponseBase<PessoaBean>
                   {
                       All = pessoas.Take(Math.Min(request.Count, pessoas.Length)).ToArray()
                                    .ConvertToBean<PessoaBean>().ToArray()
                   };
        }

        public object Any(GetPessoaByEpc request)
        {
            var pessoa = new PessoaBll().GetPessoaByEpc(request.Epc);
            return new GetPessoaByEpcReponse
            {
                Result = pessoa != null
                    ? new PessoaBean
                {
                    AnoEntrada = pessoa.AnoEntrada,
                    Documento = pessoa.Documento,
                    Epc = pessoa.Epc,
                    EstabelecimentoId = pessoa.EstabelecimentoId,
                    Id = pessoa.Id,
                    LastChange = pessoa.LastChange,
                    Matricula = pessoa.Matricula,
                    Name = pessoa.Name,
                    TipoPessoaId = pessoa.TipoPessoaId,
                    TurmaId = pessoa.TurmaId
                }
                    : null
            };
        }

        public object Any(RemoveVisitante request)
        {
            bool ok = false;

            var pessoaBll = new PessoaBll();
            var pessoa = pessoaBll.GetPessoaById(request.PessoaId);
            if (pessoa != null && pessoa.TipoPessoaId == TipoPessoaEnum.VISITANTE)
            {
                ok = pessoaBll.RemovePessoa(request.PessoaId);
            }

            return new BoolResponse
            {
                Result = ok
            };
        }
    }
}