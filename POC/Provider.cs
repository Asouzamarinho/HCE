using System.Collections.Generic;
using System.Linq;
using TotalTag.Common.Bean;
using TotalTag.Common.DTO;
using TotalTag.Common.Model;
using TotalTag.Monitor.Core.Providers;

namespace POC
{
    public class Provider : IOperationProvider, IIdentificationProvider
    {
        private readonly AssetInstanceIdentify[] _assets;

        public Provider(Dictionary<string, string> tagConfig)
        {
            var array = tagConfig.ToArray();
            _assets = array.Select((t, i) => new AssetInstanceIdentify
            {
                AssetInstanceId = i + 1,
                AssetLocationId = 0,
                AssetTypeId = 1,
                Label = t.Key,
                Name = t.Value
            }).ToArray();
        }

        public bool InstanceAction(InstanceAction instanceAction)
        {
            var operations = instanceAction.GetOperationsByType(RouteActionTypeEnum.PRESENCE);
            if (operations != null)
            {
                var eventos = (from _ in operations
                               join __ in _assets on _.Key equals __.AssetInstanceId
                               select new Evento
                               {
                                   DateTime = instanceAction.DateTime,
                                   Operacao = _.Value == 2 ? "Saída" : "Entrada",
                                   Nome = __.Name
                               }).ToArray();
                OnEventos(new EventosEventArgs {Eventos = eventos});
            }
            return true;
        }

        public AssetInstanceIdentifyBean[] IdentifyAssetInstanceByEpc(string[] epcs)
        {
            return (from _ in epcs
                    join __ in _assets on _ equals __.Label
                    select __).Cast<AssetInstanceIdentifyBean>().ToArray();
        }

        public event EventosEvent Eventos;

        protected virtual void OnEventos(EventosEventArgs args)
        {
            var handler = Eventos;
            if (handler != null) handler(this, args);
        }
    }

    public delegate void EventosEvent(object sender, EventosEventArgs args);

    public class EventosEventArgs
    {
        public Evento[] Eventos { get; set; }
    }
}