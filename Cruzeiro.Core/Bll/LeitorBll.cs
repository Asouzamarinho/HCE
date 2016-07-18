using System;
using System.Linq;
using Cruzeiro.Core.Model;
using TotalTag.Common.Model;
using TotalTag.Common.Tools.Register;
using TotalTag.Monitor.Config.Bll;
using TotalTag.Monitor.Config.Enum;
using TotalTag.Monitor.Config.Model;

namespace Cruzeiro.Core.Bll
{
    public class LeitorBll : BaseBll<Leitor>
    {
        private static PortalConfig _portalConfig;

        public Leitor GetLeitor()
        {
            return GetLeitor(GetLeitorName());
        }

        public static string GetLeitorName()
        {
            if (_portalConfig == null)
            {
                _portalConfig = RegistryConfig.Load<PortalConfig>();
            }
            return _portalConfig.PortalName;
        }

        public Leitor GetLeitor(string name)
        {
            name = name.Trim().ToUpper();
            return Context.Leitors.FirstOrDefault(_ => _.Name.Trim().ToUpper() == name);
        }

        public int SetConfiguracaoLeitor(string name)
        {
            var leitor = GetLeitor();
            var antennasInN =
                leitor.AntennasIn.Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var antennasOutN =
                leitor.AntennasOut.Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var readerConfigBll = new ReaderConfigBll();
            readerConfigBll.Clear();
            var reader = readerConfigBll.InsertReader(new Reader
            {
                Address = leitor.Address,
                ReaderType = ReaderTypeEnum.IMPINJ_REVOLUTION
            });

            var antennasIn = antennasInN.Select(antenna => readerConfigBll.InsertAntenna(new Antenna(antenna)
            {
                ReaderId = reader.Id
            })).ToArray();
            var antennasOut = antennasOutN.Select(antenna => readerConfigBll.InsertAntenna(new Antenna(antenna)
            {
                ReaderId = reader.Id
            })).ToArray();

            foreach (Antenna antennaIn in antennasIn)
            {
                foreach (Antenna antennaOut in antennasOut)
                {
                    readerConfigBll.InsertRouteAction(
                        new[] {antennaOut, antennaIn},
                        RouteActionTypeEnum.PRESENCE,
                        string.Format("{0}=>{1}", antennaOut.Id, antennaIn.Id),
                        leitor.EstabelecimentoId);
                    readerConfigBll.InsertRouteAction(
                        new[] {antennaIn, antennaOut},
                        RouteActionTypeEnum.LEAVING,
                        string.Format("{0}=>{1}", antennaIn.Id, antennaOut.Id),
                        0);
                }
            }
            readerConfigBll.Save();
            return leitor.EstabelecimentoId;
        }

        public void SetConfiguracaoLeitor()
        {
            SetConfiguracaoLeitor(GetLeitorName());
        }
    }
}