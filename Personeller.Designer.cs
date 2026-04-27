namespace ŞİRKETOTOMASYONU
{
    partial class PERSONELLER
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            btnguncelle = new Button();
            btnsil = new Button();
            btnkaydet = new Button();
            txtAdres = new RichTextBox();
            labelAdres = new Label();
            txtGorevi = new TextBox();
            labelGorevi = new Label();
            txtIlce = new TextBox();
            labelIlce = new Label();
            txtIl = new TextBox();
            labelIl = new Label();
            txtMail = new TextBox();
            labelMail = new Label();
            txtTelefon = new TextBox();
            labelTelefon = new Label();
            txtTc = new TextBox();
            labelTc = new Label();
            txtSoyad = new TextBox();
            labelSoyad = new Label();
            txtAd = new TextBox();
            labelAd = new Label();
            txtId = new TextBox();
            labelId = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(850, 700);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btnguncelle);
            groupBox1.Controls.Add(btnsil);
            groupBox1.Controls.Add(btnkaydet);
            groupBox1.Controls.Add(txtAdres);
            groupBox1.Controls.Add(labelAdres);
            groupBox1.Controls.Add(txtGorevi);
            groupBox1.Controls.Add(labelGorevi);
            groupBox1.Controls.Add(txtIlce);
            groupBox1.Controls.Add(labelIlce);
            groupBox1.Controls.Add(txtIl);
            groupBox1.Controls.Add(labelIl);
            groupBox1.Controls.Add(txtMail);
            groupBox1.Controls.Add(labelMail);
            groupBox1.Controls.Add(txtTelefon);
            groupBox1.Controls.Add(labelTelefon);
            groupBox1.Controls.Add(txtTc);
            groupBox1.Controls.Add(labelTc);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(labelSoyad);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(labelAd);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(labelId);
            groupBox1.Location = new Point(868, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(482, 700);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "PERSONEL İŞLEMLERİ";
            // 
            // btnguncelle
            // 
            btnguncelle.BackColor = Color.FromArgb(192, 0, 192);
            btnguncelle.Location = new Point(89, 583);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(250, 45);
            btnguncelle.TabIndex = 14;
            btnguncelle.Text = "GÜNCELLE";
            btnguncelle.UseVisualStyleBackColor = false;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.Red;
            btnsil.ForeColor = Color.White;
            btnsil.Location = new Point(89, 522);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(250, 45);
            btnsil.TabIndex = 13;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // btnkaydet
            // 
            btnkaydet.BackColor = Color.FromArgb(128, 128, 255);
            btnkaydet.Location = new Point(89, 458);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(250, 45);
            btnkaydet.TabIndex = 12;
            btnkaydet.Text = "KAYDET";
            btnkaydet.UseVisualStyleBackColor = false;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(141, 320);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(303, 80);
            txtAdres.TabIndex = 11;
            txtAdres.Text = "";
            // 
            // labelAdres
            // 
            labelAdres.AutoSize = true;
            labelAdres.ForeColor = Color.FromArgb(64, 0, 64);
            labelAdres.Location = new Point(73, 345);
            labelAdres.Name = "labelAdres";
            labelAdres.Size = new Size(62, 20);
            labelAdres.TabIndex = 15;
            labelAdres.Text = "ADRES :";
            // 
            // txtGorevi
            // 
            txtGorevi.Location = new Point(141, 410);
            txtGorevi.Name = "txtGorevi";
            txtGorevi.Size = new Size(303, 27);
            txtGorevi.TabIndex = 16;
            // 
            // labelGorevi
            // 
            labelGorevi.AutoSize = true;
            labelGorevi.ForeColor = Color.FromArgb(64, 0, 64);
            labelGorevi.Location = new Point(65, 417);
            labelGorevi.Name = "labelGorevi";
            labelGorevi.Size = new Size(67, 20);
            labelGorevi.TabIndex = 17;
            labelGorevi.Text = "GÖREVİ :";
            // 
            // txtIlce
            // 
            txtIlce.Location = new Point(141, 287);
            txtIlce.Name = "txtIlce";
            txtIlce.Size = new Size(303, 27);
            txtIlce.TabIndex = 18;
            // 
            // labelIlce
            // 
            labelIlce.AutoSize = true;
            labelIlce.ForeColor = Color.FromArgb(64, 0, 64);
            labelIlce.Location = new Point(89, 294);
            labelIlce.Name = "labelIlce";
            labelIlce.Size = new Size(43, 20);
            labelIlce.TabIndex = 19;
            labelIlce.Text = "İLÇE :";
            // 
            // txtIl
            // 
            txtIl.Location = new Point(141, 252);
            txtIl.Name = "txtIl";
            txtIl.Size = new Size(303, 27);
            txtIl.TabIndex = 20;
            // 
            // labelIl
            // 
            labelIl.AutoSize = true;
            labelIl.ForeColor = Color.FromArgb(64, 0, 64);
            labelIl.Location = new Point(105, 259);
            labelIl.Name = "labelIl";
            labelIl.Size = new Size(27, 20);
            labelIl.TabIndex = 21;
            labelIl.Text = "İL :";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(141, 215);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(303, 27);
            txtMail.TabIndex = 22;
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.ForeColor = Color.FromArgb(64, 0, 64);
            labelMail.Location = new Point(85, 222);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(50, 20);
            labelMail.TabIndex = 23;
            labelMail.Text = "MAİL :";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(141, 182);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(303, 27);
            txtTelefon.TabIndex = 24;
            // 
            // labelTelefon
            // 
            labelTelefon.AutoSize = true;
            labelTelefon.ForeColor = Color.FromArgb(64, 0, 64);
            labelTelefon.Location = new Point(33, 189);
            labelTelefon.Name = "labelTelefon";
            labelTelefon.Size = new Size(102, 20);
            labelTelefon.TabIndex = 25;
            labelTelefon.Text = "TELEFON NO :";
            // 
            // txtTc
            // 
            txtTc.Location = new Point(141, 145);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(303, 27);
            txtTc.TabIndex = 26;
            // 
            // labelTc
            // 
            labelTc.AutoSize = true;
            labelTc.ForeColor = Color.FromArgb(64, 0, 64);
            labelTc.Location = new Point(100, 152);
            labelTc.Name = "labelTc";
            labelTc.Size = new Size(32, 20);
            labelTc.TabIndex = 27;
            labelTc.Text = "TC :";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(141, 112);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(303, 27);
            txtSoyad.TabIndex = 28;
            // 
            // labelSoyad
            // 
            labelSoyad.AutoSize = true;
            labelSoyad.ForeColor = Color.FromArgb(64, 0, 64);
            labelSoyad.Location = new Point(69, 119);
            labelSoyad.Name = "labelSoyad";
            labelSoyad.Size = new Size(63, 20);
            labelSoyad.TabIndex = 29;
            labelSoyad.Text = "SOYAD :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(141, 77);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(303, 27);
            txtAd.TabIndex = 30;
            // 
            // labelAd
            // 
            labelAd.AutoSize = true;
            labelAd.ForeColor = Color.FromArgb(64, 0, 64);
            labelAd.Location = new Point(95, 84);
            labelAd.Name = "labelAd";
            labelAd.Size = new Size(37, 20);
            labelAd.TabIndex = 31;
            labelAd.Text = "AD :";
            // 
            // txtId
            // 
            txtId.Location = new Point(141, 42);
            txtId.Name = "txtId";
            txtId.Size = new Size(303, 27);
            txtId.TabIndex = 32;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.ForeColor = Color.FromArgb(64, 0, 64);
            labelId.Location = new Point(101, 49);
            labelId.Name = "labelId";
            labelId.Size = new Size(31, 20);
            labelId.TabIndex = 33;
            labelId.Text = "ID :";
            // 
            // PERSONELLER
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 750);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "PERSONELLER";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PERSONELLER";
            Load += PERSONELLER_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label labelTc;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox txtIl;
        private System.Windows.Forms.Label labelIl;
        private System.Windows.Forms.TextBox txtIlce;
        private System.Windows.Forms.Label labelIlce;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.TextBox txtGorevi;
        private System.Windows.Forms.Label labelGorevi;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
    }
}