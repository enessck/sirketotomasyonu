namespace ŞİRKETOTOMASYONU
{
    partial class ANASAYFA
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
            lblBaslik = new Label();
            lblTarih = new Label();
            lblSaat = new Label();
            pnlUrun = new Panel();
            lblUrunSayi = new Label();
            lblUrunBaslik = new Label();
            pnlStok = new Panel();
            lblStokSayi = new Label();
            lblStokBaslik = new Label();
            pnlMusteri = new Panel();
            lblMusteriSayi = new Label();
            lblMusteriBaslik = new Label();
            pnlSirket = new Panel();
            lblSirketSayi = new Label();
            lblSirketBaslik = new Label();
            pnlPersonel = new Panel();
            lblPersonelSayi = new Label();
            lblPersonelBaslik = new Label();
            pnlBanka = new Panel();
            lblBankaSayi = new Label();
            lblBankaBaslik = new Label();
            pnlFatura = new Panel();
            btnKapat = new Button();
            lblFaturaSayi = new Label();
            lblFaturaBaslik = new Label();
            pnlGider = new Panel();
            lblGiderSayi = new Label();
            lblGiderBaslik = new Label();
            pnlUrun.SuspendLayout();
            pnlStok.SuspendLayout();
            pnlMusteri.SuspendLayout();
            pnlSirket.SuspendLayout();
            pnlPersonel.SuspendLayout();
            pnlBanka.SuspendLayout();
            pnlFatura.SuspendLayout();
            pnlGider.SuspendLayout();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.Black;
            lblBaslik.Location = new Point(238, 9);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(263, 50);
            lblBaslik.TabIndex = 13;
            lblBaslik.Text = " GENEL BAKIŞ";
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Font = new Font("Segoe UI", 11F);
            lblTarih.ForeColor = Color.Gray;
            lblTarih.Location = new Point(35, 68);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(20, 25);
            lblTarih.TabIndex = 12;
            lblTarih.Text = "-";
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSaat.ForeColor = Color.FromArgb(49, 130, 206);
            lblSaat.Location = new Point(680, 22);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(74, 41);
            lblSaat.TabIndex = 11;
            lblSaat.Text = "--:--";
            lblSaat.Click += lblSaat_Click;
            // 
            // pnlUrun
            // 
            pnlUrun.BackColor = Color.FromArgb(235, 248, 255);
            pnlUrun.BorderStyle = BorderStyle.FixedSingle;
            pnlUrun.Controls.Add(lblUrunSayi);
            pnlUrun.Controls.Add(lblUrunBaslik);
            pnlUrun.Location = new Point(68, 107);
            pnlUrun.Name = "pnlUrun";
            pnlUrun.Size = new Size(185, 110);
            pnlUrun.TabIndex = 10;
            // 
            // lblUrunSayi
            // 
            lblUrunSayi.AutoSize = true;
            lblUrunSayi.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblUrunSayi.ForeColor = Color.FromArgb(49, 130, 206);
            lblUrunSayi.Location = new Point(10, 42);
            lblUrunSayi.Name = "lblUrunSayi";
            lblUrunSayi.Size = new Size(54, 62);
            lblUrunSayi.TabIndex = 0;
            lblUrunSayi.Text = "0";
            // 
            // lblUrunBaslik
            // 
            lblUrunBaslik.AutoSize = true;
            lblUrunBaslik.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblUrunBaslik.ForeColor = Color.FromArgb(44, 82, 130);
            lblUrunBaslik.Location = new Point(10, 10);
            lblUrunBaslik.Name = "lblUrunBaslik";
            lblUrunBaslik.Size = new Size(120, 23);
            lblUrunBaslik.TabIndex = 1;
            lblUrunBaslik.Text = "📦  ÜRÜNLER";
            // 
            // pnlStok
            // 
            pnlStok.BackColor = Color.FromArgb(192, 192, 255);
            pnlStok.BorderStyle = BorderStyle.FixedSingle;
            pnlStok.Controls.Add(lblStokSayi);
            pnlStok.Controls.Add(lblStokBaslik);
            pnlStok.Location = new Point(211, 263);
            pnlStok.Name = "pnlStok";
            pnlStok.Size = new Size(185, 110);
            pnlStok.TabIndex = 9;
            // 
            // lblStokSayi
            // 
            lblStokSayi.AutoSize = true;
            lblStokSayi.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblStokSayi.ForeColor = Color.Black;
            lblStokSayi.Location = new Point(10, 42);
            lblStokSayi.Name = "lblStokSayi";
            lblStokSayi.Size = new Size(54, 62);
            lblStokSayi.TabIndex = 0;
            lblStokSayi.Text = "0";
            // 
            // lblStokBaslik
            // 
            lblStokBaslik.AutoSize = true;
            lblStokBaslik.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblStokBaslik.ForeColor = Color.FromArgb(192, 0, 0);
            lblStokBaslik.Location = new Point(10, 10);
            lblStokBaslik.Name = "lblStokBaslik";
            lblStokBaslik.Size = new Size(114, 23);
            lblStokBaslik.TabIndex = 1;
            lblStokBaslik.Text = "📊  STOKLAR";
            // 
            // pnlMusteri
            // 
            pnlMusteri.BackColor = Color.FromArgb(224, 224, 224);
            pnlMusteri.BorderStyle = BorderStyle.FixedSingle;
            pnlMusteri.Controls.Add(lblMusteriSayi);
            pnlMusteri.Controls.Add(lblMusteriBaslik);
            pnlMusteri.Location = new Point(2, 128);
            pnlMusteri.Name = "pnlMusteri";
            pnlMusteri.Size = new Size(185, 110);
            pnlMusteri.TabIndex = 8;
            // 
            // lblMusteriSayi
            // 
            lblMusteriSayi.AutoSize = true;
            lblMusteriSayi.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblMusteriSayi.ForeColor = Color.Black;
            lblMusteriSayi.Location = new Point(3, 41);
            lblMusteriSayi.Name = "lblMusteriSayi";
            lblMusteriSayi.Size = new Size(54, 62);
            lblMusteriSayi.TabIndex = 0;
            lblMusteriSayi.Text = "0";
            // 
            // lblMusteriBaslik
            // 
            lblMusteriBaslik.AutoSize = true;
            lblMusteriBaslik.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblMusteriBaslik.ForeColor = Color.Red;
            lblMusteriBaslik.Location = new Point(10, 10);
            lblMusteriBaslik.Name = "lblMusteriBaslik";
            lblMusteriBaslik.Size = new Size(143, 23);
            lblMusteriBaslik.TabIndex = 1;
            lblMusteriBaslik.Text = "👥  MÜŞTERİLER";
            // 
            // pnlSirket
            // 
            pnlSirket.BackColor = Color.Teal;
            pnlSirket.BorderStyle = BorderStyle.FixedSingle;
            pnlSirket.Controls.Add(lblSirketSayi);
            pnlSirket.Controls.Add(lblSirketBaslik);
            pnlSirket.Location = new Point(444, 128);
            pnlSirket.Name = "pnlSirket";
            pnlSirket.Size = new Size(185, 110);
            pnlSirket.TabIndex = 7;
            // 
            // lblSirketSayi
            // 
            lblSirketSayi.AutoSize = true;
            lblSirketSayi.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblSirketSayi.ForeColor = Color.Black;
            lblSirketSayi.Location = new Point(10, 42);
            lblSirketSayi.Name = "lblSirketSayi";
            lblSirketSayi.Size = new Size(54, 62);
            lblSirketSayi.TabIndex = 0;
            lblSirketSayi.Text = "0";
            // 
            // lblSirketBaslik
            // 
            lblSirketBaslik.AutoSize = true;
            lblSirketBaslik.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSirketBaslik.ForeColor = Color.FromArgb(192, 0, 0);
            lblSirketBaslik.Location = new Point(10, 10);
            lblSirketBaslik.Name = "lblSirketBaslik";
            lblSirketBaslik.Size = new Size(125, 23);
            lblSirketBaslik.TabIndex = 1;
            lblSirketBaslik.Text = "🏢  ŞİRKETLER";
            // 
            // pnlPersonel
            // 
            pnlPersonel.BackColor = Color.Green;
            pnlPersonel.BorderStyle = BorderStyle.FixedSingle;
            pnlPersonel.Controls.Add(lblPersonelSayi);
            pnlPersonel.Controls.Add(lblPersonelBaslik);
            pnlPersonel.Controls.Add(pnlUrun);
            pnlPersonel.Location = new Point(211, 399);
            pnlPersonel.Name = "pnlPersonel";
            pnlPersonel.Size = new Size(185, 110);
            pnlPersonel.TabIndex = 6;
            // 
            // lblPersonelSayi
            // 
            lblPersonelSayi.AutoSize = true;
            lblPersonelSayi.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblPersonelSayi.ForeColor = Color.Black;
            lblPersonelSayi.Location = new Point(10, 42);
            lblPersonelSayi.Name = "lblPersonelSayi";
            lblPersonelSayi.Size = new Size(54, 62);
            lblPersonelSayi.TabIndex = 0;
            lblPersonelSayi.Text = "0";
            // 
            // lblPersonelBaslik
            // 
            lblPersonelBaslik.AutoSize = true;
            lblPersonelBaslik.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblPersonelBaslik.ForeColor = Color.FromArgb(192, 0, 0);
            lblPersonelBaslik.Location = new Point(10, 10);
            lblPersonelBaslik.Name = "lblPersonelBaslik";
            lblPersonelBaslik.Size = new Size(126, 23);
            lblPersonelBaslik.TabIndex = 1;
            lblPersonelBaslik.Text = "👨‍💼  PERSONEL";
            // 
            // pnlBanka
            // 
            pnlBanka.BackColor = Color.RosyBrown;
            pnlBanka.BorderStyle = BorderStyle.FixedSingle;
            pnlBanka.Controls.Add(lblBankaSayi);
            pnlBanka.Controls.Add(lblBankaBaslik);
            pnlBanka.Location = new Point(2, 263);
            pnlBanka.Name = "pnlBanka";
            pnlBanka.Size = new Size(185, 110);
            pnlBanka.TabIndex = 5;
            // 
            // lblBankaSayi
            // 
            lblBankaSayi.AutoSize = true;
            lblBankaSayi.BackColor = Color.Transparent;
            lblBankaSayi.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblBankaSayi.ForeColor = Color.Black;
            lblBankaSayi.Location = new Point(10, 42);
            lblBankaSayi.Name = "lblBankaSayi";
            lblBankaSayi.Size = new Size(54, 62);
            lblBankaSayi.TabIndex = 0;
            lblBankaSayi.Text = "0";
            // 
            // lblBankaBaslik
            // 
            lblBankaBaslik.AutoSize = true;
            lblBankaBaslik.BackColor = Color.Transparent;
            lblBankaBaslik.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblBankaBaslik.ForeColor = Color.Red;
            lblBankaBaslik.Location = new Point(10, 10);
            lblBankaBaslik.Name = "lblBankaBaslik";
            lblBankaBaslik.Size = new Size(129, 23);
            lblBankaBaslik.TabIndex = 1;
            lblBankaBaslik.Text = "🏦  BANKALAR";
            // 
            // pnlFatura
            // 
            pnlFatura.BackColor = Color.FromArgb(255, 224, 192);
            pnlFatura.BorderStyle = BorderStyle.FixedSingle;
            pnlFatura.Controls.Add(btnKapat);
            pnlFatura.Controls.Add(lblFaturaSayi);
            pnlFatura.Controls.Add(lblFaturaBaslik);
            pnlFatura.Location = new Point(2, 399);
            pnlFatura.Name = "pnlFatura";
            pnlFatura.Size = new Size(185, 110);
            pnlFatura.TabIndex = 4;
            // 
            // btnKapat
            // 
            btnKapat.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnKapat.ForeColor = Color.FromArgb(192, 0, 0);
            btnKapat.Location = new Point(-1, -1);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(185, 40);
            btnKapat.TabIndex = 0;
            btnKapat.Text = "KAPAT";
            btnKapat.Click += btnKapat_Click;
            // 
            // lblFaturaSayi
            // 
            lblFaturaSayi.AutoSize = true;
            lblFaturaSayi.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblFaturaSayi.ForeColor = Color.Black;
            lblFaturaSayi.Location = new Point(10, 42);
            lblFaturaSayi.Name = "lblFaturaSayi";
            lblFaturaSayi.Size = new Size(54, 62);
            lblFaturaSayi.TabIndex = 0;
            lblFaturaSayi.Text = "0";
            // 
            // lblFaturaBaslik
            // 
            lblFaturaBaslik.AutoSize = true;
            lblFaturaBaslik.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblFaturaBaslik.ForeColor = Color.FromArgb(116, 81, 0);
            lblFaturaBaslik.Location = new Point(10, 10);
            lblFaturaBaslik.Name = "lblFaturaBaslik";
            lblFaturaBaslik.Size = new Size(135, 23);
            lblFaturaBaslik.TabIndex = 1;
            lblFaturaBaslik.Text = "\U0001f9fe  FATURALAR";
            // 
            // pnlGider
            // 
            pnlGider.BackColor = Color.Olive;
            pnlGider.BorderStyle = BorderStyle.FixedSingle;
            pnlGider.Controls.Add(lblGiderSayi);
            pnlGider.Controls.Add(lblGiderBaslik);
            pnlGider.Location = new Point(222, 128);
            pnlGider.Name = "pnlGider";
            pnlGider.Size = new Size(185, 110);
            pnlGider.TabIndex = 3;
            // 
            // lblGiderSayi
            // 
            lblGiderSayi.AutoSize = true;
            lblGiderSayi.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblGiderSayi.ForeColor = Color.Black;
            lblGiderSayi.Location = new Point(-1, 47);
            lblGiderSayi.Name = "lblGiderSayi";
            lblGiderSayi.Size = new Size(54, 62);
            lblGiderSayi.TabIndex = 0;
            lblGiderSayi.Text = "0";
            // 
            // lblGiderBaslik
            // 
            lblGiderBaslik.AutoSize = true;
            lblGiderBaslik.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblGiderBaslik.ForeColor = Color.FromArgb(130, 30, 30);
            lblGiderBaslik.Location = new Point(10, 10);
            lblGiderBaslik.Name = "lblGiderBaslik";
            lblGiderBaslik.Size = new Size(121, 23);
            lblGiderBaslik.TabIndex = 1;
            lblGiderBaslik.Text = "💸  GİDERLER";
            // 
            // ANASAYFA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(844, 521);
            Controls.Add(pnlGider);
            Controls.Add(pnlFatura);
            Controls.Add(pnlBanka);
            Controls.Add(pnlPersonel);
            Controls.Add(pnlSirket);
            Controls.Add(pnlMusteri);
            Controls.Add(pnlStok);
            Controls.Add(lblSaat);
            Controls.Add(lblTarih);
            Controls.Add(lblBaslik);
            Name = "ANASAYFA";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ANASAYFA - Genel Bakış";
            Load += ANASAYFA_Load;
            pnlUrun.ResumeLayout(false);
            pnlUrun.PerformLayout();
            pnlStok.ResumeLayout(false);
            pnlStok.PerformLayout();
            pnlMusteri.ResumeLayout(false);
            pnlMusteri.PerformLayout();
            pnlSirket.ResumeLayout(false);
            pnlSirket.PerformLayout();
            pnlPersonel.ResumeLayout(false);
            pnlPersonel.PerformLayout();
            pnlBanka.ResumeLayout(false);
            pnlBanka.PerformLayout();
            pnlFatura.ResumeLayout(false);
            pnlFatura.PerformLayout();
            pnlGider.ResumeLayout(false);
            pnlGider.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;

        private System.Windows.Forms.Panel pnlUrun;
        private System.Windows.Forms.Label lblUrunBaslik;
        private System.Windows.Forms.Label lblUrunSayi;

        private System.Windows.Forms.Panel pnlStok;
        private System.Windows.Forms.Label lblStokBaslik;
        private System.Windows.Forms.Label lblStokSayi;

        private System.Windows.Forms.Panel pnlMusteri;
        private System.Windows.Forms.Label lblMusteriBaslik;
        private System.Windows.Forms.Label lblMusteriSayi;

        private System.Windows.Forms.Panel pnlSirket;
        private System.Windows.Forms.Label lblSirketBaslik;
        private System.Windows.Forms.Label lblSirketSayi;

        private System.Windows.Forms.Panel pnlPersonel;
        private System.Windows.Forms.Label lblPersonelBaslik;
        private System.Windows.Forms.Label lblPersonelSayi;

        private System.Windows.Forms.Panel pnlBanka;
        private System.Windows.Forms.Label lblBankaBaslik;
        private System.Windows.Forms.Label lblBankaSayi;

        private System.Windows.Forms.Panel pnlFatura;
        private System.Windows.Forms.Label lblFaturaBaslik;
        private System.Windows.Forms.Label lblFaturaSayi;

        private System.Windows.Forms.Panel pnlGider;
        private System.Windows.Forms.Label lblGiderBaslik;
        private System.Windows.Forms.Label lblGiderSayi;
        private System.Windows.Forms.Button btnKapat;
    }
}
