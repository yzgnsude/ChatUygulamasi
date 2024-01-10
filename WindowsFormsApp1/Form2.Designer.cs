namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(77, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre *";
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(165, 243);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(206, 22);
            this.textBoxKullaniciAdi.TabIndex = 3;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(165, 274);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.PasswordChar = '*';
            this.textBoxSifre.Size = new System.Drawing.Size(206, 22);
            this.textBoxSifre.TabIndex = 4;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.BackColor = System.Drawing.SystemColors.Info;
            this.buttonKaydet.Location = new System.Drawing.Point(83, 341);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(115, 49);
            this.buttonKaydet.TabIndex = 5;
            this.buttonKaydet.Text = "Pişte Katıl";
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Thistle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(108, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Thistle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(79, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Soyad";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(165, 185);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(206, 22);
            this.textBoxAd.TabIndex = 1;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(165, 215);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(206, 22);
            this.textBoxSoyad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(117, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "ÜYE KAYIT GİRİŞİ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(233, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 49);
            this.button2.TabIndex = 6;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.gg;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._777pişt;
            this.pictureBox1.Location = new System.Drawing.Point(121, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 119);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.gg;
            this.ClientSize = new System.Drawing.Size(401, 410);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}