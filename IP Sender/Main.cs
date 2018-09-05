using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;

namespace IP_Sender
{
    //Icon:https://findicons.com/icon/497920/ip_right
    public partial class Main : Form
    {
        private TelegramBotClient Bot;
        private string Password;
        private string PCName;
        private bool LogSends;
        private bool LogFails;
        public Main()
        {
            InitializeComponent();
            Properties.Settings settings = Properties.Settings.Default;
            TXTToken.Text = settings.Token;
            TXTPCName.Text = settings.PCName;
            TXTHashedPassword.Text = settings.Password;
            TXTProxyIP.Text = settings.ProxyIP;
            TXTProxyPort.Text = settings.ProxyPort;
            TXTProxyUsername.Text = settings.ProxyUser;
            TXTProxyPassword.Text = settings.ProxyPass;
            useDirectIPToolStripMenuItem.Checked = settings.DirectIP;
            logSentIPsToolStripMenuItem.Checked = settings.LogSends;
            logLoginFailuresToolStripMenuItem1.Checked = settings.LogLoginFailures;
        }

        private void passwordHasherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PasswordHasher().ShowDialog();
        }

        private void BTNMinimize_Click(object sender, EventArgs e)
        {
            TrayIcon.Visible = true;
            Hide();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void MenuShow_Click(object sender, EventArgs e)
        {
            Show();
            TrayIcon.Visible = false;
        }
        private void useDirectIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DirectIP = useDirectIPToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
        }
        private void logLoginFailuresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LogLoginFailures = LogFails = logLoginFailuresToolStripMenuItem1.Checked;
            Properties.Settings.Default.Save();
        }
        private void logSentIPsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LogSends = LogSends = logSentIPsToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
        }
        private void BTNStartBot_Click(object sender, EventArgs e)
        {
            //Validate inputs
            if (TXTToken.Empty() || TXTPCName.Empty() || TXTHashedPassword.Empty())
            {
                MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                return;
            }
            //At first save the settings
            Properties.Settings.Default.Token = TXTToken.Text;
            Properties.Settings.Default.PCName = PCName = TXTPCName.Text;
            Properties.Settings.Default.Password = Password = TXTHashedPassword.Text.ToLower();
            Properties.Settings.Default.ProxyIP = TXTProxyIP.Text;
            Properties.Settings.Default.ProxyUser = TXTProxyUsername.Text;
            Properties.Settings.Default.ProxyPass = TXTProxyPassword.Text;
            Properties.Settings.Default.Save();
            if (!TXTProxyPort.Empty()) {
                try
                {
                    Properties.Settings.Default.ProxyPort = TXTProxyPort.Text;
                    Properties.Settings.Default.Save();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error parsing your proxy port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            SaveToJson();
            //If we use direct IP, SSL handshake will fail and program will throw an exception. This line will bypass SSL check.           
            if (useDirectIPToolStripMenuItem.Checked)
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            //Check proxy
            if (TXTProxyIP.Empty() && TXTProxyPort.Empty())
                Bot = new TelegramBotClient(TXTToken.Text, useDirectIPToolStripMenuItem.Checked);
            else if(TXTProxyUsername.Empty() && TXTProxyPassword.Empty())
                    Bot = new TelegramBotClient(TXTToken.Text, useDirectIPToolStripMenuItem.Checked, new WebProxy(TXTProxyIP.Text, Convert.ToInt32(TXTProxyPort.Text)));
            else
            {
                ICredentials credentials = new NetworkCredential(TXTProxyUsername.Text, TXTProxyPassword.Text);
                WebProxy proxy = new WebProxy(TXTProxyIP.Text + ":"+ TXTProxyPort.Text, true, null, credentials);
                Bot = new TelegramBotClient(TXTToken.Text, useDirectIPToolStripMenuItem.Checked, proxy);
            }
            BTNStartBot.Enabled = false;
            BTNStopBot.Enabled = true;
            MenuStartBot.Enabled = false;
            MenuStopBot.Enabled = true;
            var me = Bot.GetMeAsync().Result;
            Bot.OnMessage += BotOnMessageReceived;
            Bot.StartReceiving(new UpdateType[0]);
            TXTLog.AppendText($"[{DateTime.Now}]: Starting @{me.Id} bot.\n");
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
                    System.IO.Stream data = response.GetResponseStream();
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(data))
                    {
                        ToSend = sr.ReadToEnd();
                    }
                    if (LogSends)
                    {
                        TXTLog.Invoke(new Action(() => TXTLog.AppendText($"[{DateTime.Now}]: Send IP for @{message.From.Username}, UserID:{message.From.Id}, Name: {message.From.FirstName} {message.From.LastName}\n")));
                    }
                }
                catch (Exception ex)
                {
                    ToSend = ex.ToString();
                    TXTLog.Invoke(new Action(() => TXTLog.AppendText($"[{DateTime.Now}]: Error Getting IP: {ToSend}\n",Color.Red)));
                }
                await Bot.SendTextMessageAsync(message.Chat.Id, ToSend);
            }else if (msg[0] == PCName && LogFails)
            {
                TXTLog.Invoke(new Action(() => TXTLog.AppendText($"[{DateTime.Now}]: Failed login attempt from @{message.From.Username}, UserID:{message.From.Id}, Name: {message.From.FirstName} {message.From.LastName}, Entered password: {msg[1]}  for {msg[0]} computer.\n", Color.Red)));
            }
        }
        private void BTNStopBot_Click(object sender, EventArgs e)
        {
            BTNStartBot.Enabled = true;
            BTNStopBot.Enabled = false;
            MenuStartBot.Enabled = true;
            MenuStopBot.Enabled = false;
            Bot.StopReceiving();
            TXTLog.AppendText($"[{DateTime.Now}]: Stopped bot.\n");
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("At first create a bot at @BotFather. Get the token, and enter it here.\nGo to \"Settings->Password Hasher\" and enter a password. Copy the hashed password and enter it in \"Hashed Password\" textbox.\nChoose your PC name and click start Bot."
                ,"Help",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void sourceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/HirbodBehnam/IP-Sender");
        }

        private void createServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Helper.ServiceExists("IP Sender Bot"))
            {
                MessageBox.Show("Service exists","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (!Helper.IsAdministrator())
            {
                MessageBox.Show("Please run application as admin and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Process.Start("sc", $"create \"IP Sender Bot\" binPath= \"{Application.ExecutablePath} -s\" start= auto")
                    .WaitForExit();
                Process.Start("sc", "description \"IP Sender Bot\" \"The service that sends your public IP via bot when requested.\"");
            }
        }

        private void disableServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Helper.IsAdministrator())
            {
                MessageBox.Show("Please run application as admin and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Process.Start("sc", $"stop \"IP Sender Bot\"")
                        .WaitForExit();
                Process.Start("sc", $"delete \"IP Sender Bot\"");
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Bot.StopReceiving();
            }
            catch (Exception) { }
        }
        private static void SaveToJson()
        {
            Properties.Settings.Default.Reload();
            Config config = new Config
            {
                DirectIP = Properties.Settings.Default.DirectIP,
                Token = Properties.Settings.Default.Token,
                PCName = Properties.Settings.Default.PCName,
                Password = Properties.Settings.Default.Password,
                LogFails = Properties.Settings.Default.LogLoginFailures,
                LogSends = Properties.Settings.Default.LogSends
            };
            if (!Properties.Settings.Default.ProxyIP.Empty() && !Properties.Settings.Default.ProxyPort.Empty())
            {
                config.proxy = new Config.Proxy()
                {
                    IP = Properties.Settings.Default.ProxyIP,
                    Port = Convert.ToInt32(Properties.Settings.Default.ProxyPort),
                    Password = Properties.Settings.Default.ProxyPass,
                    User = Properties.Settings.Default.ProxyUser
                };
            }
            System.IO.File.WriteAllText("config.json" ,JsonConvert.SerializeObject(config));
        }
    }
}
