namespace ŞİRKETOTOMASYONU
{
    partial class AYARLAR
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            grpVeritabani = new GroupBox();
            lblDurum = new Label();
            btnBaglantiTest = new Button();
            lblBaglantiBaslik = new Label();
            lblBaglanti = new Label();
            lblVeritabaniBaslik = new Label();
            lblVeritabani = new Label();
            lblSunucuBaslik = new Label();
            lblSunucu = new Label();
            grpSistem = new GroupBox();
            btnTabloBilgi = new Button();
            lblSistemBilgi = new Label();
            btnKapat = new Button();
            lblBaslik = new Label();
            grpVeritabani.SuspendLayout();
            grpSistem.SuspendLayout();
            SuspendLayout();
            // 
            // grpVeritabani
            // 
            grpVeritabani.Controls.Add(lblDurum);
            grpVeritabani.Controls.Add(btnBaglantiTest);
            grpVeritabani.Controls.Add(lblBaglantiBaslik);
            grpVeritabani.Controls.Add(lblBaglanti);
            grpVeritabani.Controls.Add(lblVeritabaniBaslik);
            grpVeritabani.Controls.Add(lblVeritabani);
            grpVeritabani.Controls.Add(lblSunucuBaslik);
            grpVeritabani.Controls.Add(lblSunucu);
            grpVeritabani.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            grpVeritabani.Location = new Point(30, 80);
            grpVeritabani.Name = "grpVeritabani";
            grpVeritabani.Size = new Size(500, 230);
            grpVeritabani.TabIndex = 2;
            grpVeritabani.TabStop = false;
            grpVeritabani.ForeColor = Color.White;
            grpVeritabani.Text = "VERİTABANI BAĞLANTISI";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDurum.ForeColor = Color.LightGray;
            lblDurum.Location = new Point(20, 140);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(224, 28);
            lblDurum.TabIndex = 0;
            lblDurum.Text = "Bağlantı test ediliyor...";
            // 
            // btnBaglantiTest
            // 
            btnBaglantiTest.BackColor = Color.FromArgb(49, 130, 206);
            btnBaglantiTest.ForeColor = Color.White;
            btnBaglantiTest.FlatStyle = FlatStyle.Flat;
            btnBaglantiTest.FlatAppearance.BorderSize = 0;
            btnBaglantiTest.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBaglantiTest.Location = new Point(20, 180);
            btnBaglantiTest.Name = "btnBaglantiTest";
            btnBaglantiTest.Size = new Size(200, 35);
            btnBaglantiTest.TabIndex = 1;
            btnBaglantiTest.Text = "BAĞLANTIYI TEST ET";
            btnBaglantiTest.Click += btnBaglantiTest_Click;
            // 
            // lblBaglantiBaslik
            // 
            lblBaglantiBaslik.AutoSize = true;
            lblBaglantiBaslik.Font = new Font("Segoe UI", 10F);
            lblBaglantiBaslik.Location = new Point(20, 100);
            lblBaglantiBaslik.Name = "lblBaglantiBaslik";
            lblBaglantiBaslik.Size = new Size(154, 23);
            lblBaglantiBaslik.TabIndex = 2;
            lblBaglantiBaslik.ForeColor = Color.LightGray;
            lblBaglantiBaslik.Text = "Kimlik Doğrulama :";
            // 
            // lblBaglanti
            // 
            lblBaglanti.AutoSize = true;
            lblBaglanti.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblBaglanti.ForeColor = Color.FromArgb(49, 130, 206);
            lblBaglanti.Location = new Point(200, 100);
            lblBaglanti.Name = "lblBaglanti";
            lblBaglanti.Size = new Size(17, 23);
            lblBaglanti.TabIndex = 3;
            lblBaglanti.ForeColor = Color.FromArgb(100, 200, 255);
            lblBaglanti.Text = "-";
            // 
            // lblVeritabaniBaslik
            // 
            lblVeritabaniBaslik.AutoSize = true;
            lblVeritabaniBaslik.Font = new Font("Segoe UI", 10F);
            lblVeritabaniBaslik.Location = new Point(20, 70);
            lblVeritabaniBaslik.Name = "lblVeritabaniBaslik";
            lblVeritabaniBaslik.Size = new Size(96, 23);
            lblVeritabaniBaslik.TabIndex = 4;
            lblVeritabaniBaslik.ForeColor = Color.LightGray;
            lblVeritabaniBaslik.Text = "Veritabanı :";
            // 
            // lblVeritabani
            // 
            lblVeritabani.AutoSize = true;
            lblVeritabani.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblVeritabani.ForeColor = Color.FromArgb(49, 130, 206);
            lblVeritabani.Location = new Point(200, 70);
            lblVeritabani.Name = "lblVeritabani";
            lblVeritabani.Size = new Size(17, 23);
            lblVeritabani.TabIndex = 5;
            lblVeritabani.ForeColor = Color.FromArgb(100, 200, 255);
            lblVeritabani.Text = "-";
            // 
            // lblSunucuBaslik
            // 
            lblSunucuBaslik.AutoSize = true;
            lblSunucuBaslik.Font = new Font("Segoe UI", 10F);
            lblSunucuBaslik.Location = new Point(20, 40);
            lblSunucuBaslik.Name = "lblSunucuBaslik";
            lblSunucuBaslik.Size = new Size(76, 23);
            lblSunucuBaslik.TabIndex = 6;
            lblSunucuBaslik.ForeColor = Color.LightGray;
            lblSunucuBaslik.Text = "Sunucu :";
            // 
            // lblSunucu
            // 
            lblSunucu.AutoSize = true;
            lblSunucu.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSunucu.ForeColor = Color.FromArgb(49, 130, 206);
            lblSunucu.Location = new Point(200, 40);
            lblSunucu.Name = "lblSunucu";
            lblSunucu.Size = new Size(17, 23);
            lblSunucu.TabIndex = 7;
            lblSunucu.ForeColor = Color.FromArgb(100, 200, 255);
            lblSunucu.Text = "-";
            // 
            // grpSistem
            // 
            grpSistem.Controls.Add(btnTabloBilgi);
            grpSistem.Controls.Add(lblSistemBilgi);
            grpSistem.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            grpSistem.Location = new Point(30, 316);
            grpSistem.Name = "grpSistem";
            grpSistem.Size = new Size(500, 157);
            grpSistem.TabIndex = 1;
            grpSistem.TabStop = false;
            grpSistem.ForeColor = Color.White;
            grpSistem.Text = "SİSTEM İŞLEMLERİ";
            grpSistem.Enter += grpSistem_Enter;
            // 
            // btnTabloBilgi
            // 
            btnTabloBilgi.BackColor = Color.FromArgb(49, 130, 206);
            btnTabloBilgi.ForeColor = Color.White;
            btnTabloBilgi.FlatStyle = FlatStyle.Flat;
            btnTabloBilgi.FlatAppearance.BorderSize = 0;
            btnTabloBilgi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTabloBilgi.Location = new Point(20, 70);
            btnTabloBilgi.Name = "btnTabloBilgi";
            btnTabloBilgi.Size = new Size(250, 40);
            btnTabloBilgi.TabIndex = 0;
            btnTabloBilgi.Text = "TABLOLARI GÖRÜNTÜLE";
            btnTabloBilgi.Click += btnTabloBilgi_Click;
            // 
            // lblSistemBilgi
            // 
            lblSistemBilgi.AutoSize = true;
            lblSistemBilgi.Font = new Font("Segoe UI", 10F);
            lblSistemBilgi.Location = new Point(20, 35);
            lblSistemBilgi.Name = "lblSistemBilgi";
            lblSistemBilgi.Size = new Size(337, 23);
            lblSistemBilgi.TabIndex = 1;
            lblSistemBilgi.ForeColor = Color.LightGray;
            lblSistemBilgi.Text = "Veritabanındaki tüm tabloları görüntüleyin:";
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.FromArgb(197, 48, 48);
            btnKapat.ForeColor = Color.White;
            btnKapat.FlatStyle = FlatStyle.Flat;
            btnKapat.FlatAppearance.BorderSize = 0;
            btnKapat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKapat.Location = new Point(360, 491);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(170, 40);
            btnKapat.TabIndex = 0;
            btnKapat.Text = "KAPAT";
            btnKapat.Click += btnKapat_Click;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.White;
            lblBaslik.Location = new Point(30, 20);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(151, 41);
            lblBaslik.TabIndex = 3;
            lblBaslik.Text = "AYARLAR";
            // 
            // AYARLAR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(560, 560);
            Controls.Add(btnKapat);
            Controls.Add(grpSistem);
            Controls.Add(grpVeritabani);
            Controls.Add(lblBaslik);
            Name = "AYARLAR";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AYARLAR";
            Load += AYARLAR_Load;
            grpVeritabani.ResumeLayout(false);
            grpVeritabani.PerformLayout();
            grpSistem.ResumeLayout(false);
            grpSistem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.GroupBox grpVeritabani;
        private System.Windows.Forms.Label lblSunucuBaslik;
        private System.Windows.Forms.Label lblSunucu;
        private System.Windows.Forms.Label lblVeritabaniBaslik;
        private System.Windows.Forms.Label lblVeritabani;
        private System.Windows.Forms.Label lblBaglantiBaslik;
        private System.Windows.Forms.Label lblBaglanti;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnBaglantiTest;
        private System.Windows.Forms.GroupBox grpSistem;
        private System.Windows.Forms.Label lblSistemBilgi;
        private System.Windows.Forms.Button btnTabloBilgi;
        private System.Windows.Forms.Button btnKapat;
    }
}
