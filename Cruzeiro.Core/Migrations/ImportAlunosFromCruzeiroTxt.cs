using System;
using System.Linq;
using System.Text.RegularExpressions;
using Cruzeiro.Core.Model;
using Cruzeiro.Core.Model.Context;
using Cruzeiro.Core.Model.Enum;

namespace Cruzeiro.Core.Migrations
{
    public class ImportAlunosFromCruzeiroTxt
    {
        private readonly string[] _dados;
        private Aluno[] _alunos;

        public ImportAlunosFromCruzeiroTxt()
            : this(Resources.Exportar_Dados)
        {
        }

        public ImportAlunosFromCruzeiroTxt(string text)
        {
            _dados = Regex.Split(text, "\r\n|\r|\n").Skip(1).ToArray();
        }

        public void Do(CruzeiroContext context)
        {
            _alunos = _dados.Select(_ => new Aluno(_)).ToArray();

            foreach (var aluno in _alunos)
            {
                if (aluno.Ok &&
                    !string.IsNullOrWhiteSpace(aluno.Estabelecimento) &&
                    !string.IsNullOrWhiteSpace(aluno.Curso) &&
                    !string.IsNullOrWhiteSpace(aluno.Turma) &&
                    !string.IsNullOrWhiteSpace(aluno.NomeAluno))
                {
                    var estabelecimento = GetEstabelecimento(context, aluno);
                    var curso = GetCurso(context, aluno);
                    var turma = GetTurma(context, aluno, estabelecimento, curso);
                    GetPessoa(context, aluno, estabelecimento, turma, TipoPessoaEnum.ALUNO);
                }
            }
        }

        private static Estabelecimento GetEstabelecimento(CruzeiroContext context, Aluno aluno)
        {
            var estabelecimento =
                context.Estabelecimentos.FirstOrDefault(_ => _.Name.ToUpper() == aluno.Estabelecimento.ToUpper());
            if (estabelecimento == null)
            {
                estabelecimento = context.Estabelecimentos.Add(new Estabelecimento
                                                               {
                                                                   Name = aluno.Estabelecimento
                                                               });
                context.SaveChanges();
            }
            return estabelecimento;
        }

        private static Curso GetCurso(CruzeiroContext context, Aluno aluno)
        {
            var curso = context.Cursos.FirstOrDefault(_ => _.Name.ToUpper() == aluno.Curso.ToUpper());
            if (curso == null)
            {
                curso = context.Cursos.Add(new Curso
                                           {
                                               Name = aluno.Curso
                                           });
                context.SaveChanges();
            }
            return curso;
        }

        private static Turma GetTurma(CruzeiroContext context, Aluno aluno, Estabelecimento estabelecimento, Curso curso)
        {
            var turma = context.Turmas.FirstOrDefault(_ => _.Name.ToUpper() == aluno.Turma.ToUpper() &&
                                                           _.EstabelecimentoId == estabelecimento.Id &&
                                                           _.CursoId == curso.Id);
            if (turma == null)
            {
                turma = context.Turmas.Add(new Turma
                                           {
                                               CursoId = curso.Id,
                                               EstabelecimentoId = estabelecimento.Id,
                                               Name = aluno.Turma
                                           });
                context.SaveChanges();
            }
            return turma;
        }

        private static void GetPessoa(CruzeiroContext context, Aluno aluno, Estabelecimento estabelecimento, Turma turma, TipoPessoaEnum tipoPessoaId)
        {
            var pessoa = context.Pessoas.FirstOrDefault(_ => _.Matricula == aluno.Matricula);
            if (pessoa == null)
            {
                context.Pessoas.Add(new Pessoa
                                          {
                                              AnoEntrada = aluno.AnoDeEntrada,
                                              Name = aluno.NomeAluno,
                                              Matricula = aluno.Matricula,
                                              TurmaId = turma.Id,
                                              TipoPessoaId = tipoPessoaId,
                                              EstabelecimentoId = estabelecimento.Id
                                          });
                context.SaveChanges();
            }
        }

        public class Aluno
        {
            public int PeriodoLetivo { get; set; }
            public int AnoDeEntrada { get; set; }
            public string Estabelecimento { get; set; }
            public string Curso { get; set; }
            public string Turma { get; set; }
            public int Matricula { get; set; }
            public string NomeAluno { get; set; }

            public bool Ok { get; set; }
            public Aluno(string text)
            {
                int periodoLetivo=0;
                int anoDeEntrada=0;
                int matricula=0;

                var dados = text.Split(new[] {'\t'}, StringSplitOptions.None).ToArray();
                Ok = dados.Length == 7 &&
                     int.TryParse(dados[0], out periodoLetivo) &&
                     int.TryParse(dados[1], out anoDeEntrada) &&
                     int.TryParse(dados[5], out matricula);
                if (Ok)
                {
                    PeriodoLetivo = periodoLetivo;
                    AnoDeEntrada = anoDeEntrada;
                    Matricula = matricula;

                    Estabelecimento = dados[2];
                    Curso = dados[3];
                    Turma = dados[4];
                    NomeAluno = dados[6];
                }
            }
        }
    }
}