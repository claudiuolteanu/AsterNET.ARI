namespace AsterNET.ARI
{
    public class StasisEndpoint
    {
        /// <summary>
        /// </summary>
        /// <param name="host"></param>
        /// <param name="port"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="pingPongInterval"></param>
        public StasisEndpoint(string host, int port, string username, string password, int? pingPongInterval = null)
        {
            Host = host;
            Port = port;
            Username = username;
            Password = password;
            PingPongInterval = pingPongInterval;
        }

        public string Host { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? PingPongInterval { get; set; }

        public string AriEndPoint
        {
            get { return string.Format("{0}://{1}:{2}/ARI", "http", Host, Port); }
        }
    }
}