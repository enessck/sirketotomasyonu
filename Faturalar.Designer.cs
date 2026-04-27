namespace ŞİRKETOTOMASYONU
{
    partial class FATURALAR
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            btnguncelle = new Button();
            btnsil = new Button();
            btnkaydet = new Button();
            txtTeslimAlan = new TextBox();
            labelTeslimAlan = new Label();
            txtTeslimEden = new TextBox();
            labelTeslimEden = new Label();
            txtAlici = new TextBox();
            labelAlici = new Label();
            txtVergiDairesi = new TextBox();
            labelVergiDairesi = new Label();
            txtSaat = new TextBox();
            labelSaat = new Label();
            txtTarih = new TextBox();
            labelTarih = new Label();
            txtSiraNo = new TextBox();
            labelSiraNo = new Label();
            txtSeri = new TextBox();
            labelSeri = new Label();
            txtFaturaId = new TextBox();
            labelFaturaId = new Label();
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
            groupBox1.BackColor = SystemColors.WindowFrame;
            groupBox1.Controls.Add(btnguncelle);
            groupBox1.Controls.Add(btnsil);
            groupBox1.Controls.Add(btnkaydet);
            groupBox1.Controls.Add(txtTeslimAlan);
            groupBox1.Controls.Add(labelTeslimAlan);
            groupBox1.Controls.Add(txtTeslimEden);
            groupBox1.Controls.Add(labelTeslimEden);
            groupBox1.Controls.Add(txtAlici);
            groupBox1.Controls.Add(labelAlici);
            groupBox1.Controls.Add(txtVergiDairesi);
            groupBox1.Controls.Add(labelVergiDairesi);
            groupBox1.Controls.Add(txtSaat);
            groupBox1.Controls.Add(labelSaat);
            groupBox1.Controls.Add(txtTarih);
            groupBox1.Controls.Add(labelTarih);
            groupBox1.Controls.Add(txtSiraNo);
            groupBox1.Controls.Add(labelSiraNo);
            groupBox1.Controls.Add(txtSeri);
            groupBox1.Controls.Add(labelSeri);
            groupBox1.Controls.Add(txtFaturaId);
            groupBox1.Controls.Add(labelFaturaId);
            groupBox1.Location = new Point(868, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 700);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "FATURA İŞLEMLERİ";
            // 
            // btnguncelle
            // 
            btnguncelle.BackColor = SystemColors.MenuHighlight;
            btnguncelle.Location = new Point(124, 539);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(240, 45);
            btnguncelle.TabIndex = 0;
            btnguncelle.Text = "GÜNCELLE";
            btnguncelle.UseVisualStyleBackColor = false;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.Maroon;
            btnsil.ForeColor = Color.White;
            btnsil.Location = new Point(124, 478);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(240, 45);
            btnsil.TabIndex = 1;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // btnkaydet
            // 
            btnkaydet.BackColor = SystemColors.ActiveCaption;
            btnkaydet.Location = new Point(124, 416);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(240, 45);
            btnkaydet.TabIndex = 2;
            btnkaydet.Text = "KAYDET";
            btnkaydet.UseVisualStyleBackColor = false;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // txtTeslimAlan
            // 
            txtTeslimAlan.Location = new Point(161, 360);
            txtTeslimAlan.Name = "txtTeslimAlan";
            txtTeslimAlan.Size = new Size(314, 27);
            txtTeslimAlan.TabIndex = 3;
            // 
            // labelTeslimAlan
            // 
            labelTeslimAlan.AutoSize = true;
            labelTeslimAlan.Location = new Point(38, 367);
            labelTeslimAlan.Name = "labelTeslimAlan";
            labelTeslimAlan.Size = new Size(106, 20);
            labelTeslimAlan.TabIndex = 4;
            labelTeslimAlan.Text = "TESLİM ALAN :";
            // 
            // txtTeslimEden
            // 
            txtTeslimEden.Location = new Point(161, 320);
            txtTeslimEden.Name = "txtTeslimEden";
            txtTeslimEden.Size = new Size(314, 27);
            txtTeslimEden.TabIndex = 5;
            // 
            // labelTeslimEden
            // 
            labelTeslimEden.AutoSize = true;
            labelTeslimEden.Location = new Point(38, 327);
            labelTeslimEden.Name = "labelTeslimEden";
            labelTeslimEden.Size = new Size(106, 20);
            labelTeslimEden.TabIndex = 6;
            labelTeslimEden.Text = "TESLİM EDEN :";
            // 
            // txtAlici
            // 
            txtAlici.Location = new Point(161, 277);
            txtAlici.Name = "txtAlici";
            txtAlici.Size = new Size(314, 27);
            txtAlici.TabIndex = 7;
            // 
            // labelAlici
            // 
            labelAlici.AutoSize = true;
            labelAlici.Location = new Point(88, 284);
            labelAlici.Name = "labelAlici";
            labelAlici.Size = new Size(50, 20);
            labelAlici.TabIndex = 8;
            labelAlici.Text = "ALICI :";
            // 
            // txtVergiDairesi
            // 
            txtVergiDairesi.Location = new Point(161, 237);
            txtVergiDairesi.Name = "txtVergiDairesi";
            txtVergiDairesi.Size = new Size(314, 27);
            txtVergiDairesi.TabIndex = 9;
            // 
            // labelVergiDairesi
            // 
            labelVergiDairesi.AutoSize = true;
            labelVergiDairesi.Location = new Point(38, 244);
            labelVergiDairesi.Name = "labelVergiDairesi";
            labelVergiDairesi.Size = new Size(114, 20);
            labelVergiDairesi.TabIndex = 10;
            labelVergiDairesi.Text = "VERGİ DAİRESİ :";
            // 
            // txtSaat
            // 
            txtSaat.Location = new Point(161, 197);
            txtSaat.Name = "txtSaat";
            txtSaat.Size = new Size(314, 27);
            txtSaat.TabIndex = 11;
            // 
            // labelSaat
            // 
            labelSaat.AutoSize = true;
            labelSaat.Location = new Point(93, 204);
            labelSaat.Name = "labelSaat";
            labelSaat.Size = new Size(51, 20);
            labelSaat.TabIndex = 12;
            labelSaat.Text = "SAAT :";
            // 
            // txtTarih
            // 
            txtTarih.Location = new Point(161, 157);
            txtTarih.Name = "txtTarih";
            txtTarih.Size = new Size(314, 27);
            txtTarih.TabIndex = 13;
            // 
            // labelTarih
            // 
            labelTarih.AutoSize = true;
            labelTarih.Location = new Point(81, 164);
            labelTarih.Name = "labelTarih";
            labelTarih.Size = new Size(57, 20);
            labelTarih.TabIndex = 14;
            labelTarih.Text = "TARİH :";
            // 
            // txtSiraNo
            // 
            txtSiraNo.Location = new Point(161, 120);
            txtSiraNo.Name = "txtSiraNo";
            txtSiraNo.Size = new Size(314, 27);
            txtSiraNo.TabIndex = 15;
            // 
            // labelSiraNo
            // 
            labelSiraNo.AutoSize = true;
            labelSiraNo.Location = new Point(71, 127);
            labelSiraNo.Name = "labelSiraNo";
            labelSiraNo.Size = new Size(73, 20);
            labelSiraNo.TabIndex = 16;
            labelSiraNo.Text = "SIRA NO :";
            // 
            // txtSeri
            // 
            txtSeri.Location = new Point(161, 80);
            txtSeri.Name = "txtSeri";
            txtSeri.Size = new Size(314, 27);
            txtSeri.TabIndex = 17;
            // 
            // labelSeri
            // 
            labelSeri.AutoSize = true;
            labelSeri.Location = new Point(93, 87);
            labelSeri.Name = "labelSeri";
            labelSeri.Size = new Size(45, 20);
            labelSeri.TabIndex = 18;
            labelSeri.Text = "SERİ :";
            // 
            // txtFaturaId
            // 
            txtFaturaId.Location = new Point(161, 40);
            txtFaturaId.Name = "txtFaturaId";
            txtFaturaId.Size = new Size(314, 27);
            txtFaturaId.TabIndex = 19;
            // 
            // labelFaturaId
            // 
            labelFaturaId.AutoSize = true;
            labelFaturaId.Location = new Point(57, 47);
            labelFaturaId.Name = "labelFaturaId";
            labelFaturaId.Size = new Size(87, 20);
            labelFaturaId.TabIndex = 20;
            labelFaturaId.Text = "FATURA ID :";
            // 
            // FATURALAR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 750);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "FATURALAR";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FATURALAR";
            Load += FATURALAR_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFaturaId;
        private System.Windows.Forms.Label labelFaturaId;
        private System.Windows.Forms.TextBox txtSeri;
        private System.Windows.Forms.Label labelSeri;
        private System.Windows.Forms.TextBox txtSiraNo;
        private System.Windows.Forms.Label labelSiraNo;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label labelTarih;
        private System.Windows.Forms.TextBox txtSaat;
        private System.Windows.Forms.Label labelSaat;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.Label labelVergiDairesi;
        private System.Windows.Forms.TextBox txtAlici;
        private System.Windows.Forms.Label labelAlici;
        private System.Windows.Forms.TextBox txtTeslimEden;
        private System.Windows.Forms.Label labelTeslimEden;
        private System.Windows.Forms.TextBox txtTeslimAlan;
        private System.Windows.Forms.Label labelTeslimAlan;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
    }
}
