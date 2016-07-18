using System;
using System.Collections.Generic;
using System.Linq;
using Cruzeiro.Core.Model;
using Cruzeiro.Core.Model.Context;
using Cruzeiro.Core.Model.Enum;
using TotalTag.Common.Bean;
using TotalTag.Common.DTO;
using TotalTag.Common.Model;
using TotalTag.Monitor.Core.Providers;

namespace Portais.Presentation
{
    public class IdentificationProvider : IIdentificationProvider, IOperationProvider
    {
        private static Dictionary<int, Pessoa> _pessoas;
        private readonly string _portalName;

        public IdentificationProvider(string portalName)
        {
            _portalName = portalName;
            Update();
        }

        private static void Update()
        {
            var context = new CruzeiroContext();
            _pessoas = (from _ in context.Pessoas.AsEnumerable()
                        select _).ToDictionary(_ => _.Id, _ => _);
        }

        public AssetInstanceIdentifyBean[] IdentifyAssetInstanceByEpc(string[] epcs)
        {
            return (from _ in epcs
                    join __ in _pessoas.Values on _ equals __.Epc
                    select new AssetInstanceIdentifyBean
                    {
                        AssetInstanceId = __.Id,
                        Label = _
                    }).ToArray();
        }

        public bool InstanceAction(InstanceAction instanceAction)
        {
            var dateTime = DateTime.Now;
            var entradas = instanceAction.GetOperationsByType(RouteActionTypeEnum.PRESENCE);
            var saidas = instanceAction.GetOperationsByType(RouteActionTypeEnum.LEAVING);

            if (entradas != null)
            {
                foreach (var move in entradas)
                {
                    Pessoa pessoa;
                    if (_pessoas.TryGetValue(move.Key, out pessoa))
                    {
                        OnMovimentacao(new MovimentacaoArgs
                        {
                            DateTime = dateTime,
                            PortalName = _portalName,
                            Sentido = SentidoEventoEnum.ENTRADA,
                            Pessoa = pessoa
                        });
                    }
                }
            }
            if (saidas != null)
            {
                foreach (var move in saidas)
                {
                    Pessoa pessoa;
                    if (_pessoas.TryGetValue(move.Key, out pessoa))
                    {
                        OnMovimentacao(new MovimentacaoArgs
                        {
                            DateTime = dateTime,
                            PortalName = _portalName,
                            Sentido = SentidoEventoEnum.SAIDA,
                            Pessoa = pessoa
                        });
                    }
                }
            }
            return true;
        }

        public event Movimentacao Movimentacao;

        protected virtual void OnMovimentacao(MovimentacaoArgs args)
        {
            var handler = Movimentacao;
            if (handler != null) handler(this, args);
        }
    }

    public delegate void Movimentacao(object sender, MovimentacaoArgs args);

    public class MovimentacaoArgs
    {
        public string PortalName { get; set; }
        public SentidoEventoEnum Sentido { get; set; }
        public DateTime DateTime { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}