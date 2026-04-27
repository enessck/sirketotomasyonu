namespace ŞİRKETOTOMASYONU
{
    partial class ÜRÜNLER
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
            button2 = new Button();
            button1 = new Button();
            btnkaydet = new Button();
            txtsatısfıyat = new TextBox();
            txtalısfıyat = new TextBox();
            label8 = new Label();
            label7 = new Label();
            numericadet = new NumericUpDown();
            label6 = new Label();
            label2 = new Label();
            maskedtxtyıl = new MaskedTextBox();
            txtad = new TextBox();
            label5 = new Label();
            txtmarka = new TextBox();
            label4 = new Label();
            txtmodel = new TextBox();
            label3 = new Label();
            txtıd = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericadet).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-5, -5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(814, 636);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DimGray;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnkaydet);
            groupBox1.Controls.Add(txtsatısfıyat);
            groupBox1.Controls.Add(txtalısfıyat);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(numericadet);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(maskedtxtyıl);
            groupBox1.Controls.Add(txtad);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtmarka);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtmodel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtıd);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(805, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(587, 619);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "ÜRÜN EKLE";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(200, 534);
            button2.Name = "button2";
            button2.Size = new Size(216, 51);
            button2.TabIndex = 20;
            button2.Text = "GÜNCELLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(200, 473);
            button1.Name = "button1";
            button1.Size = new Size(218, 55);
            button1.TabIndex = 19;
            button1.Text = "SİL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btnkaydet
            // 
            btnkaydet.BackColor = SystemColors.GradientActiveCaption;
            btnkaydet.Location = new Point(201, 412);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(217, 55);
            btnkaydet.TabIndex = 18;
            btnkaydet.Text = "KAYDET";
            btnkaydet.UseVisualStyleBackColor = false;
            btnkaydet.Click += button1_Click;
            // 
            // txtsatısfıyat
            // 
            txtsatısfıyat.Location = new Point(269, 375);
            txtsatısfıyat.Name = "txtsatısfıyat";
            txtsatısfıyat.Size = new Size(290, 27);
            txtsatısfıyat.TabIndex = 17;
            // 
            // txtalısfıyat
            // 
            txtalısfıyat.Location = new Point(269, 323);
            txtalısfıyat.Name = "txtalısfıyat";
            txtalısfıyat.Size = new Size(290, 27);
            txtalısfıyat.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.ForeColor = SystemColors.ActiveCaption;
            label8.Location = new Point(126, 375);
            label8.Name = "label8";
            label8.Size = new Size(126, 28);
            label8.TabIndex = 15;
            label8.Text = "SATIŞ FİYATI :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = SystemColors.ActiveCaption;
            label7.Location = new Point(135, 323);
            label7.Name = "label7";
            label7.Size = new Size(115, 28);
            label7.TabIndex = 14;
            label7.Text = "ALIŞ FİYATI :";
            // 
            // numericadet
            // 
            numericadet.Location = new Point(269, 276);
            numericadet.Name = "numericadet";
            numericadet.Size = new Size(291, 27);
            numericadet.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(182, 276);
            label6.Name = "label6";
            label6.Size = new Size(68, 28);
            label6.TabIndex = 12;
            label6.Text = "ADET :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(200, 226);
            label2.Name = "label2";
            label2.Size = new Size(46, 28);
            label2.TabIndex = 11;
            label2.Text = "YIL :";
            // 
            // maskedtxtyıl
            // 
            maskedtxtyıl.Location = new Point(269, 226);
            maskedtxtyıl.Mask = "0000";
            maskedtxtyıl.Name = "maskedtxtyıl";
            maskedtxtyıl.Size = new Size(291, 27);
            maskedtxtyıl.TabIndex = 10;
            maskedtxtyıl.ValidatingType = typeof(int);
            // 
            // txtad
            // 
            txtad.Location = new Point(269, 87);
            txtad.Name = "txtad";
            txtad.Size = new Size(291, 27);
            txtad.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(139, 87);
            label5.Name = "label5";
            label5.Size = new Size(113, 28);
            label5.TabIndex = 8;
            label5.Text = "ÜRÜN ADI :";
            // 
            // txtmarka
            // 
            txtmarka.Location = new Point(269, 131);
            txtmarka.Name = "txtmarka";
            txtmarka.Size = new Size(291, 27);
            txtmarka.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(163, 131);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 6;
            label4.Text = "MARKA :";
            // 
            // txtmodel
            // 
            txtmodel.Location = new Point(269, 176);
            txtmodel.Name = "txtmodel";
            txtmodel.Size = new Size(291, 27);
            txtmodel.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(163, 176);
            label3.Name = "label3";
            label3.Size = new Size(87, 28);
            label3.TabIndex = 4;
            label3.Text = "MODEL :";
            // 
            // txtıd
            // 
            txtıd.Location = new Point(269, 43);
            txtıd.Name = "txtıd";
            txtıd.Size = new Size(291, 27);
            txtıd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(212, 43);
            label1.Name = "label1";
            label1.Size = new Size(40, 28);
            label1.TabIndex = 0;
            label1.Text = "ID :";
            // 
            // ÜRÜNLER
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1391, 633);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "ÜRÜNLER";
            Text = "ÜRÜNLER";
            Load += ÜRÜNLER_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericadet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private MaskedTextBox maskedtxtyıl;
        private TextBox txtad;
        private Label label5;
        private TextBox txtmarka;
        private Label label4;
        private TextBox txtmodel;
        private Label label3;
        private TextBox txtıd;
        private Label label1;
        private Button btnkaydet;
        private TextBox txtsatısfıyat;
        private TextBox txtalısfıyat;
        private Label label8;
        private Label label7;
        private NumericUpDown numericadet;
        private Label label6;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}