namespace GPFinal
{
    partial class Form1
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAyarOku = new System.Windows.Forms.Button();
            this.btnVeritabaniOku = new System.Windows.Forms.Button();
            this.btnVeritabaniYaz = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.VeritabaniBaglantiKontrol = new System.Windows.Forms.Button();
            this.btnVeritabaniDosyaKontrol = new System.Windows.Forms.Button();
            this.btnAyarDosyasıKontrol = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCihazTur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCihazIsim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCihazID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbAyarlar = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvVeriler = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeriler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAyarOku);
            this.groupBox4.Controls.Add(this.btnVeritabaniOku);
            this.groupBox4.Controls.Add(this.btnVeritabaniYaz);
            this.groupBox4.Location = new System.Drawing.Point(12, 169);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 140);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kontrol Menüsü";
            // 
            // btnAyarOku
            // 
            this.btnAyarOku.Location = new System.Drawing.Point(5, 31);
            this.btnAyarOku.Name = "btnAyarOku";
            this.btnAyarOku.Size = new System.Drawing.Size(178, 23);
            this.btnAyarOku.TabIndex = 16;
            this.btnAyarOku.Text = "Ayarları Oku";
            this.btnAyarOku.UseVisualStyleBackColor = true;
            this.btnAyarOku.Click += new System.EventHandler(this.btnAyarOku_Click);
            // 
            // btnVeritabaniOku
            // 
            this.btnVeritabaniOku.Location = new System.Drawing.Point(6, 71);
            this.btnVeritabaniOku.Name = "btnVeritabaniOku";
            this.btnVeritabaniOku.Size = new System.Drawing.Size(178, 23);
            this.btnVeritabaniOku.TabIndex = 15;
            this.btnVeritabaniOku.Text = "Veritabanını oku";
            this.btnVeritabaniOku.UseVisualStyleBackColor = true;
            this.btnVeritabaniOku.Click += new System.EventHandler(this.btnVeritabaniOku_Click);
            // 
            // btnVeritabaniYaz
            // 
            this.btnVeritabaniYaz.Location = new System.Drawing.Point(6, 107);
            this.btnVeritabaniYaz.Name = "btnVeritabaniYaz";
            this.btnVeritabaniYaz.Size = new System.Drawing.Size(178, 23);
            this.btnVeritabaniYaz.TabIndex = 14;
            this.btnVeritabaniYaz.Text = "Veritabanına yaz";
            this.btnVeritabaniYaz.UseVisualStyleBackColor = true;
            this.btnVeritabaniYaz.Click += new System.EventHandler(this.btnVeritabaniYaz_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.VeritabaniBaglantiKontrol);
            this.groupBox5.Controls.Add(this.btnVeritabaniDosyaKontrol);
            this.groupBox5.Controls.Add(this.btnAyarDosyasıKontrol);
            this.groupBox5.Location = new System.Drawing.Point(12, 11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(190, 134);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Test Menüsü";
            // 
            // VeritabaniBaglantiKontrol
            // 
            this.VeritabaniBaglantiKontrol.Location = new System.Drawing.Point(6, 105);
            this.VeritabaniBaglantiKontrol.Name = "VeritabaniBaglantiKontrol";
            this.VeritabaniBaglantiKontrol.Size = new System.Drawing.Size(178, 23);
            this.VeritabaniBaglantiKontrol.TabIndex = 13;
            this.VeritabaniBaglantiKontrol.Text = "Veritabanı bağlantısını kontrol et";
            this.VeritabaniBaglantiKontrol.UseVisualStyleBackColor = true;
            this.VeritabaniBaglantiKontrol.Click += new System.EventHandler(this.VeritabaniBaglantiKontrol_Click);
            // 
            // btnVeritabaniDosyaKontrol
            // 
            this.btnVeritabaniDosyaKontrol.Location = new System.Drawing.Point(6, 70);
            this.btnVeritabaniDosyaKontrol.Name = "btnVeritabaniDosyaKontrol";
            this.btnVeritabaniDosyaKontrol.Size = new System.Drawing.Size(178, 23);
            this.btnVeritabaniDosyaKontrol.TabIndex = 12;
            this.btnVeritabaniDosyaKontrol.Text = "Veritabanı dosyasını kontrol et";
            this.btnVeritabaniDosyaKontrol.UseVisualStyleBackColor = true;
            this.btnVeritabaniDosyaKontrol.Click += new System.EventHandler(this.btnVeritabaniDosyaKontrol_Click);
            // 
            // btnAyarDosyasıKontrol
            // 
            this.btnAyarDosyasıKontrol.Location = new System.Drawing.Point(6, 35);
            this.btnAyarDosyasıKontrol.Name = "btnAyarDosyasıKontrol";
            this.btnAyarDosyasıKontrol.Size = new System.Drawing.Size(178, 23);
            this.btnAyarDosyasıKontrol.TabIndex = 11;
            this.btnAyarDosyasıKontrol.Text = "Ayar Dosyasını Kontrol Et";
            this.btnAyarDosyasıKontrol.UseVisualStyleBackColor = true;
            this.btnAyarDosyasıKontrol.Click += new System.EventHandler(this.btnAyarDosyasıKontrol_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCihazTur);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbCihazIsim);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbCihazID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(404, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 140);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cihaz Kayıt Formu";
            // 
            // tbCihazTur
            // 
            this.tbCihazTur.Location = new System.Drawing.Point(6, 114);
            this.tbCihazTur.Name = "tbCihazTur";
            this.tbCihazTur.Size = new System.Drawing.Size(196, 20);
            this.tbCihazTur.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cihaz Türü";
            // 
            // tbCihazIsim
            // 
            this.tbCihazIsim.Location = new System.Drawing.Point(6, 74);
            this.tbCihazIsim.Name = "tbCihazIsim";
            this.tbCihazIsim.Size = new System.Drawing.Size(196, 20);
            this.tbCihazIsim.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cihaz ismi";
            // 
            // tbCihazID
            // 
            this.tbCihazID.Location = new System.Drawing.Point(6, 35);
            this.tbCihazID.Name = "tbCihazID";
            this.tbCihazID.Size = new System.Drawing.Size(196, 20);
            this.tbCihazID.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cihaz ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbAyarlar);
            this.groupBox3.Location = new System.Drawing.Point(208, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 298);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ayarlar";
            // 
            // lbAyarlar
            // 
            this.lbAyarlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAyarlar.FormattingEnabled = true;
            this.lbAyarlar.Location = new System.Drawing.Point(3, 16);
            this.lbAyarlar.Name = "lbAyarlar";
            this.lbAyarlar.Size = new System.Drawing.Size(184, 279);
            this.lbAyarlar.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvVeriler);
            this.groupBox1.Location = new System.Drawing.Point(404, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 140);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veriler";
            // 
            // dgvVeriler
            // 
            this.dgvVeriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVeriler.Location = new System.Drawing.Point(3, 16);
            this.dgvVeriler.Name = "dgvVeriler";
            this.dgvVeriler.Size = new System.Drawing.Size(202, 121);
            this.dgvVeriler.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAyarOku;
        private System.Windows.Forms.Button btnVeritabaniOku;
        private System.Windows.Forms.Button btnVeritabaniYaz;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button VeritabaniBaglantiKontrol;
        private System.Windows.Forms.Button btnVeritabaniDosyaKontrol;
        private System.Windows.Forms.Button btnAyarDosyasıKontrol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCihazTur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCihazIsim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCihazID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbAyarlar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVeriler;
    }
}

