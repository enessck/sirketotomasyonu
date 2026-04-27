namespace ŞİRKETOTOMASYONU
{
    partial class BANKALAR
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
            txtTarih = new TextBox();
            labelTarih = new Label();
            txtYetkili = new TextBox();
            labelYetkili = new Label();
            txtHesapNo = new TextBox();
            labelHesapNo = new Label();
            txtIban = new TextBox();
            labelIban = new Label();
            txtSube = new TextBox();
            labelSube = new Label();
            txtBankaAd = new TextBox();
            labelBankaAd = new Label();
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
            dataGridView1.GridColor = SystemColors.HotTrack;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 600);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GrayText;
            groupBox1.Controls.Add(btnguncelle);
            groupBox1.Controls.Add(btnsil);
            groupBox1.Controls.Add(btnkaydet);
            groupBox1.Controls.Add(txtTarih);
            groupBox1.Controls.Add(labelTarih);
            groupBox1.Controls.Add(txtYetkili);
            groupBox1.Controls.Add(labelYetkili);
            groupBox1.Controls.Add(txtHesapNo);
            groupBox1.Controls.Add(labelHesapNo);
            groupBox1.Controls.Add(txtIban);
            groupBox1.Controls.Add(labelIban);
            groupBox1.Controls.Add(txtSube);
            groupBox1.Controls.Add(labelSube);
            groupBox1.Controls.Add(txtBankaAd);
            groupBox1.Controls.Add(labelBankaAd);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(labelId);
            groupBox1.Location = new Point(818, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(462, 600);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "BANKA İŞLEMLERİ";
            // 
            // btnguncelle
            // 
            btnguncelle.BackColor = SystemColors.Highlight;
            btnguncelle.Location = new Point(83, 460);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(250, 45);
            btnguncelle.TabIndex = 0;
            btnguncelle.Text = "GÜNCELLE";
            btnguncelle.UseVisualStyleBackColor = false;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.Chocolate;
            btnsil.ForeColor = Color.White;
            btnsil.Location = new Point(83, 521);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(250, 45);
            btnsil.TabIndex = 1;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // btnkaydet
            // 
            btnkaydet.BackColor = SystemColors.ActiveCaption;
            btnkaydet.Location = new Point(83, 396);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(250, 45);
            btnkaydet.TabIndex = 2;
            btnkaydet.Text = "KAYDET";
            btnkaydet.UseVisualStyleBackColor = false;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // txtTarih
            // 
            txtTarih.Location = new Point(147, 306);
            txtTarih.Name = "txtTarih";
            txtTarih.Size = new Size(297, 27);
            txtTarih.TabIndex = 3;
            // 
            // labelTarih
            // 
            labelTarih.AutoSize = true;
            labelTarih.Location = new Point(77, 313);
            labelTarih.Name = "labelTarih";
            labelTarih.Size = new Size(57, 20);
            labelTarih.TabIndex = 4;
            labelTarih.Text = "TARİH :";
            // 
            // txtYetkili
            // 
            txtYetkili.Location = new Point(147, 273);
            txtYetkili.Name = "txtYetkili";
            txtYetkili.Size = new Size(297, 27);
            txtYetkili.TabIndex = 5;
            // 
            // labelYetkili
            // 
            labelYetkili.AutoSize = true;
            labelYetkili.Location = new Point(70, 280);
            labelYetkili.Name = "labelYetkili";
            labelYetkili.Size = new Size(64, 20);
            labelYetkili.TabIndex = 6;
            labelYetkili.Text = "YETKİLİ :";
            // 
            // txtHesapNo
            // 
            txtHesapNo.Location = new Point(147, 237);
            txtHesapNo.Name = "txtHesapNo";
            txtHesapNo.Size = new Size(297, 27);
            txtHesapNo.TabIndex = 7;
            // 
            // labelHesapNo
            // 
            labelHesapNo.AutoSize = true;
            labelHesapNo.Location = new Point(54, 244);
            labelHesapNo.Name = "labelHesapNo";
            labelHesapNo.Size = new Size(87, 20);
            labelHesapNo.TabIndex = 8;
            labelHesapNo.Text = "HESAP NO :";
            // 
            // txtIban
            // 
            txtIban.Location = new Point(147, 204);
            txtIban.Name = "txtIban";
            txtIban.Size = new Size(297, 27);
            txtIban.TabIndex = 9;
            // 
            // labelIban
            // 
            labelIban.AutoSize = true;
            labelIban.Location = new Point(84, 211);
            labelIban.Name = "labelIban";
            labelIban.Size = new Size(50, 20);
            labelIban.TabIndex = 10;
            labelIban.Text = "IBAN :";
            // 
            // txtSube
            // 
            txtSube.Location = new Point(147, 171);
            txtSube.Name = "txtSube";
            txtSube.Size = new Size(297, 27);
            txtSube.TabIndex = 11;
            // 
            // labelSube
            // 
            labelSube.AutoSize = true;
            labelSube.Location = new Point(83, 178);
            labelSube.Name = "labelSube";
            labelSube.Size = new Size(51, 20);
            labelSube.TabIndex = 12;
            labelSube.Text = "ŞUBE :";
            // 
            // txtBankaAd
            // 
            txtBankaAd.Location = new Point(147, 138);
            txtBankaAd.Name = "txtBankaAd";
            txtBankaAd.Size = new Size(297, 27);
            txtBankaAd.TabIndex = 13;
            // 
            // labelBankaAd
            // 
            labelBankaAd.AutoSize = true;
            labelBankaAd.Location = new Point(47, 145);
            labelBankaAd.Name = "labelBankaAd";
            labelBankaAd.Size = new Size(94, 20);
            labelBankaAd.TabIndex = 14;
            labelBankaAd.Text = "BANKA ADI :";
            // 
            // txtId
            // 
            txtId.Location = new Point(147, 105);
            txtId.Name = "txtId";
            txtId.Size = new Size(297, 27);
            txtId.TabIndex = 15;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(93, 112);
            labelId.Name = "labelId";
            labelId.Size = new Size(31, 20);
            labelId.TabIndex = 16;
            labelId.Text = "ID :";
            // 
            // BANKALAR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "BANKALAR";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BANKALAR";
            Load += BANKALAR_Load;
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
        private System.Windows.Forms.TextBox txtBankaAd;
        private System.Windows.Forms.Label labelBankaAd;
        private System.Windows.Forms.TextBox txtSube;
        private System.Windows.Forms.Label labelSube;
        private System.Windows.Forms.TextBox txtIban;
        private System.Windows.Forms.Label labelIban;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Label labelHesapNo;
        private System.Windows.Forms.TextBox txtYetkili;
        private System.Windows.Forms.Label labelYetkili;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label labelTarih;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
    }
}
