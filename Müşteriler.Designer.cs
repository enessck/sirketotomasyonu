namespace ŞİRKETOTOMASYONU
{
    partial class MÜŞTERİLER
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            txtadres = new RichTextBox();
            label9 = new Label();
            label10 = new Label();
            cbilçe = new ComboBox();
            cbil = new ComboBox();
            txtmail = new TextBox();
            maskedtelno = new MaskedTextBox();
            btngüncelle = new Button();
            btnsil = new Button();
            btnkaydet = new Button();
            txtvergid = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            maskedtc = new MaskedTextBox();
            txtad = new TextBox();
            label5 = new Label();
            txtsoyad = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtıd = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, -1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(815, 635);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(txtadres);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cbilçe);
            groupBox1.Controls.Add(cbil);
            groupBox1.Controls.Add(txtmail);
            groupBox1.Controls.Add(maskedtelno);
            groupBox1.Controls.Add(btngüncelle);
            groupBox1.Controls.Add(btnsil);
            groupBox1.Controls.Add(btnkaydet);
            groupBox1.Controls.Add(txtvergid);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(maskedtc);
            groupBox1.Controls.Add(txtad);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtsoyad);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtıd);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(813, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(587, 619);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "ÜRÜN EKLE";
            // 
            // txtadres
            // 
            txtadres.Location = new Point(261, 366);
            txtadres.Name = "txtadres";
            txtadres.Size = new Size(284, 83);
            txtadres.TabIndex = 27;
            txtadres.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(96, 463);
            label9.Name = "label9";
            label9.Size = new Size(149, 28);
            label9.TabIndex = 26;
            label9.Text = "VERGİ DAİRESİ :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.ForeColor = SystemColors.HotTrack;
            label10.Location = new Point(166, 366);
            label10.Name = "label10";
            label10.Size = new Size(81, 28);
            label10.TabIndex = 25;
            label10.Text = "ADRES :";
            // 
            // cbilçe
            // 
            cbilçe.FormattingEnabled = true;
            cbilçe.Location = new Point(261, 316);
            cbilçe.Name = "cbilçe";
            cbilçe.Size = new Size(284, 28);
            cbilçe.TabIndex = 24;
            // 
            // cbil
            // 
            cbil.FormattingEnabled = true;
            cbil.Location = new Point(261, 274);
            cbil.Name = "cbil";
            cbil.Size = new Size(284, 28);
            cbil.TabIndex = 23;
            cbil.SelectedIndexChanged += cbil_SelectedIndexChanged;
            // 
            // txtmail
            // 
            txtmail.Location = new Point(261, 232);
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(284, 27);
            txtmail.TabIndex = 22;
            // 
            // maskedtelno
            // 
            maskedtelno.Location = new Point(261, 146);
            maskedtelno.Mask = "(999) 000-0000";
            maskedtelno.Name = "maskedtelno";
            maskedtelno.Size = new Size(284, 27);
            maskedtelno.TabIndex = 21;
            // 
            // btngüncelle
            // 
            btngüncelle.BackColor = Color.FromArgb(128, 128, 255);
            btngüncelle.Location = new Point(39, 576);
            btngüncelle.Name = "btngüncelle";
            btngüncelle.Size = new Size(152, 32);
            btngüncelle.TabIndex = 20;
            btngüncelle.Text = "GÜNCELLE";
            btngüncelle.UseVisualStyleBackColor = false;
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.Maroon;
            btnsil.Location = new Point(215, 574);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(154, 34);
            btnsil.TabIndex = 19;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // btnkaydet
            // 
            btnkaydet.BackColor = SystemColors.ActiveCaption;
            btnkaydet.Location = new Point(393, 572);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(173, 34);
            btnkaydet.TabIndex = 18;
            btnkaydet.Text = "KAYDET";
            btnkaydet.UseVisualStyleBackColor = false;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // txtvergid
            // 
            txtvergid.Location = new Point(261, 463);
            txtvergid.Name = "txtvergid";
            txtvergid.Size = new Size(287, 27);
            txtvergid.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(189, 316);
            label8.Name = "label8";
            label8.Size = new Size(56, 28);
            label8.TabIndex = 15;
            label8.Text = "İLÇE :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(212, 274);
            label7.Name = "label7";
            label7.Size = new Size(35, 28);
            label7.TabIndex = 14;
            label7.Text = "İL :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(189, 232);
            label6.Name = "label6";
            label6.Size = new Size(66, 28);
            label6.TabIndex = 12;
            label6.Text = "MAİL :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(205, 187);
            label2.Name = "label2";
            label2.Size = new Size(42, 28);
            label2.TabIndex = 11;
            label2.Text = "TC :";
            // 
            // maskedtc
            // 
            maskedtc.Location = new Point(261, 187);
            maskedtc.Mask = "00000000000";
            maskedtc.Name = "maskedtc";
            maskedtc.Size = new Size(284, 27);
            maskedtc.TabIndex = 10;
            maskedtc.ValidatingType = typeof(int);
            // 
            // txtad
            // 
            txtad.Location = new Point(261, 54);
            txtad.Name = "txtad";
            txtad.Size = new Size(284, 27);
            txtad.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(202, 54);
            label5.Name = "label5";
            label5.Size = new Size(53, 28);
            label5.TabIndex = 8;
            label5.Text = " AD :";
            // 
            // txtsoyad
            // 
            txtsoyad.Location = new Point(261, 97);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(284, 27);
            txtsoyad.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(172, 97);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 6;
            label4.Text = "SOYAD :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(155, 146);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 4;
            label3.Text = "TELEFON :";
            // 
            // txtıd
            // 
            txtıd.Location = new Point(261, 18);
            txtıd.Name = "txtıd";
            txtıd.Size = new Size(284, 27);
            txtıd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(215, 18);
            label1.Name = "label1";
            label1.Size = new Size(40, 28);
            label1.TabIndex = 0;
            label1.Text = "ID :";
            // 
            // MÜŞTERİLER
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1391, 633);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "MÜŞTERİLER";
            Text = "MÜŞTERİLER";
            Load += MÜŞTERİLER_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btngüncelle;
        private Button btnsil;
        private Button btnkaydet;
        private TextBox txtvergid;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label2;
        private MaskedTextBox maskedtc;
        private TextBox txtad;
        private Label label5;
        private TextBox txtsoyad;
        private Label label4;
        private Label label3;
        private TextBox txtıd;
        private Label label1;
        private TextBox txtmail;
        private MaskedTextBox maskedtelno;
        private RichTextBox txtadres;
        private Label label9;
        private Label label10;
        private ComboBox cbilçe;
        private ComboBox cbil;
    }
}