using System;
using System.Collections.Generic;
using System.Timers;

namespace POC.StateMachine
{
    public class DetectionState
    {
        public SentidoEnum Sentido { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }

        private readonly Timer _timeOut;
        private int? _sentido;
        private int _lowCount;

        private readonly Dictionary<int, SentidoEnum> _port2Sentido =
            new Dictionary<int, SentidoEnum>
            {
                {1, SentidoEnum.A_B},
                {2, SentidoEnum.B_A}
            };

        public DetectionState()
        {
            _timeOut = new Timer(5000) {AutoReset = false};
            _timeOut.Elapsed += (sender, args) =>
            {
                _sentido = null;
            };
        }

        public ActionEnum ProcessTransition(ushort portNumber, bool state)
        {
            var action = ActionEnum.OK;
            if (!_port2Sentido.ContainsKey(portNumber))
            {
                Sentido = SentidoEnum.NONE;
                action = ActionEnum.INVALID;
            }
            else
            {
                if (!_sentido.HasValue)
                {
                    if (state)
                    {
                        BeginTime = DateTime.Now;
                        Sentido = _port2Sentido[portNumber];
                        action = ActionEnum.BEGIN_READ_TAGS;
                        _timeOut.Start();
                        _lowCount = 0;
                    }
                }
                else
                {
                    if (!state)
                    {
                        if (_sentido == portNumber)
                        {
                            if (_lowCount == 0)
                            {
                                ++_lowCount;
                            }
                            else
                            {
                                EndTime = DateTime.Now;
                                _timeOut.Stop();
                                _sentido = null;
                                action = ActionEnum.END_READ_TAGS;
                                Sentido = _port2Sentido[portNumber];
                            }
                        }
                    }
                }
            }

            return action;
        }
    }
}