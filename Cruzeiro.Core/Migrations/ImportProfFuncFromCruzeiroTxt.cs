using System;
using System.Linq;
using System.Text.RegularExpressions;
using Cruzeiro.Core.Model;
using Cruzeiro.Core.Model.Context;
using Cruzeiro.Core.Model.Enum;

namespace Cruzeiro.Core.Migrations
{
    public class ImportProfFuncFromCruzeiroTxt
    {
        private readonly string[] _dados;
        private Funcionario[] _funcionarios;

        public ImportProfFuncFromCruzeiroTxt(string text)
        {
            _dados = Regex.Split(text, "\r\n|\r|\n").Skip(1).ToArray();
        }

        public void Do(CruzeiroContext context)
        {
            var estabelecimento = context.Estabelecimentos.AsEnumerable().First();

            _funcionarios = _dados.Select(_ => new Funcionario(_)).ToArray();
            foreach (var funcionario in _funcionarios)
            {
                if (funcionario.Ok &&
                    !string.IsNullOrWhiteSpace(funcionario.Nome))
                {
                    var pessoa = context.Pessoas.FirstOrDefault(_ => _.Matricula == funcionario.Matricula);
                    if (pessoa == null)
                    {
                        context.Pessoas.Add(new Pessoa
                        {
                            Name = funcionario.Nome,
                            Matricula = funcionario.Matricula,
                            TipoPessoaId = funcionario.TipoPessoa,
                            EstabelecimentoId = estabelecimento.Id
                        });
                        context.SaveChanges();
                    }
                }
            }
        }
    }
    
    public class Funcionario
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public TipoPessoaEnum TipoPessoa { get; set; }
        public bool Ok { get; set; }

        public Funcionario(string text)
        {
            int matricula = 0;

            var dados = text.Split(new[] {'\t'}, StringSplitOptions.None).ToArray();
            Ok = dados.Length == 3 && int.TryParse(dados[0], out matricula);
            if (Ok)
            {
                Matricula = matricula;
                Nome = dados[1];
                switch (dados[2])
                {
                    case "PROFESSOR":
                        TipoPessoa = TipoPessoaEnum.PROFESSOR;
                        break;
                    case "FUNCIONARIO":
                        TipoPessoa = TipoPessoaEnum.FUNCIONARIO;
                        break;
                    default:
                        Ok = false;
                        break;
                }
            }
        }
    }
}