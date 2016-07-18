using System;
using System.Linq;
using Cruzeiro.Core.Model;
using Cruzeiro.Core.Model.Beans;
using Cruzeiro.Core.Model.Enum;

namespace Cruzeiro.Core.Bll
{
    public class RegraPortalBll : BaseBll<RegraPortal>
    {
        public const int TOLERANCIA_MINUTOS_ANTES_ENTRADA = 10;
        public const int TOLERANCIA_MINUTOS_APOS_ENTRADA = 10;
        public const int TOLERANCIA_MINUTOS_ANTES_SAIDA = 10;
        public const int TOLERANCIA_MINUTOS_APOS_SAIDA = 10;

        public RegraPortal[] GetRegra(PessoaBean pessoa, DateTime data)
        {
            if (pessoa.TipoPessoaId != TipoPessoaEnum.ALUNO)
            {
                return null;
            }
            var pessoaId = pessoa.Id;
            var turmaId = pessoa.TurmaId;
            var diaSemana = data.DayOfWeek;
            data = data.Date;
            var regras = (from _ in Context.RegraPortals
                          where (_.PessoaId == pessoaId || _.TurmaId == turmaId) &&
                                (_.DataEspecifica == data || _.DiaSemana == diaSemana)
                          select _).ToArray();
            if (regras.Any(_ => _.PessoaId.HasValue))
            {
                regras = regras.Where(_ => _.PessoaId.HasValue).ToArray();
            }
            if (regras.Any(_ => _.DataEspecifica.HasValue))
            {
                regras = regras.Where(_ => _.DataEspecifica.HasValue).ToArray();
            }
            return regras;
        }

        public StatusEventoEnum GetRegraStatus(PessoaBean pessoa, DateTime dateTime, SentidoEventoEnum sentido)
        {
            var data = dateTime.Date;
            var regras = GetRegra(pessoa, data);
            var statusEvento = StatusEventoEnum.INVALIDO;

            if (!regras.Any())
            {
                statusEvento = StatusEventoEnum.DIA_ERRADO;
            }
            else
            {
                switch (sentido)
                {
                    case SentidoEventoEnum.ENTRADA:
                        var entradaMin = dateTime.AddMinutes(TOLERANCIA_MINUTOS_ANTES_ENTRADA).Subtract(data);
                        var entradaMax = dateTime.AddMinutes(-TOLERANCIA_MINUTOS_APOS_ENTRADA).Subtract(data);
                        if (regras.Any(_ => _.Entrada <= entradaMin && _.Entrada >= entradaMax))
                        {
                            statusEvento = StatusEventoEnum.ENTRADA_PERMITIDA;
                        }
                        if (regras.Min(_ => _.Entrada) > entradaMin)
                        {
                            statusEvento = StatusEventoEnum.ENTRADA_ADIANTADA;
                        }
                        if (regras.Max(_ => _.Entrada) < entradaMax)
                        {
                            statusEvento = StatusEventoEnum.ENTRADA_ATRASADA;
                        }
                        break;

                    case SentidoEventoEnum.SAIDA:
                        var saidaMin = dateTime.AddMinutes(TOLERANCIA_MINUTOS_ANTES_SAIDA).Subtract(data);
                        var saidaMax = dateTime.AddMinutes(-TOLERANCIA_MINUTOS_APOS_SAIDA).Subtract(data);
                        if (regras.Any(_ => _.Saida <= saidaMin && _.Saida >= saidaMax))
                        {
                            statusEvento = StatusEventoEnum.SAIDA_PERMITIDA;
                        }
                        if (regras.Min(_ => _.Saida) > saidaMin)
                        {
                            statusEvento = StatusEventoEnum.SAIDA_ADIANTADA;
                        }
                        if (regras.Max(_ => _.Saida) < saidaMax)
                        {
                            statusEvento = StatusEventoEnum.SAIDA_ATRASADA;
                        }
                        break;

                    case SentidoEventoEnum.NADA:
                        statusEvento = StatusEventoEnum.INVALIDO;
                        break;
                }
            }

            return statusEvento;
        }
    }
}
