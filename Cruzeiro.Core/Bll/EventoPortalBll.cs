using System;
using System.Collections.Generic;
using System.Linq;
using Cruzeiro.Core.Model;
using Cruzeiro.Core.Model.Enum;

namespace Cruzeiro.Core.Bll
{
    public class EventoPortalBll : BaseBll<EventoPortal>
    {
        public const int TOLERANCIA_MINUTOS = 10;

        public EventoPortal InsertEvento(EventoPortal evento)
        {
            evento = Context.EventoPortals.Add(evento);
            Context.SaveChanges();
            return evento;
        }
        
        public delegate void EventoPassagem(object sender, EventoPassagemArgs args);

        public class EventoPassagemArgs
        {
            public EventoPortal Evento { get; set; }
        }

        public IEnumerable<EventoPortal> GetEventosPorData(DateTime data)
        {
            var begin = data.Date;
            var end = begin.AddDays(1);
            return (from _ in Context.EventoPortals
                    where _.DateTime <= begin && _.DateTime < end
                    orderby _.DateTime descending 
                    select _).ToArray();
        }
    }
}