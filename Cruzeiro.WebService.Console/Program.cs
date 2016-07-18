using System;
using Cruzeiro.WebService.Core;

namespace Cruzeiro.WebService.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            StartCoreServer(args);

            while (System.Console.ReadKey().Key != ConsoleKey.Q)
            {
            }
        }

        public static void StartCoreServer(string[] args)
        {
            var listeningOn =
                args.Length == 0
                    ? string.Format("http://*:{0}/", CruzeiroClientBase.Port)
                    : args[0];
            var totalTagHost = new CruzeiroTagHost();
            totalTagHost.Init();
            totalTagHost.Start(listeningOn);

            System.Console.WriteLine(@"CruzeiroTagHost Created at {0}, listening on {1}",
                DateTime.Now, listeningOn);
        }
    }
}
