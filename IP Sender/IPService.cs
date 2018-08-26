using System;
using System.IO;
using System.Net;
using System.ServiceProcess;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Newtonsoft.Json;

namespace IP_Sender
{
    partial class IPService : ServiceBase
    {
        private static string LogPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + DateTime.Now.ToString().Replace('/','_').Replace(':','_') + ".log";
        private string PCName;
        private string Token;
        private string Password;
        private bool LogFails;
        private bool LogSends;
        private TelegramBotClient Bot;
        public IPService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //At First Open log
            if (!File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\config.json"))
            {
                WriteLog("Cannot start bot! Config file does not exist!", "ERROR");
                Stop();
                return;
            }
            Config config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(Path.GetDirectoryName(Application.ExecutablePath)+"\\config.json"));
            PCName = config.PCName;
            Token = config.Token;
            Password = config.Password;
            //Check if they are empty
            if (PCName.Empty() || Token.Empty() || Password.Empty())
            {
                WriteLog("Cannot start bot! Make sure PCName, Token and Password properties are not empty." +
                    $" PCName: {PCName} , Token: {Token} , Password: {Password}", "ERROR");
                Stop();
                return;
            }
            LogFails = config.LogFails;
            LogSends = config.LogSends;
            //Now setup bot
            if (config.DirectIP)
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            if(config.proxy.IP.Empty() || config.proxy.Port == 0)
                Bot = new TelegramBotClient(Token, config.DirectIP);
            else if(config.proxy.Password.Empty() || config.proxy.User.Empty())
                Bot = new TelegramBotClient(Token, config.DirectIP,new WebProxy(config.proxy.IP + ':' + config.proxy.Port));
            else
            {
                ICredentials credentials = new NetworkCredential(config.proxy.User, config.proxy.Password);
                WebProxy proxy = new WebProxy(config.proxy.IP + ':' + config.proxy.Port, true, null, credentials);
                Bot = new TelegramBotClient(Token, config.DirectIP, proxy);
            }
            var me = Bot.GetMeAsync().Result;
            Bot.OnMessage += BotOnMessageReceived;
            Bot.StartReceiving(new UpdateType[0]);
            WriteLog($"Starting @{me.Id} bot.", "INFO");
        }

        protected override void OnStop()
        {
            try
            {
                Bot.StopReceiving();
            }
            catch (Exception) { }
            WriteLog($"Stopped bot.", "INFO");
        }
        private static void WriteLog(string ToWrite,string Type)
        {
            StreamWriter sw = File.AppendText(LogPath);
            sw.WriteLine($"{DateTime.Now} [{Type}]: {ToWrite}");
            sw.Close();
        }
        private async void BotOnMessageReceived(object sender, MessageEventArgs e)
        {
            Telegram.Bot.Types.Message message = e.Message;
            if (message == null || message.Type != MessageType.Text) return;
            string[] msg = message.Text.Split(' ');
            if (msg.Length != 2) return;
            string ToSend = "null";
            if (msg[0] == PCName && Helper.SHA256(msg[1]) == Password)
            {
                await Bot.SendTextMessageAsync(message.Chat.Id, "Receiving IP...");
                try
                {
                    WebRequest request = WebRequest.Create("http://api.ipify.org/");
                    //We bypass any proxy if it's configured in system
                    request.Proxy = null;
                    WebResponse response = request.GetResponse();
                    Stream data = response.GetResponseStream();
                    using (StreamReader sr = new StreamReader(data))
                    {
                        ToSend = sr.ReadToEnd();
                    }
                    if (LogSends)
                    {
                        WriteLog($"[{DateTime.Now}]: Send IP for @{message.From.Username}, UserID:{message.From.Id}, Name: {message.From.FirstName} {message.From.LastName}","LOGIN");
                    }
                }
                catch (Exception ex)
                {
                    ToSend = ex.ToString();
                    WriteLog($"Cannot get IP: {ToSend}", "ERROR");
                }
                await Bot.SendTextMessageAsync(message.Chat.Id, ToSend);
            }
            else if (LogFails)
            {
                WriteLog($"Failed login attempt from @{message.From.Username}, UserID:{message.From.Id}, Name: {message.From.FirstName} {message.From.LastName}, Entered password: {msg[1]}  for {msg[0]} computer.", "LOGIN_FAIL");
            }
        }
    }
}
