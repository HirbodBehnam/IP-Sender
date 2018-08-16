namespace IP_Sender
{
    partial class PasswordHasher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordHasher));
            this.label1 = new System.Windows.Forms.Label();
            this.TXTPass = new System.Windows.Forms.TextBox();
            this.LBLHash = new System.Windows.Forms.Label();
            this.BTNCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            // 
            // TXTPass
            // 
            this.TXTPass.Location = new System.Drawing.Point(12, 30);
            this.TXTPass.Name = "TXTPass";
            this.TXTPass.Size = new System.Drawing.Size(414, 20);
            this.TXTPass.TabIndex = 1;
            this.TXTPass.TextChanged += new System.EventHandler(this.passTXT_TextChanged);
            // 
            // LBLHash
            // 
            this.LBLHash.AutoSize = true;
            this.LBLHash.Location = new System.Drawing.Point(12, 57);
            this.LBLHash.Name = "LBLHash";
            this.LBLHash.Size = new System.Drawing.Size(0, 13);
            this.LBLHash.TabIndex = 2;
            // 
            // BTNCopy
            // 
            this.BTNCopy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTNCopy.Location = new System.Drawing.Point(182, 81);
            this.BTNCopy.Name = "BTNCopy";
            this.BTNCopy.Size = new System.Drawing.Size(75, 23);
            this.BTNCopy.TabIndex = 3;
            this.BTNCopy.Text = "Copy";
            this.BTNCopy.UseVisualStyleBackColor = true;
            this.BTNCopy.Click += new System.EventHandler(this.CpyBTN_Click);
            // 
            // PasswordHasher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 116);
            this.Controls.Add(this.BTNCopy);
            this.Controls.Add(this.LBLHash);
            this.Controls.Add(this.TXTPass);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordHasher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PasswordHasher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTPass;
        private System.Windows.Forms.Label LBLHash;
        private System.Windows.Forms.Button BTNCopy;
    }
}