using System.IO;
using System.Runtime.Versioning;
using Cruzeiro.Core.Model;
using Cruzeiro.Core.Model.Context;
using Cruzeiro.Core.Model.Enum;

namespace Cruzeiro.Core.Migrations
{
    using System.Data.Entity;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Cruzeiro.Core.Model.Context.CruzeiroContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CruzeiroContext context)
        {
            SeedTipoPessoa(context);
            new ImportAlunosFromCruzeiroTxt(Resources.Exportar_Dados).Do(context);
            new ImportProfFuncFromCruzeiroTxt(Resources.Importação_de_Funcionários).Do(context);
        }

        private void SeedTipoPessoa(CruzeiroContext context)
        {
            var tipoPessoas = new []
                              {
                                  TipoPessoaEnum.INVALIDO,
                                  TipoPessoaEnum.ALUNO,
                                  TipoPessoaEnum.PROFESSOR,
                                  TipoPessoaEnum.FUNCIONARIO,
                                  TipoPessoaEnum.TERCEIRIZADO,
                                  TipoPessoaEnum.CONSULTOR,
                                  TipoPessoaEnum.VISITANTE,
                              };
            foreach (var tipoPessoa in tipoPessoas)
            {
                context.TipoPessoas.Add(new TipoPessoa
                                        {
                                            Id = tipoPessoa,
                                            Name = tipoPessoa.ToString()
                                        });
            }
            context.SaveChanges();
        }
    }
}
