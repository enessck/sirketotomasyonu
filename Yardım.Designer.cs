namespace ŞİRKETOTOMASYONU
{
    partial class YARDIM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YARDIM));
            lblBaslik = new Label();
            lblVersiyon = new Label();
            grpModuller = new GroupBox();
            lblModulListesi = new Label();
            grpKisayollar = new GroupBox();
            lblKisayollar = new Label();
            grpHakkinda = new GroupBox();
            lblHakkinda = new Label();
            btnKapat = new Button();
            grpModuller.SuspendLayout();
            grpKisayollar.SuspendLayout();
            grpHakkinda.SuspendLayout();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.FromArgb(45, 55, 72);
            lblBaslik.Location = new Point(30, 20);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(500, 46);
            lblBaslik.TabIndex = 5;
            lblBaslik.Text = "ŞİRKET OTOMASYON SİSTEMİ";
            // 
            // lblVersiyon
            // 
            lblVersiyon.AutoSize = true;
            lblVersiyon.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblVersiyon.ForeColor = Color.FromArgb(49, 130, 206);
            lblVersiyon.Location = new Point(30, 70);
            lblVersiyon.Name = "lblVersiyon";
            lblVersiyon.Size = new Size(202, 25);
            lblVersiyon.TabIndex = 4;
            lblVersiyon.Text = "Versiyon 13.0.6  |  2026";
            // 
            // grpModuller
            // 
            grpModuller.Controls.Add(lblModulListesi);
            grpModuller.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpModuller.Location = new Point(30, 110);
            grpModuller.Name = "grpModuller";
            grpModuller.Size = new Size(350, 507);
            grpModuller.TabIndex = 3;
            grpModuller.TabStop = false;
            grpModuller.Text = "MODÜLLER";
            // 
            // lblModulListesi
            // 
            lblModulListesi.Font = new Font("Segoe UI", 10F);
            lblModulListesi.Location = new Point(15, 30);
            lblModulListesi.Name = "lblModulListesi";
            lblModulListesi.Size = new Size(320, 459);
            lblModulListesi.TabIndex = 0;
            lblModulListesi.Text = resources.GetString("lblModulListesi.Text");
            // 
            // grpKisayollar
            // 
            grpKisayollar.Controls.Add(lblKisayollar);
            grpKisayollar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpKisayollar.Location = new Point(400, 110);
            grpKisayollar.Name = "grpKisayollar";
            grpKisayollar.Size = new Size(350, 247);
            grpKisayollar.TabIndex = 2;
            grpKisayollar.TabStop = false;
            grpKisayollar.Text = "KULLANIM İPUÇLARI";
            // 
            // lblKisayollar
            // 
            lblKisayollar.Font = new Font("Segoe UI", 10F);
            lblKisayollar.Location = new Point(15, 30);
            lblKisayollar.Name = "lblKisayollar";
            lblKisayollar.Size = new Size(320, 226);
            lblKisayollar.TabIndex = 0;
            lblKisayollar.Text = "• Tablodaki satıra tıklayarak verileri\r\n  yandaki forma aktarabilirsiniz\r\n\r\n• Güncelleme için önce satıra tıklayın,\r\n  değişiklik yapıp GÜNCELLE'ye basın\r\n\r\n• Silmek için ID giriniz ve SİL'e basın";
            // 
            // grpHakkinda
            // 
            grpHakkinda.Controls.Add(lblHakkinda);
            grpHakkinda.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpHakkinda.Location = new Point(400, 369);
            grpHakkinda.Name = "grpHakkinda";
            grpHakkinda.Size = new Size(350, 193);
            grpHakkinda.TabIndex = 1;
            grpHakkinda.TabStop = false;
            grpHakkinda.Text = "HAKKINDA";
            // 
            // lblHakkinda
            // 
            lblHakkinda.Font = new Font("Segoe UI", 10F);
            lblHakkinda.Location = new Point(15, 33);
            lblHakkinda.Name = "lblHakkinda";
            lblHakkinda.Size = new Size(320, 160);
            lblHakkinda.TabIndex = 0;
            lblHakkinda.Text = "Bu uygulama şirket yönetimi için\r\ngeliştirilmiş bir otomasyon sistemidir.\r\n\r\nVeritabanı: SQL Server\r\nPlatform: Windows Forms (.NET)\r\nLisans: Öğrenci Sürümü";
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.FromArgb(197, 48, 48);
            btnKapat.ForeColor = Color.White;
            btnKapat.FlatStyle = FlatStyle.Flat;
            btnKapat.FlatAppearance.BorderSize = 0;
            btnKapat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKapat.Location = new Point(506, 577);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(170, 40);
            btnKapat.TabIndex = 0;
            btnKapat.Text = "KAPAT";
            btnKapat.Click += btnKapat_Click;
            // 
            // YARDIM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(780, 671);
            Controls.Add(btnKapat);
            Controls.Add(grpHakkinda);
            Controls.Add(grpKisayollar);
            Controls.Add(grpModuller);
            Controls.Add(lblVersiyon);
            Controls.Add(lblBaslik);
            Name = "YARDIM";
            StartPosition = FormStartPosition.CenterParent;
            Text = "YARDIM";
            Load += YARDIM_Load;
            grpModuller.ResumeLayout(false);
            grpKisayollar.ResumeLayout(false);
            grpHakkinda.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblVersiyon;
        private System.Windows.Forms.GroupBox grpModuller;
        private System.Windows.Forms.Label lblModulListesi;
        private System.Windows.Forms.GroupBox grpKisayollar;
        private System.Windows.Forms.Label lblKisayollar;
        private System.Windows.Forms.GroupBox grpHakkinda;
        private System.Windows.Forms.Label lblHakkinda;
        private System.Windows.Forms.Button btnKapat;
    }
}
