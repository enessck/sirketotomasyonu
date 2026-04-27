namespace ŞİRKETOTOMASYONU
{
    partial class ŞİRKETLER
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
            txtVergiDairesi = new TextBox();
            labelVergiDairesi = new Label();
            txtIlce = new TextBox();
            labelIlce = new Label();
            txtIl = new TextBox();
            labelIl = new Label();
            txtMail = new TextBox();
            labelMail = new Label();
            txtTel2 = new TextBox();
            labelTel2 = new Label();
            txtTel1 = new TextBox();
            labelTel1 = new Label();
            txtYetkiliAdSoyad = new TextBox();
            labelYetkiliAdSoyad = new Label();
            txtYetkili = new TextBox();
            labelYetkili = new Label();
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
            groupBox1.BackColor = Color.FromArgb(255, 128, 128);
            groupBox1.Controls.Add(btnguncelle);
            groupBox1.Controls.Add(btnsil);
            groupBox1.Controls.Add(btnkaydet);
            groupBox1.Controls.Add(txtAdres);
            groupBox1.Controls.Add(labelAdres);
            groupBox1.Controls.Add(txtVergiDairesi);
            groupBox1.Controls.Add(labelVergiDairesi);
            groupBox1.Controls.Add(txtIlce);
            groupBox1.Controls.Add(labelIlce);
            groupBox1.Controls.Add(txtIl);
            groupBox1.Controls.Add(labelIl);
            groupBox1.Controls.Add(txtMail);
            groupBox1.Controls.Add(labelMail);
            groupBox1.Controls.Add(txtTel2);
            groupBox1.Controls.Add(labelTel2);
            groupBox1.Controls.Add(txtTel1);
            groupBox1.Controls.Add(labelTel1);
            groupBox1.Controls.Add(txtYetkiliAdSoyad);
            groupBox1.Controls.Add(labelYetkiliAdSoyad);
            groupBox1.Controls.Add(txtYetkili);
            groupBox1.Controls.Add(labelYetkili);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(labelAd);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(labelId);
            groupBox1.Location = new Point(868, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(462, 700);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "ŞİRKET İŞLEMLERİ";
            // 
            // btnguncelle
            // 
            btnguncelle.BackColor = Color.FromArgb(192, 192, 255);
            btnguncelle.Location = new Point(110, 578);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(250, 45);
            btnguncelle.TabIndex = 0;
            btnguncelle.Text = "GÜNCELLE";
            btnguncelle.UseVisualStyleBackColor = false;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.Red;
            btnsil.ForeColor = Color.White;
            btnsil.Location = new Point(110, 527);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(250, 45);
            btnsil.TabIndex = 1;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // btnkaydet
            // 
            btnkaydet.BackColor = Color.FromArgb(255, 192, 255);
            btnkaydet.Location = new Point(110, 476);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(250, 45);
            btnkaydet.TabIndex = 2;
            btnkaydet.Text = "KAYDET";
            btnkaydet.UseVisualStyleBackColor = false;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // txtAdres
            // 
            txtAdres.BackColor = Color.FromArgb(0, 192, 192);
            txtAdres.Location = new Point(206, 390);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(250, 80);
            txtAdres.TabIndex = 11;
            txtAdres.Text = "";
            // 
            // labelAdres
            // 
            labelAdres.AutoSize = true;
            labelAdres.ForeColor = SystemColors.Control;
            labelAdres.Location = new Point(138, 415);
            labelAdres.Name = "labelAdres";
            labelAdres.Size = new Size(62, 20);
            labelAdres.TabIndex = 12;
            labelAdres.Text = "ADRES :";
            // 
            // txtVergiDairesi
            // 
            txtVergiDairesi.BackColor = Color.FromArgb(0, 192, 192);
            txtVergiDairesi.Location = new Point(206, 352);
            txtVergiDairesi.Name = "txtVergiDairesi";
            txtVergiDairesi.Size = new Size(250, 27);
            txtVergiDairesi.TabIndex = 13;
            // 
            // labelVergiDairesi
            // 
            labelVergiDairesi.AutoSize = true;
            labelVergiDairesi.ForeColor = SystemColors.Control;
            labelVergiDairesi.Location = new Point(86, 359);
            labelVergiDairesi.Name = "labelVergiDairesi";
            labelVergiDairesi.Size = new Size(114, 20);
            labelVergiDairesi.TabIndex = 14;
            labelVergiDairesi.Text = "VERGİ DAİRESİ :";
            // 
            // txtIlce
            // 
            txtIlce.BackColor = Color.FromArgb(0, 192, 192);
            txtIlce.Location = new Point(206, 317);
            txtIlce.Name = "txtIlce";
            txtIlce.Size = new Size(250, 27);
            txtIlce.TabIndex = 15;
            // 
            // labelIlce
            // 
            labelIlce.AutoSize = true;
            labelIlce.ForeColor = SystemColors.Control;
            labelIlce.Location = new Point(157, 324);
            labelIlce.Name = "labelIlce";
            labelIlce.Size = new Size(43, 20);
            labelIlce.TabIndex = 16;
            labelIlce.Text = "İLÇE :";
            // 
            // txtIl
            // 
            txtIl.BackColor = Color.FromArgb(0, 192, 192);
            txtIl.Location = new Point(206, 282);
            txtIl.Name = "txtIl";
            txtIl.Size = new Size(250, 27);
            txtIl.TabIndex = 17;
            // 
            // labelIl
            // 
            labelIl.AutoSize = true;
            labelIl.ForeColor = SystemColors.Control;
            labelIl.Location = new Point(173, 289);
            labelIl.Name = "labelIl";
            labelIl.Size = new Size(27, 20);
            labelIl.TabIndex = 18;
            labelIl.Text = "İL :";
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.FromArgb(0, 192, 192);
            txtMail.Location = new Point(206, 247);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(250, 27);
            txtMail.TabIndex = 19;
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.ForeColor = SystemColors.Control;
            labelMail.Location = new Point(150, 254);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(50, 20);
            labelMail.TabIndex = 20;
            labelMail.Text = "MAİL :";
            // 
            // txtTel2
            // 
            txtTel2.BackColor = Color.FromArgb(0, 192, 192);
            txtTel2.Location = new Point(206, 212);
            txtTel2.Name = "txtTel2";
            txtTel2.Size = new Size(250, 27);
            txtTel2.TabIndex = 21;
            // 
            // labelTel2
            // 
            labelTel2.AutoSize = true;
            labelTel2.ForeColor = SystemColors.Control;
            labelTel2.Location = new Point(149, 219);
            labelTel2.Name = "labelTel2";
            labelTel2.Size = new Size(51, 20);
            labelTel2.TabIndex = 22;
            labelTel2.Text = "TEL 2 :";
            // 
            // txtTel1
            // 
            txtTel1.BackColor = Color.FromArgb(0, 192, 192);
            txtTel1.Location = new Point(206, 178);
            txtTel1.Name = "txtTel1";
            txtTel1.Size = new Size(250, 27);
            txtTel1.TabIndex = 23;
            // 
            // labelTel1
            // 
            labelTel1.AutoSize = true;
            labelTel1.ForeColor = SystemColors.Control;
            labelTel1.Location = new Point(149, 185);
            labelTel1.Name = "labelTel1";
            labelTel1.Size = new Size(51, 20);
            labelTel1.TabIndex = 24;
            labelTel1.Text = "TEL 1 :";
            // 
            // txtYetkiliAdSoyad
            // 
            txtYetkiliAdSoyad.BackColor = Color.FromArgb(0, 192, 192);
            txtYetkiliAdSoyad.Location = new Point(206, 145);
            txtYetkiliAdSoyad.Name = "txtYetkiliAdSoyad";
            txtYetkiliAdSoyad.Size = new Size(250, 27);
            txtYetkiliAdSoyad.TabIndex = 25;
            // 
            // labelYetkiliAdSoyad
            // 
            labelYetkiliAdSoyad.AutoSize = true;
            labelYetkiliAdSoyad.ForeColor = SystemColors.Control;
            labelYetkiliAdSoyad.Location = new Point(57, 152);
            labelYetkiliAdSoyad.Name = "labelYetkiliAdSoyad";
            labelYetkiliAdSoyad.Size = new Size(140, 20);
            labelYetkiliAdSoyad.TabIndex = 26;
            labelYetkiliAdSoyad.Text = "YETKİLİ AD SOYAD :";
            // 
            // txtYetkili
            // 
            txtYetkili.BackColor = Color.FromArgb(0, 192, 192);
            txtYetkili.Location = new Point(206, 112);
            txtYetkili.Name = "txtYetkili";
            txtYetkili.Size = new Size(250, 27);
            txtYetkili.TabIndex = 27;
            // 
            // labelYetkili
            // 
            labelYetkili.AutoSize = true;
            labelYetkili.ForeColor = SystemColors.Control;
            labelYetkili.Location = new Point(131, 119);
            labelYetkili.Name = "labelYetkili";
            labelYetkili.Size = new Size(64, 20);
            labelYetkili.TabIndex = 28;
            labelYetkili.Text = "YETKİLİ :";
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.FromArgb(0, 192, 192);
            txtAd.Location = new Point(206, 77);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(250, 27);
            txtAd.TabIndex = 29;
            // 
            // labelAd
            // 
            labelAd.AutoSize = true;
            labelAd.ForeColor = SystemColors.Control;
            labelAd.Location = new Point(157, 84);
            labelAd.Name = "labelAd";
            labelAd.Size = new Size(37, 20);
            labelAd.TabIndex = 30;
            labelAd.Text = "AD :";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(0, 192, 192);
            txtId.ForeColor = SystemColors.HotTrack;
            txtId.Location = new Point(206, 44);
            txtId.Name = "txtId";
            txtId.Size = new Size(250, 27);
            txtId.TabIndex = 31;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.ForeColor = SystemColors.Control;
            labelId.Location = new Point(163, 51);
            labelId.Name = "labelId";
            labelId.Size = new Size(31, 20);
            labelId.TabIndex = 32;
            labelId.Text = "ID :";
            // 
            // ŞİRKETLER
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 750);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "ŞİRKETLER";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ŞİRKETLER";
            Load += ŞİRKETLER_Load;
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
        private System.Windows.Forms.TextBox txtYetkili;
        private System.Windows.Forms.Label labelYetkili;
        private System.Windows.Forms.TextBox txtYetkiliAdSoyad;
        private System.Windows.Forms.Label labelYetkiliAdSoyad;
        private System.Windows.Forms.TextBox txtTel1;
        private System.Windows.Forms.Label labelTel1;
        private System.Windows.Forms.TextBox txtTel2;
        private System.Windows.Forms.Label labelTel2;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox txtIl;
        private System.Windows.Forms.Label labelIl;
        private System.Windows.Forms.TextBox txtIlce;
        private System.Windows.Forms.Label labelIlce;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.Label labelVergiDairesi;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.Label labelAdres;
        
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
    }
}