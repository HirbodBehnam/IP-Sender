namespace IP_Sender
{
    class Config
    {
        public class Proxy
        {
            public string IP { get; set; }
            public int Port { get; set; }
            public string User { get; set; }
            public string Password { get; set; }
        }
        public string PCName { get; set; }
        public string Token { get; set; }
        public string Password { get; set; }
        public Proxy proxy { get; set; }
        public bool LogFails { get; set; }
        public bool LogSends { get; set; }
    }
    
}
