namespace ŞİRKETOTOMASYONU
{
    partial class STOKLAR
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
            txtAdet = new TextBox();
            labelAdet = new Label();
            txtTur = new TextBox();
            labelTur = new Label();
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
            dataGridView1.Size = new Size(770, 600);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MediumPurple;
            groupBox1.Controls.Add(btnguncelle);
            groupBox1.Controls.Add(btnsil);
            groupBox1.Controls.Add(btnkaydet);
            groupBox1.Controls.Add(txtAdet);
            groupBox1.Controls.Add(labelAdet);
            groupBox1.Controls.Add(txtTur);
            groupBox1.Controls.Add(labelTur);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(labelId);
            groupBox1.Location = new Point(788, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(588, 620);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "STOK İŞLEMLERİ";
            // 
            // btnguncelle
            // 
            btnguncelle.BackColor = Color.RoyalBlue;
            btnguncelle.Location = new Point(11, 513);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(200, 50);
            btnguncelle.TabIndex = 8;
            btnguncelle.Text = "GÜNCELLE";
            btnguncelle.UseVisualStyleBackColor = false;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.Red;
            btnsil.ForeColor = Color.White;
            btnsil.Location = new Point(6, 395);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(200, 50);
            btnsil.TabIndex = 7;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // btnkaydet
            // 
            btnkaydet.BackColor = Color.SeaGreen;
            btnkaydet.Location = new Point(6, 294);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(200, 50);
            btnkaydet.TabIndex = 6;
            btnkaydet.Text = "KAYDET";
            btnkaydet.UseVisualStyleBackColor = false;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // txtAdet
            // 
            txtAdet.Location = new Point(227, 168);
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(304, 27);
            txtAdet.TabIndex = 5;
            // 
            // labelAdet
            // 
            labelAdet.AutoSize = true;
            labelAdet.ForeColor = Color.FromArgb(64, 0, 0);
            labelAdet.Location = new Point(122, 175);
            labelAdet.Name = "labelAdet";
            labelAdet.Size = new Size(99, 20);
            labelAdet.TabIndex = 4;
            labelAdet.Text = "STOK ADEDİ :";
            // 
            // txtTur
            // 
            txtTur.Location = new Point(227, 123);
            txtTur.Name = "txtTur";
            txtTur.Size = new Size(304, 27);
            txtTur.TabIndex = 3;
            // 
            // labelTur
            // 
            labelTur.AutoSize = true;
            labelTur.ForeColor = Color.FromArgb(64, 0, 0);
            labelTur.Location = new Point(122, 130);
            labelTur.Name = "labelTur";
            labelTur.Size = new Size(92, 20);
            labelTur.TabIndex = 2;
            labelTur.Text = "STOK TÜRÜ :";
            // 
            // txtId
            // 
            txtId.Location = new Point(227, 72);
            txtId.Name = "txtId";
            txtId.Size = new Size(304, 27);
            txtId.TabIndex = 1;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.ForeColor = Color.FromArgb(64, 0, 0);
            labelId.Location = new Point(180, 79);
            labelId.Name = "labelId";
            labelId.Size = new Size(31, 20);
            labelId.TabIndex = 0;
            labelId.Text = "ID :";
            labelId.Click += labelId_Click;
            // 
            // STOKLAR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 630);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "STOKLAR";
            StartPosition = FormStartPosition.CenterParent;
            Text = "STOKLAR";
            Load += STOKLAR_Load;
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
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.Label labelTur;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label labelAdet;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
    }
}