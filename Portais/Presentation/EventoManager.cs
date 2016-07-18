using System;
using Cruzeiro.Core.Bll;
using Cruzeiro.Core.Model;
using TotalTag.Common;
using TotalTag.Monitor.Core.Detection;

namespace Portais.Presentation
{
    public class EventoManager : IStartStop, IDisposable
    {
        private readonly IdentificationProvider _provider;
        private readonly string _portalName;

        public EventoManager()
        {
            _portalName = LeitorBll.GetLeitorName();
            _provider = new IdentificationProvider(_portalName);
            _provider.Movimentacao += ProviderOnMovimentacao;
            DetectionManager.Create(_provider, _provider);
        }

        private void ProviderOnMovimentacao(object sender, MovimentacaoArgs args)
        {
            var status = new RegraPortalBll().GetRegraStatus(args.Pessoa, args.DateTime, args.Sentido);
            var evento = new EventoPortal
            {
                DateTime = args.DateTime,
                PessoaId = args.Pessoa.Id,
                SentidoEvento = args.Sentido,
                StatusEvento = status,
                PortalName = _portalName
            };
            new EventoPortalBll().InsertEvento(evento);
            OnEventoProcessado(evento);
        }

        public bool Start()
        {
            return DetectionManager.Instance.Start();
        }

        public bool Stop()
        {
            return DetectionManager.Instance.Stop();
        }

        public void Dispose()
        {
            _provider.Movimentacao -= ProviderOnMovimentacao;
        }

        public event EventoProcessado EventoProcessado;

        protected virtual void OnEventoProcessado(EventoPortal args)
        {
            var handler = EventoProcessado;
            if (handler != null) handler(this, args);
        }
    }

    public delegate void EventoProcessado(object sender, EventoPortal evento);
}