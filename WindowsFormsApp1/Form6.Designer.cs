namespace WindowsFormsApp1
{
    partial class Form6
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
            this.btnIstekYolla = new System.Windows.Forms.Button();
            this.txtKullaniciIsmi = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridGelenler = new System.Windows.Forms.DataGridView();
            this.exGonderenKullaniciAdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exAliciKullaniciAdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıstekZamaniDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonIslemZamaniDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripGelen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemGelenDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ısteklerDtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridGonderdiklerim = new System.Windows.Forms.DataGridView();
            this.exGonderenKullaniciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exAliciKullaniciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıstekZamaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonIslemZamaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripGiden = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ısteklerDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGelenler)).BeginInit();
            this.contextMenuStripGelen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ısteklerDtoBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGonderdiklerim)).BeginInit();
            this.contextMenuStripGiden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ısteklerDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIstekYolla
            // 
            this.btnIstekYolla.BackColor = System.Drawing.Color.PeachPuff;
            this.btnIstekYolla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIstekYolla.Location = new System.Drawing.Point(342, 12);
            this.btnIstekYolla.Name = "btnIstekYolla";
            this.btnIstekYolla.Size = new System.Drawing.Size(132, 41);
            this.btnIstekYolla.TabIndex = 10;
            this.btnIstekYolla.Text = "istek yolla";
            this.btnIstekYolla.UseVisualStyleBackColor = false;
            this.btnIstekYolla.Click += new System.EventHandler(this.btnIstekYolla_Click);
            // 
            // txtKullaniciIsmi
            // 
            this.txtKullaniciIsmi.Location = new System.Drawing.Point(126, 12);
            this.txtKullaniciIsmi.Multiline = true;
            this.txtKullaniciIsmi.Name = "txtKullaniciIsmi";
            this.txtKullaniciIsmi.Size = new System.Drawing.Size(197, 34);
            this.txtKullaniciIsmi.TabIndex = 11;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1134, 527);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // dataGridGelenler
            // 
            this.dataGridGelenler.AutoGenerateColumns = false;
            this.dataGridGelenler.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridGelenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGelenler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exGonderenKullaniciAdDataGridViewTextBoxColumn1,
            this.exAliciKullaniciAdDataGridViewTextBoxColumn1,
            this.ıstekZamaniDataGridViewTextBoxColumn1,
            this.sonIslemZamaniDataGridViewTextBoxColumn1,
            this.durumuDataGridViewTextBoxColumn1});
            this.dataGridGelenler.ContextMenuStrip = this.contextMenuStripGelen;
            this.dataGridGelenler.DataSource = this.ısteklerDtoBindingSource1;
            this.dataGridGelenler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridGelenler.Location = new System.Drawing.Point(0, 16);
            this.dataGridGelenler.Name = "dataGridGelenler";
            this.dataGridGelenler.RowHeadersWidth = 51;
            this.dataGridGelenler.RowTemplate.Height = 24;
            this.dataGridGelenler.Size = new System.Drawing.Size(1134, 191);
            this.dataGridGelenler.TabIndex = 28;
            this.dataGridGelenler.DoubleClick += new System.EventHandler(this.dataGridGelenler_DoubleClick);
            // 
            // exGonderenKullaniciAdDataGridViewTextBoxColumn1
            // 
            this.exGonderenKullaniciAdDataGridViewTextBoxColumn1.DataPropertyName = "ex_GonderenKullaniciAd";
            this.exGonderenKullaniciAdDataGridViewTextBoxColumn1.HeaderText = "Gönderen Kullanıcı Ad";
            this.exGonderenKullaniciAdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.exGonderenKullaniciAdDataGridViewTextBoxColumn1.Name = "exGonderenKullaniciAdDataGridViewTextBoxColumn1";
            this.exGonderenKullaniciAdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // exAliciKullaniciAdDataGridViewTextBoxColumn1
            // 
            this.exAliciKullaniciAdDataGridViewTextBoxColumn1.DataPropertyName = "ex_AliciKullaniciAd";
            this.exAliciKullaniciAdDataGridViewTextBoxColumn1.HeaderText = "ex_AliciKullaniciAd";
            this.exAliciKullaniciAdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.exAliciKullaniciAdDataGridViewTextBoxColumn1.Name = "exAliciKullaniciAdDataGridViewTextBoxColumn1";
            this.exAliciKullaniciAdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // ıstekZamaniDataGridViewTextBoxColumn1
            // 
            this.ıstekZamaniDataGridViewTextBoxColumn1.DataPropertyName = "IstekZamani";
            this.ıstekZamaniDataGridViewTextBoxColumn1.HeaderText = "IstekZamani";
            this.ıstekZamaniDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ıstekZamaniDataGridViewTextBoxColumn1.Name = "ıstekZamaniDataGridViewTextBoxColumn1";
            this.ıstekZamaniDataGridViewTextBoxColumn1.Width = 125;
            // 
            // sonIslemZamaniDataGridViewTextBoxColumn1
            // 
            this.sonIslemZamaniDataGridViewTextBoxColumn1.DataPropertyName = "SonIslemZamani";
            this.sonIslemZamaniDataGridViewTextBoxColumn1.HeaderText = "SonIslemZamani";
            this.sonIslemZamaniDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sonIslemZamaniDataGridViewTextBoxColumn1.Name = "sonIslemZamaniDataGridViewTextBoxColumn1";
            this.sonIslemZamaniDataGridViewTextBoxColumn1.Width = 125;
            // 
            // durumuDataGridViewTextBoxColumn1
            // 
            this.durumuDataGridViewTextBoxColumn1.DataPropertyName = "Durumu";
            this.durumuDataGridViewTextBoxColumn1.HeaderText = "Durumu";
            this.durumuDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.durumuDataGridViewTextBoxColumn1.Name = "durumuDataGridViewTextBoxColumn1";
            this.durumuDataGridViewTextBoxColumn1.Width = 125;
            // 
            // contextMenuStripGelen
            // 
            this.contextMenuStripGelen.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripGelen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemGelenDelete});
            this.contextMenuStripGelen.Name = "contextMenuStripGelen";
            this.contextMenuStripGelen.Size = new System.Drawing.Size(135, 28);
            // 
            // toolStripMenuItemGelenDelete
            // 
            this.toolStripMenuItemGelenDelete.Name = "toolStripMenuItemGelenDelete";
            this.toolStripMenuItemGelenDelete.Size = new System.Drawing.Size(134, 24);
            this.toolStripMenuItemGelenDelete.Text = "İsteği Sil";
            this.toolStripMenuItemGelenDelete.Click += new System.EventHandler(this.toolStripMenuItemGelenDelete_Click);
            // 
            // ısteklerDtoBindingSource1
            // 
            this.ısteklerDtoBindingSource1.DataSource = typeof(WindowsFormsApp1.Statics.IsteklerDto);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "İstek Gönder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Gelen İstekler";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.dataGridGelenler);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 207);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.dataGridGonderdiklerim);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 190);
            this.panel2.TabIndex = 32;
            // 
            // dataGridGonderdiklerim
            // 
            this.dataGridGonderdiklerim.AutoGenerateColumns = false;
            this.dataGridGonderdiklerim.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridGonderdiklerim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGonderdiklerim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exGonderenKullaniciAdDataGridViewTextBoxColumn,
            this.exAliciKullaniciAdDataGridViewTextBoxColumn,
            this.ıstekZamaniDataGridViewTextBoxColumn,
            this.sonIslemZamaniDataGridViewTextBoxColumn,
            this.durumuDataGridViewTextBoxColumn});
            this.dataGridGonderdiklerim.ContextMenuStrip = this.contextMenuStripGiden;
            this.dataGridGonderdiklerim.DataSource = this.ısteklerDtoBindingSource;
            this.dataGridGonderdiklerim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridGonderdiklerim.Location = new System.Drawing.Point(0, 16);
            this.dataGridGonderdiklerim.Name = "dataGridGonderdiklerim";
            this.dataGridGonderdiklerim.RowHeadersWidth = 51;
            this.dataGridGonderdiklerim.RowTemplate.Height = 24;
            this.dataGridGonderdiklerim.Size = new System.Drawing.Size(1134, 174);
            this.dataGridGonderdiklerim.TabIndex = 28;
            // 
            // exGonderenKullaniciAdDataGridViewTextBoxColumn
            // 
            this.exGonderenKullaniciAdDataGridViewTextBoxColumn.DataPropertyName = "ex_GonderenKullaniciAd";
            this.exGonderenKullaniciAdDataGridViewTextBoxColumn.HeaderText = "ex_GonderenKullaniciAd";
            this.exGonderenKullaniciAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.exGonderenKullaniciAdDataGridViewTextBoxColumn.Name = "exGonderenKullaniciAdDataGridViewTextBoxColumn";
            this.exGonderenKullaniciAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // exAliciKullaniciAdDataGridViewTextBoxColumn
            // 
            this.exAliciKullaniciAdDataGridViewTextBoxColumn.DataPropertyName = "ex_AliciKullaniciAd";
            this.exAliciKullaniciAdDataGridViewTextBoxColumn.HeaderText = "ex_AliciKullaniciAd";
            this.exAliciKullaniciAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.exAliciKullaniciAdDataGridViewTextBoxColumn.Name = "exAliciKullaniciAdDataGridViewTextBoxColumn";
            this.exAliciKullaniciAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıstekZamaniDataGridViewTextBoxColumn
            // 
            this.ıstekZamaniDataGridViewTextBoxColumn.DataPropertyName = "IstekZamani";
            this.ıstekZamaniDataGridViewTextBoxColumn.HeaderText = "IstekZamani";
            this.ıstekZamaniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıstekZamaniDataGridViewTextBoxColumn.Name = "ıstekZamaniDataGridViewTextBoxColumn";
            this.ıstekZamaniDataGridViewTextBoxColumn.Width = 125;
            // 
            // sonIslemZamaniDataGridViewTextBoxColumn
            // 
            this.sonIslemZamaniDataGridViewTextBoxColumn.DataPropertyName = "SonIslemZamani";
            this.sonIslemZamaniDataGridViewTextBoxColumn.HeaderText = "SonIslemZamani";
            this.sonIslemZamaniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sonIslemZamaniDataGridViewTextBoxColumn.Name = "sonIslemZamaniDataGridViewTextBoxColumn";
            this.sonIslemZamaniDataGridViewTextBoxColumn.Width = 125;
            // 
            // durumuDataGridViewTextBoxColumn
            // 
            this.durumuDataGridViewTextBoxColumn.DataPropertyName = "Durumu";
            this.durumuDataGridViewTextBoxColumn.HeaderText = "Durumu";
            this.durumuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durumuDataGridViewTextBoxColumn.Name = "durumuDataGridViewTextBoxColumn";
            this.durumuDataGridViewTextBoxColumn.Width = 125;
            // 
            // contextMenuStripGiden
            // 
            this.contextMenuStripGiden.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripGiden.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStripGiden.Name = "contextMenuStripGiden";
            this.contextMenuStripGiden.Size = new System.Drawing.Size(135, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 24);
            this.toolStripMenuItem1.Text = "İsteği Sil";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ısteklerDtoBindingSource
            // 
            this.ısteklerDtoBindingSource.DataSource = typeof(WindowsFormsApp1.Statics.IsteklerDto);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Gönderdiğim İstekler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "arkadaş çıkar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(646, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 33);
            this.textBox1.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.Location = new System.Drawing.Point(844, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 32);
            this.button1.TabIndex = 35;
            this.button1.Text = "çıkar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIstekYolla);
            this.Controls.Add(this.txtKullaniciIsmi);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form6";
            this.Text = "GRUPLARIM";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGelenler)).EndInit();
            this.contextMenuStripGelen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ısteklerDtoBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGonderdiklerim)).EndInit();
            this.contextMenuStripGiden.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ısteklerDtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIstekYolla;
        private System.Windows.Forms.TextBox txtKullaniciIsmi;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridGelenler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridGonderdiklerim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource ısteklerDtoBindingSource;
        private System.Windows.Forms.BindingSource ısteklerDtoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn exGonderenKullaniciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exAliciKullaniciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıstekZamaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonIslemZamaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGelen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGelenDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn exGonderenKullaniciAdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn exAliciKullaniciAdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıstekZamaniDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonIslemZamaniDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGiden;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}