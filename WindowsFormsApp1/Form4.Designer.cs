namespace WindowsFormsApp1
{
    partial class Form4
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
            this.panelGroupsFriends = new System.Windows.Forms.Panel();
            this.groupBoxGroupsFriends = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtfMessages = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.groupBoxGroupsFriends.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGroupsFriends
            // 
            this.panelGroupsFriends.AutoScroll = true;
            this.panelGroupsFriends.BackColor = System.Drawing.Color.Snow;
            this.panelGroupsFriends.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGroupsFriends.Location = new System.Drawing.Point(0, 72);
            this.panelGroupsFriends.Name = "panelGroupsFriends";
            this.panelGroupsFriends.Size = new System.Drawing.Size(333, 407);
            this.panelGroupsFriends.TabIndex = 0;
            // 
            // groupBoxGroupsFriends
            // 
            this.groupBoxGroupsFriends.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.gg;
            this.groupBoxGroupsFriends.Controls.Add(this.button1);
            this.groupBoxGroupsFriends.Controls.Add(this.panelGroupsFriends);
            this.groupBoxGroupsFriends.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxGroupsFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxGroupsFriends.Location = new System.Drawing.Point(0, 0);
            this.groupBoxGroupsFriends.Name = "groupBoxGroupsFriends";
            this.groupBoxGroupsFriends.Size = new System.Drawing.Size(333, 479);
            this.groupBoxGroupsFriends.TabIndex = 1;
            this.groupBoxGroupsFriends.TabStop = false;
            this.groupBoxGroupsFriends.Text = "Gruplar / Arkadaşlar";
            this.groupBoxGroupsFriends.Enter += new System.EventHandler(this.groupBoxGroupsFriends_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(3, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "arkadaş ekle\\ grup oluştur";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtfMessages);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(333, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 479);
            this.panel1.TabIndex = 2;
            // 
            // rtfMessages
            // 
            this.rtfMessages.BackColor = System.Drawing.Color.Thistle;
            this.rtfMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfMessages.Enabled = false;
            this.rtfMessages.Location = new System.Drawing.Point(0, 0);
            this.rtfMessages.Name = "rtfMessages";
            this.rtfMessages.Size = new System.Drawing.Size(577, 421);
            this.rtfMessages.TabIndex = 0;
            this.rtfMessages.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMesaj);
            this.panel2.Controls.Add(this.btnSendMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 421);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 58);
            this.panel2.TabIndex = 1;
            // 
            // txtMesaj
            // 
            this.txtMesaj.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtMesaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMesaj.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMesaj.Location = new System.Drawing.Point(0, 0);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(502, 58);
            this.txtMesaj.TabIndex = 0;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.BackColor = System.Drawing.SystemColors.Info;
            this.btnSendMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSendMessage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSendMessage.Location = new System.Drawing.Point(502, 0);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(75, 58);
            this.btnSendMessage.TabIndex = 2;
            this.btnSendMessage.Text = "Gönder";
            this.btnSendMessage.UseVisualStyleBackColor = false;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 479);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxGroupsFriends);
            this.Name = "Form4";
            this.Text = "Form4";
            this.groupBoxGroupsFriends.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGroupsFriends;
        private System.Windows.Forms.GroupBox groupBoxGroupsFriends;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtfMessages;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Button button1;
    }
}