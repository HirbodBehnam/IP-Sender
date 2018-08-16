namespace IP_Sender
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logLoginFailuresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logSentIPsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useDirectIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.passwordHasherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTPCName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTHashedPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXTProxyPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTProxyUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTProxyPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTProxyIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNStartBot = new System.Windows.Forms.Button();
            this.BTNStopBot = new System.Windows.Forms.Button();
            this.BTNMinimize = new System.Windows.Forms.Button();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayIconMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuStopBot = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStartBot = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TXTLog = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TrayIconMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(490, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logLoginFailuresToolStripMenuItem1,
            this.logSentIPsToolStripMenuItem,
            this.useDirectIPToolStripMenuItem,
            this.toolStripSeparator1,
            this.passwordHasherToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // logLoginFailuresToolStripMenuItem1
            // 
            this.logLoginFailuresToolStripMenuItem1.CheckOnClick = true;
            this.logLoginFailuresToolStripMenuItem1.Name = "logLoginFailuresToolStripMenuItem1";
            this.logLoginFailuresToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.logLoginFailuresToolStripMenuItem1.Text = "Log Login Failures";
            this.logLoginFailuresToolStripMenuItem1.Click += new System.EventHandler(this.logLoginFailuresToolStripMenuItem1_Click);
            // 
            // logSentIPsToolStripMenuItem
            // 
            this.logSentIPsToolStripMenuItem.CheckOnClick = true;
            this.logSentIPsToolStripMenuItem.Name = "logSentIPsToolStripMenuItem";
            this.logSentIPsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.logSentIPsToolStripMenuItem.Text = "Log Sent IPs";
            this.logSentIPsToolStripMenuItem.Click += new System.EventHandler(this.logSentIPsToolStripMenuItem_Click);
            // 
            // useDirectIPToolStripMenuItem
            // 
            this.useDirectIPToolStripMenuItem.CheckOnClick = true;
            this.useDirectIPToolStripMenuItem.Name = "useDirectIPToolStripMenuItem";
            this.useDirectIPToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.useDirectIPToolStripMenuItem.Text = "Use Direct IP";
            this.useDirectIPToolStripMenuItem.Click += new System.EventHandler(this.useDirectIPToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // passwordHasherToolStripMenuItem
            // 
            this.passwordHasherToolStripMenuItem.Name = "passwordHasherToolStripMenuItem";
            this.passwordHasherToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.passwordHasherToolStripMenuItem.Text = "Password Hasher";
            this.passwordHasherToolStripMenuItem.Click += new System.EventHandler(this.passwordHasherToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourceToolStripMenuItem1,
            this.howToUseToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // sourceToolStripMenuItem1
            // 
            this.sourceToolStripMenuItem1.Name = "sourceToolStripMenuItem1";
            this.sourceToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sourceToolStripMenuItem1.Text = "Source";
            this.sourceToolStripMenuItem1.Click += new System.EventHandler(this.sourceToolStripMenuItem1_Click);
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.howToUseToolStripMenuItem.Text = "Help";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Token:";
            // 
            // TXTToken
            // 
            this.TXTToken.Location = new System.Drawing.Point(60, 25);
            this.TXTToken.Name = "TXTToken";
            this.TXTToken.Size = new System.Drawing.Size(418, 20);
            this.TXTToken.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PC Name:";
            // 
            // TXTPCName
            // 
            this.TXTPCName.Location = new System.Drawing.Point(74, 51);
            this.TXTPCName.Name = "TXTPCName";
            this.TXTPCName.Size = new System.Drawing.Size(108, 20);
            this.TXTPCName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hashed Password:";
            // 
            // TXTHashedPassword
            // 
            this.TXTHashedPassword.Location = new System.Drawing.Point(290, 51);
            this.TXTHashedPassword.Name = "TXTHashedPassword";
            this.TXTHashedPassword.Size = new System.Drawing.Size(188, 20);
            this.TXTHashedPassword.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.TXTProxyPort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TXTProxyIP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 165);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HTTP Proxy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXTProxyPassword);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TXTProxyUsername);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(7, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 81);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Authentication";
            // 
            // TXTProxyPassword
            // 
            this.TXTProxyPassword.Location = new System.Drawing.Point(71, 48);
            this.TXTProxyPassword.Name = "TXTProxyPassword";
            this.TXTProxyPassword.Size = new System.Drawing.Size(113, 20);
            this.TXTProxyPassword.TabIndex = 3;
            this.TXTProxyPassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Password:";
            // 
            // TXTProxyUsername
            // 
            this.TXTProxyUsername.Location = new System.Drawing.Point(71, 17);
            this.TXTProxyUsername.Name = "TXTProxyUsername";
            this.TXTProxyUsername.Size = new System.Drawing.Size(113, 20);
            this.TXTProxyUsername.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Username:";
            // 
            // TXTProxyPort
            // 
            this.TXTProxyPort.Location = new System.Drawing.Point(67, 50);
            this.TXTProxyPort.Name = "TXTProxyPort";
            this.TXTProxyPort.Size = new System.Drawing.Size(130, 20);
            this.TXTProxyPort.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Port:";
            // 
            // TXTProxyIP
            // 
            this.TXTProxyIP.Location = new System.Drawing.Point(67, 17);
            this.TXTProxyIP.Name = "TXTProxyIP";
            this.TXTProxyIP.Size = new System.Drawing.Size(130, 20);
            this.TXTProxyIP.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Server IP:";
            // 
            // BTNStartBot
            // 
            this.BTNStartBot.Location = new System.Drawing.Point(197, 252);
            this.BTNStartBot.Name = "BTNStartBot";
            this.BTNStartBot.Size = new System.Drawing.Size(97, 23);
            this.BTNStartBot.TabIndex = 9;
            this.BTNStartBot.Text = "Start Bot";
            this.BTNStartBot.UseVisualStyleBackColor = true;
            this.BTNStartBot.Click += new System.EventHandler(this.BTNStartBot_Click);
            // 
            // BTNStopBot
            // 
            this.BTNStopBot.Enabled = false;
            this.BTNStopBot.Location = new System.Drawing.Point(93, 252);
            this.BTNStopBot.Name = "BTNStopBot";
            this.BTNStopBot.Size = new System.Drawing.Size(98, 23);
            this.BTNStopBot.TabIndex = 9;
            this.BTNStopBot.Text = "Stop Bot";
            this.BTNStopBot.UseVisualStyleBackColor = true;
            this.BTNStopBot.Click += new System.EventHandler(this.BTNStopBot_Click);
            // 
            // BTNMinimize
            // 
            this.BTNMinimize.Location = new System.Drawing.Point(300, 252);
            this.BTNMinimize.Name = "BTNMinimize";
            this.BTNMinimize.Size = new System.Drawing.Size(98, 23);
            this.BTNMinimize.TabIndex = 9;
            this.BTNMinimize.Text = "Minimize To Tray";
            this.BTNMinimize.UseVisualStyleBackColor = true;
            this.BTNMinimize.Click += new System.EventHandler(this.BTNMinimize_Click);
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayIconMenuStrip;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "IP Sender Bot";
            // 
            // TrayIconMenuStrip
            // 
            this.TrayIconMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStopBot,
            this.MenuStartBot,
            this.MenuShow,
            this.MenuExit});
            this.TrayIconMenuStrip.Name = "TrayIconMenuStrip";
            this.TrayIconMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TrayIconMenuStrip.Size = new System.Drawing.Size(135, 92);
            this.TrayIconMenuStrip.DoubleClick += new System.EventHandler(this.MenuShow_Click);
            // 
            // MenuStopBot
            // 
            this.MenuStopBot.Enabled = false;
            this.MenuStopBot.Name = "MenuStopBot";
            this.MenuStopBot.Size = new System.Drawing.Size(134, 22);
            this.MenuStopBot.Text = "Stop Bot";
            this.MenuStopBot.Click += new System.EventHandler(this.BTNStopBot_Click);
            // 
            // MenuStartBot
            // 
            this.MenuStartBot.Name = "MenuStartBot";
            this.MenuStartBot.Size = new System.Drawing.Size(134, 22);
            this.MenuStartBot.Text = "Start Bot";
            this.MenuStartBot.Click += new System.EventHandler(this.BTNStartBot_Click);
            // 
            // MenuShow
            // 
            this.MenuShow.Name = "MenuShow";
            this.MenuShow.Size = new System.Drawing.Size(134, 22);
            this.MenuShow.Text = "Show Form";
            this.MenuShow.Click += new System.EventHandler(this.MenuShow_Click);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(134, 22);
            this.MenuExit.Text = "Exit";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // TXTLog
            // 
            this.TXTLog.Location = new System.Drawing.Point(225, 77);
            this.TXTLog.Name = "TXTLog";
            this.TXTLog.ReadOnly = true;
            this.TXTLog.ShortcutsEnabled = false;
            this.TXTLog.Size = new System.Drawing.Size(253, 161);
            this.TXTLog.TabIndex = 10;
            this.TXTLog.TabStop = false;
            this.TXTLog.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 287);
            this.Controls.Add(this.TXTLog);
            this.Controls.Add(this.BTNMinimize);
            this.Controls.Add(this.BTNStopBot);
            this.Controls.Add(this.BTNStartBot);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TXTHashedPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTPCName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTToken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telegram Bot IP Sender";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TrayIconMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTPCName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTHashedPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXTProxyPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTProxyIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXTProxyPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTProxyUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTNStartBot;
        private System.Windows.Forms.Button BTNStopBot;
        private System.Windows.Forms.Button BTNMinimize;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayIconMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuStopBot;
        private System.Windows.Forms.ToolStripMenuItem MenuStartBot;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem sourceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logLoginFailuresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem useDirectIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem passwordHasherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuShow;
        private System.Windows.Forms.ToolStripMenuItem logSentIPsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox TXTLog;
    }
}

