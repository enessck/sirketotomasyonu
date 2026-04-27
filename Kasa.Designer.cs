namespace ŞİRKETOTOMASYONU
{
    partial class KASA
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
            btnsil = new Button();
            btnkaydet = new Button();
            txtAciklama = new RichTextBox();
            labelAciklama = new Label();
            txtTutar = new TextBox();
            labelTutar = new Label();
            cmbIslemTuru = new ComboBox();
            labelIslemTuru = new Label();
            txtId = new TextBox();
            labelId = new Label();
            grpOzet = new GroupBox();
            lblBakiyeBaslik = new Label();
            lblBakiye = new Label();
            lblGiderBaslik = new Label();
            lblToplamGider = new Label();
            lblGelirBaslik = new Label();
            lblToplamGelir = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            grpOzet.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(750, 550);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnsil);
            groupBox1.Controls.Add(btnkaydet);
            groupBox1.Controls.Add(txtAciklama);
            groupBox1.Controls.Add(labelAciklama);
            groupBox1.Controls.Add(txtTutar);
            groupBox1.Controls.Add(labelTutar);
            groupBox1.Controls.Add(cmbIslemTuru);
            groupBox1.Controls.Add(labelIslemTuru);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(labelId);
            groupBox1.Location = new Point(780, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 370);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "KASA İŞLEMLERİ";
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.SaddleBrown;
            btnsil.ForeColor = Color.White;
            btnsil.Location = new Point(97, 319);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(250, 45);
            btnsil.TabIndex = 0;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // btnkaydet
            // 
            btnkaydet.BackColor = SystemColors.ActiveCaption;
            btnkaydet.Location = new Point(97, 255);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(250, 45);
            btnkaydet.TabIndex = 1;
            btnkaydet.Text = "KAYDET";
            btnkaydet.UseVisualStyleBackColor = false;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(148, 174);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(296, 60);
            txtAciklama.TabIndex = 2;
            txtAciklama.Text = "";
            // 
            // labelAciklama
            // 
            labelAciklama.AutoSize = true;
            labelAciklama.ForeColor = Color.FromArgb(192, 192, 0);
            labelAciklama.Location = new Point(51, 192);
            labelAciklama.Name = "labelAciklama";
            labelAciklama.Size = new Size(88, 20);
            labelAciklama.TabIndex = 3;
            labelAciklama.Text = "AÇIKLAMA :";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(148, 127);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(296, 27);
            txtTutar.TabIndex = 4;
            // 
            // labelTutar
            // 
            labelTutar.AutoSize = true;
            labelTutar.ForeColor = Color.FromArgb(192, 192, 0);
            labelTutar.Location = new Point(51, 134);
            labelTutar.Name = "labelTutar";
            labelTutar.Size = new Size(82, 20);
            labelTutar.TabIndex = 5;
            labelTutar.Text = "TUTAR (₺) :";
            // 
            // cmbIslemTuru
            // 
            cmbIslemTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIslemTuru.FormattingEnabled = true;
            cmbIslemTuru.Location = new Point(148, 80);
            cmbIslemTuru.Name = "cmbIslemTuru";
            cmbIslemTuru.Size = new Size(296, 28);
            cmbIslemTuru.TabIndex = 6;
            // 
            // labelIslemTuru
            // 
            labelIslemTuru.AutoSize = true;
            labelIslemTuru.ForeColor = Color.FromArgb(192, 192, 0);
            labelIslemTuru.Location = new Point(45, 88);
            labelIslemTuru.Name = "labelIslemTuru";
            labelIslemTuru.Size = new Size(97, 20);
            labelIslemTuru.TabIndex = 7;
            labelIslemTuru.Text = "İŞLEM TÜRÜ :";
            // 
            // txtId
            // 
            txtId.Location = new Point(148, 43);
            txtId.Name = "txtId";
            txtId.Size = new Size(296, 27);
            txtId.TabIndex = 8;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.ForeColor = Color.FromArgb(192, 192, 0);
            labelId.Location = new Point(102, 46);
            labelId.Name = "labelId";
            labelId.Size = new Size(31, 20);
            labelId.TabIndex = 9;
            labelId.Text = "ID :";
            // 
            // grpOzet
            // 
            grpOzet.BackColor = Color.WhiteSmoke;
            grpOzet.Controls.Add(lblBakiyeBaslik);
            grpOzet.Controls.Add(lblBakiye);
            grpOzet.Controls.Add(lblGiderBaslik);
            grpOzet.Controls.Add(lblToplamGider);
            grpOzet.Controls.Add(lblGelirBaslik);
            grpOzet.Controls.Add(lblToplamGelir);
            grpOzet.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            grpOzet.Location = new Point(788, 382);
            grpOzet.Name = "grpOzet";
            grpOzet.Size = new Size(450, 206);
            grpOzet.TabIndex = 2;
            grpOzet.TabStop = false;
            grpOzet.Text = "KASA ÖZETİ";
            // 
            // lblBakiyeBaslik
            // 
            lblBakiyeBaslik.AutoSize = true;
            lblBakiyeBaslik.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBakiyeBaslik.ForeColor = Color.Blue;
            lblBakiyeBaslik.Location = new Point(100, 148);
            lblBakiyeBaslik.Name = "lblBakiyeBaslik";
            lblBakiyeBaslik.Size = new Size(112, 32);
            lblBakiyeBaslik.TabIndex = 0;
            lblBakiyeBaslik.Text = "BAKİYE :";
            // 
            // lblBakiye
            // 
            lblBakiye.AutoSize = true;
            lblBakiye.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBakiye.ForeColor = Color.Navy;
            lblBakiye.Location = new Point(218, 148);
            lblBakiye.Name = "lblBakiye";
            lblBakiye.Size = new Size(84, 32);
            lblBakiye.TabIndex = 1;
            lblBakiye.Text = "0,00 ₺";
            // 
            // lblGiderBaslik
            // 
            lblGiderBaslik.AutoSize = true;
            lblGiderBaslik.ForeColor = Color.FromArgb(192, 0, 0);
            lblGiderBaslik.Location = new Point(15, 88);
            lblGiderBaslik.Name = "lblGiderBaslik";
            lblGiderBaslik.Size = new Size(156, 25);
            lblGiderBaslik.TabIndex = 2;
            lblGiderBaslik.Text = "TOPLAM GİDER :";
            // 
            // lblToplamGider
            // 
            lblToplamGider.AutoSize = true;
            lblToplamGider.ForeColor = Color.Maroon;
            lblToplamGider.Location = new Point(177, 88);
            lblToplamGider.Name = "lblToplamGider";
            lblToplamGider.Size = new Size(66, 25);
            lblToplamGider.TabIndex = 3;
            lblToplamGider.Text = "0,00 ₺";
            // 
            // lblGelirBaslik
            // 
            lblGelirBaslik.AutoSize = true;
            lblGelirBaslik.ForeColor = Color.FromArgb(0, 192, 0);
            lblGelirBaslik.Location = new Point(20, 35);
            lblGelirBaslik.Name = "lblGelirBaslik";
            lblGelirBaslik.Size = new Size(151, 25);
            lblGelirBaslik.TabIndex = 4;
            lblGelirBaslik.Text = "TOPLAM GELİR :";
            // 
            // lblToplamGelir
            // 
            lblToplamGelir.AutoSize = true;
            lblToplamGelir.ForeColor = Color.FromArgb(0, 192, 0);
            lblToplamGelir.Location = new Point(177, 35);
            lblToplamGelir.Name = "lblToplamGelir";
            lblToplamGelir.Size = new Size(66, 25);
            lblToplamGelir.TabIndex = 5;
            lblToplamGelir.Text = "0,00 ₺";
            // 
            // KASA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 600);
            Controls.Add(grpOzet);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "KASA";
            StartPosition = FormStartPosition.CenterParent;
            Text = "KASA";
            Load += KASA_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpOzet.ResumeLayout(false);
            grpOzet.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.ComboBox cmbIslemTuru;
        private System.Windows.Forms.Label labelIslemTuru;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label labelTutar;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.Label labelAciklama;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.GroupBox grpOzet;
        private System.Windows.Forms.Label lblGelirBaslik;
        private System.Windows.Forms.Label lblToplamGelir;
        private System.Windows.Forms.Label lblGiderBaslik;
        private System.Windows.Forms.Label lblToplamGider;
        private System.Windows.Forms.Label lblBakiyeBaslik;
        private System.Windows.Forms.Label lblBakiye;
    }
}
