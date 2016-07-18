using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using Cruzeiro.Core.Except;
using Cruzeiro.Core.Model;
using Cruzeiro.Core.Model.Beans;
using TotalTag.Common.Tools;

namespace Cruzeiro.Core.Bll
{
    public class PessoaBll : BaseBll<Pessoa>
    {
        public Pessoa GetPessoaById(int id)
        {
            return Context.Pessoas.Find(id);
        }

        public Pessoa GetPessoaByEpc(string epc)
        {
            epc = epc.Replace("-", "").ToUpper();
            return Context.Pessoas.FirstOrDefault(_ => _.Epc == epc);
        }

        public Pessoa GetPessoaByMatricula(int matricula)
        {
            return Context.Pessoas.FirstOrDefault(_ => _.Matricula == matricula);
        }

        public Pessoa InsertPessoa(PessoaBean pessoaBean)
        {
            if (Context.Pessoas.Any(_ => _.Matricula == pessoaBean.Matricula))
            {
                throw new MatriculaPreexistenteException(pessoaBean.ToString());
            }
            if (GetPessoaByEpc(pessoaBean.Epc) != null)
            {
                throw new EpcPreexistenteException(pessoaBean.ToString());
            }
            var novaPessoa = Context.Pessoas.Add(
                new Pessoa
                {
                    Epc = pessoaBean.Epc,
                    Matricula = pessoaBean.Matricula,
                    Name = pessoaBean.Name,
                    TipoPessoaId = pessoaBean.TipoPessoaId,
                });
            Context.SaveChanges();
            return novaPessoa;
        }

        public Pessoa AlteraPessoa(PessoaBean pessoaBean)
        {
            var pessoaPortal = GetPessoaById(pessoaBean.Id);
            if (pessoaPortal == null)
            {
                throw new InstanceNotFoundException(pessoaBean.ToString());
            }
            pessoaPortal.Epc = pessoaBean.Epc;
            pessoaPortal.Name = pessoaBean.Name;
            pessoaPortal.TipoPessoaId = pessoaBean.TipoPessoaId;
            Context.SaveChanges();
            return pessoaPortal;
        }

        public Pessoa AtualizaPessoa(PessoaBean pessoaBean)
        {
            Pessoa pessoa;
            try
            {
                pessoa = AlteraPessoa(pessoaBean);
            }
            catch (InstanceNotFoundException)
            {
                pessoa = InsertPessoa(pessoaBean);
            }
            return pessoa;
        }

        public RegraPortal[] GetRegras(PessoaBean pessoaBean)
        {
            return GetRegras(pessoaBean.Id);
        }

        public RegraPortal[] GetRegras(int pessoaId)
        {
            return GetPessoaById(pessoaId).RegraPortals.ToArray();
        }

        public bool AtualizaRegras(PessoaBean pessoaBean, IEnumerable<RegraBean> regras)
        {
            return AtualizaRegras(pessoaBean.Id, regras);
        }

        public bool AtualizaRegras(int pessoaId, IEnumerable<RegraBean> regras)
        {
            using (var tr = Context.Database.BeginTransaction())
            {
                try
                {
                    var regrasAntigas = GetRegras(pessoaId);
                    Context.RegraPortals.RemoveRange(regrasAntigas);
                    Context.SaveChanges();

                    Context.RegraPortals.AddRange(regras.Select(_ =>
                        new RegraPortal
                        {
                            PessoaId = pessoaId,
                            DiaSemana = _.DiaSemana,
                            DataEspecifica = _.DataEspecifica.HasValue ? _.DataEspecifica.Value.Date : (DateTime?) null,
                            Entrada = _.Entrada,
                            Saida = _.Saida
                        }));
                    Context.SaveChanges();
                    tr.Commit();
                    return true;
                }
                catch
                {
                    tr.Rollback();
                    return false;
                }
            }
        }

        public RegraPortal[] GetRegras(PessoaBean pessoaBean, DateTime data)
        {
            return GetRegras(pessoaBean.Id, data);
        }

        private RegraPortal[] GetRegras(int matricula, DateTime data)
        {
            data = data.Date;
            var pessoa = GetPessoaByMatricula(matricula);
            // TODO
            var regras = (from _ in pessoa.RegraPortals
                          select _).ToArray();
            return regras;
        }

        public bool RemovePessoa(int pessoaId)
        {
            try
            {
                var pessoa = Context.Pessoas.Find(pessoaId);
                Context.Pessoas.Remove(pessoa);
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.Write(ex);
                return false;
            }
        }
    }
}