
namespace POS
{
    partial class fBaslangic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBaslangic));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lKullanici = new System.Windows.Forms.Label();
            this.lIsyeri = new System.Windows.Forms.Label();
            this.bCikis = new System.Windows.Forms.Button();
            this.bKullaniciDegistir = new System.Windows.Forms.Button();
            this.bYedekleme = new System.Windows.Forms.Button();
            this.bFiyatGuncelle = new System.Windows.Forms.Button();
            this.bAyarlar = new System.Windows.Forms.Button();
            this.bUrunGiris = new System.Windows.Forms.Button();
            this.bStok = new System.Windows.Forms.Button();
            this.bGenelRapor = new System.Windows.Forms.Button();
            this.bSatisIslemi = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.bCikis, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bKullaniciDegistir, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bYedekleme, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bFiyatGuncelle, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bAyarlar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bUrunGiris, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bStok, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bGenelRapor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bSatisIslemi, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 86);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(712, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lKullanici
            // 
            this.lKullanici.AutoSize = true;
            this.lKullanici.ForeColor = System.Drawing.Color.White;
            this.lKullanici.Location = new System.Drawing.Point(38, 463);
            this.lKullanici.Name = "lKullanici";
            this.lKullanici.Size = new System.Drawing.Size(66, 20);
            this.lKullanici.TabIndex = 1;
            this.lKullanici.Text = "Kullanıcı";
            // 
            // lIsyeri
            // 
            this.lIsyeri.AutoSize = true;
            this.lIsyeri.BackColor = System.Drawing.Color.Black;
            this.lIsyeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lIsyeri.ForeColor = System.Drawing.Color.White;
            this.lIsyeri.Location = new System.Drawing.Point(35, 30);
            this.lIsyeri.Name = "lIsyeri";
            this.lIsyeri.Size = new System.Drawing.Size(150, 40);
            this.lIsyeri.TabIndex = 2;
            this.lIsyeri.Text = "ARPALI";
            // 
            // bCikis
            // 
            this.bCikis.BackColor = System.Drawing.Color.Tomato;
            this.bCikis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bCikis.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.bCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bCikis.ForeColor = System.Drawing.Color.White;
            this.bCikis.Image = ((System.Drawing.Image)(resources.GetObject("bCikis.Image")));
            this.bCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCikis.Location = new System.Drawing.Point(477, 247);
            this.bCikis.Name = "bCikis";
            this.bCikis.Size = new System.Drawing.Size(232, 116);
            this.bCikis.TabIndex = 8;
            this.bCikis.Text = "Çıkış";
            this.bCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bCikis.UseVisualStyleBackColor = false;
            this.bCikis.Click += new System.EventHandler(this.bCikis_Click);
            // 
            // bKullaniciDegistir
            // 
            this.bKullaniciDegistir.BackColor = System.Drawing.Color.DimGray;
            this.bKullaniciDegistir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bKullaniciDegistir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bKullaniciDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bKullaniciDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bKullaniciDegistir.ForeColor = System.Drawing.Color.White;
            this.bKullaniciDegistir.Image = ((System.Drawing.Image)(resources.GetObject("bKullaniciDegistir.Image")));
            this.bKullaniciDegistir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bKullaniciDegistir.Location = new System.Drawing.Point(240, 247);
            this.bKullaniciDegistir.Name = "bKullaniciDegistir";
            this.bKullaniciDegistir.Size = new System.Drawing.Size(231, 116);
            this.bKullaniciDegistir.TabIndex = 7;
            this.bKullaniciDegistir.Text = "Kullanıcı Değiştir";
            this.bKullaniciDegistir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bKullaniciDegistir.UseVisualStyleBackColor = false;
            this.bKullaniciDegistir.Click += new System.EventHandler(this.bKullaniciDegistir_Click);
            // 
            // bYedekleme
            // 
            this.bYedekleme.BackColor = System.Drawing.Color.SlateGray;
            this.bYedekleme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bYedekleme.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.bYedekleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bYedekleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bYedekleme.ForeColor = System.Drawing.Color.White;
            this.bYedekleme.Image = ((System.Drawing.Image)(resources.GetObject("bYedekleme.Image")));
            this.bYedekleme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bYedekleme.Location = new System.Drawing.Point(3, 247);
            this.bYedekleme.Name = "bYedekleme";
            this.bYedekleme.Size = new System.Drawing.Size(231, 116);
            this.bYedekleme.TabIndex = 6;
            this.bYedekleme.Text = "Yedekleme";
            this.bYedekleme.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bYedekleme.UseVisualStyleBackColor = false;
            this.bYedekleme.Click += new System.EventHandler(this.bYedekleme_Click);
            // 
            // bFiyatGuncelle
            // 
            this.bFiyatGuncelle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bFiyatGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bFiyatGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bFiyatGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFiyatGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bFiyatGuncelle.ForeColor = System.Drawing.Color.White;
            this.bFiyatGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("bFiyatGuncelle.Image")));
            this.bFiyatGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bFiyatGuncelle.Location = new System.Drawing.Point(477, 125);
            this.bFiyatGuncelle.Name = "bFiyatGuncelle";
            this.bFiyatGuncelle.Size = new System.Drawing.Size(232, 116);
            this.bFiyatGuncelle.TabIndex = 5;
            this.bFiyatGuncelle.Text = "Fiyat Güncelle";
            this.bFiyatGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bFiyatGuncelle.UseVisualStyleBackColor = false;
            this.bFiyatGuncelle.Click += new System.EventHandler(this.bFiyatGuncelle_Click);
            // 
            // bAyarlar
            // 
            this.bAyarlar.BackColor = System.Drawing.Color.Sienna;
            this.bAyarlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAyarlar.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.bAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAyarlar.ForeColor = System.Drawing.Color.White;
            this.bAyarlar.Image = ((System.Drawing.Image)(resources.GetObject("bAyarlar.Image")));
            this.bAyarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAyarlar.Location = new System.Drawing.Point(240, 125);
            this.bAyarlar.Name = "bAyarlar";
            this.bAyarlar.Size = new System.Drawing.Size(231, 116);
            this.bAyarlar.TabIndex = 4;
            this.bAyarlar.Text = "Ayarlar";
            this.bAyarlar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bAyarlar.UseVisualStyleBackColor = false;
            this.bAyarlar.Click += new System.EventHandler(this.bAyarlar_Click);
            // 
            // bUrunGiris
            // 
            this.bUrunGiris.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.bUrunGiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bUrunGiris.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.bUrunGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUrunGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bUrunGiris.ForeColor = System.Drawing.Color.White;
            this.bUrunGiris.Image = ((System.Drawing.Image)(resources.GetObject("bUrunGiris.Image")));
            this.bUrunGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bUrunGiris.Location = new System.Drawing.Point(3, 125);
            this.bUrunGiris.Name = "bUrunGiris";
            this.bUrunGiris.Size = new System.Drawing.Size(231, 116);
            this.bUrunGiris.TabIndex = 3;
            this.bUrunGiris.Text = "Ürün Giriş";
            this.bUrunGiris.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bUrunGiris.UseVisualStyleBackColor = false;
            this.bUrunGiris.Click += new System.EventHandler(this.bUrunGiris_Click);
            // 
            // bStok
            // 
            this.bStok.BackColor = System.Drawing.Color.DarkCyan;
            this.bStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bStok.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.bStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bStok.ForeColor = System.Drawing.Color.White;
            this.bStok.Image = ((System.Drawing.Image)(resources.GetObject("bStok.Image")));
            this.bStok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bStok.Location = new System.Drawing.Point(477, 3);
            this.bStok.Name = "bStok";
            this.bStok.Size = new System.Drawing.Size(232, 116);
            this.bStok.TabIndex = 2;
            this.bStok.Text = "Stok Takibi";
            this.bStok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bStok.UseVisualStyleBackColor = false;
            this.bStok.Click += new System.EventHandler(this.bStok_Click);
            // 
            // bGenelRapor
            // 
            this.bGenelRapor.BackColor = System.Drawing.Color.ForestGreen;
            this.bGenelRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bGenelRapor.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.bGenelRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGenelRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bGenelRapor.ForeColor = System.Drawing.Color.White;
            this.bGenelRapor.Image = ((System.Drawing.Image)(resources.GetObject("bGenelRapor.Image")));
            this.bGenelRapor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bGenelRapor.Location = new System.Drawing.Point(240, 3);
            this.bGenelRapor.Name = "bGenelRapor";
            this.bGenelRapor.Size = new System.Drawing.Size(231, 116);
            this.bGenelRapor.TabIndex = 1;
            this.bGenelRapor.Text = "Genel Rapor";
            this.bGenelRapor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bGenelRapor.UseVisualStyleBackColor = false;
            this.bGenelRapor.Click += new System.EventHandler(this.bGenelRapor_Click);
            // 
            // bSatisIslemi
            // 
            this.bSatisIslemi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bSatisIslemi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bSatisIslemi.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.bSatisIslemi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSatisIslemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSatisIslemi.ForeColor = System.Drawing.Color.White;
            this.bSatisIslemi.Image = ((System.Drawing.Image)(resources.GetObject("bSatisIslemi.Image")));
            this.bSatisIslemi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSatisIslemi.Location = new System.Drawing.Point(3, 3);
            this.bSatisIslemi.Name = "bSatisIslemi";
            this.bSatisIslemi.Size = new System.Drawing.Size(231, 116);
            this.bSatisIslemi.TabIndex = 0;
            this.bSatisIslemi.Text = "Satış İşlemi";
            this.bSatisIslemi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bSatisIslemi.UseVisualStyleBackColor = false;
            this.bSatisIslemi.Click += new System.EventHandler(this.bSatisIslemi_Click);
            // 
            // fBaslangic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.lIsyeri);
            this.Controls.Add(this.lKullanici);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fBaslangic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arpalı Satış Programı";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bCikis;
        private System.Windows.Forms.Button bKullaniciDegistir;
        public System.Windows.Forms.Button bSatisIslemi;
        public System.Windows.Forms.Button bGenelRapor;
        public System.Windows.Forms.Button bYedekleme;
        public System.Windows.Forms.Button bFiyatGuncelle;
        public System.Windows.Forms.Button bAyarlar;
        public System.Windows.Forms.Button bUrunGiris;
        public System.Windows.Forms.Button bStok;
        public System.Windows.Forms.Label lKullanici;
        public System.Windows.Forms.Label lIsyeri;
    }
}