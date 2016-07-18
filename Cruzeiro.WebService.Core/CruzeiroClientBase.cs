namespace Cruzeiro.WebService.Core
{
    public class CruzeiroClientBase
    {
        private static string _baseUrl = "139.82.28.105";
        private static int _port = 3216;

        public static string BaseUrl
        {
            get { return _baseUrl; }
            set { _baseUrl = value; }
        }

        public static int Port
        {
            get { return _port; }
            set { _port = value; }
        }

        protected static string Url
        {
            get { return string.Format("http://{0}:{1}", BaseUrl, Port); }
        }
    }
}