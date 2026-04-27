namespace ŞİRKETOTOMASYONU
{
    partial class GIDERLER
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
            txtKira = new TextBox();
            labelKira = new Label();
            txtMaaslar = new TextBox();
            labelMaaslar = new Label();
            txtInternet = new TextBox();
            labelInternet = new Label();
            txtDogalgaz = new TextBox();
            labelDogalgaz = new Label();
            txtSu = new TextBox();
            labelSu = new Label();
            txtElektrik = new TextBox();
            labelElektrik = new Label();
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
            dataGridView1.Size = new Size(800, 600);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveBorder;
            groupBox1.Controls.Add(btnguncelle);
            groupBox1.Controls.Add(btnsil);
            groupBox1.Controls.Add(btnkaydet);
            groupBox1.Controls.Add(txtKira);
            groupBox1.Controls.Add(labelKira);
            groupBox1.Controls.Add(txtMaaslar);
            groupBox1.Controls.Add(labelMaaslar);
            groupBox1.Controls.Add(txtInternet);
            groupBox1.Controls.Add(labelInternet);
            groupBox1.Controls.Add(txtDogalgaz);
            groupBox1.Controls.Add(labelDogalgaz);
            groupBox1.Controls.Add(txtSu);
            groupBox1.Controls.Add(labelSu);
            groupBox1.Controls.Add(txtElektrik);
            groupBox1.Controls.Add(labelElektrik);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(labelId);
            groupBox1.Location = new Point(830, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 600);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "GİDER İŞLEMLERİ";
            // 
            // btnguncelle
            // 
            btnguncelle.BackColor = Color.YellowGreen;
            btnguncelle.Location = new Point(112, 512);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(250, 45);
            btnguncelle.TabIndex = 0;
            btnguncelle.Text = "GÜNCELLE";
            btnguncelle.UseVisualStyleBackColor = false;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.DarkRed;
            btnsil.ForeColor = Color.White;
            btnsil.Location = new Point(112, 451);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(250, 45);
            btnsil.TabIndex = 1;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // btnkaydet
            // 
            btnkaydet.BackColor = Color.DarkSalmon;
            btnkaydet.Location = new Point(112, 386);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(250, 45);
            btnkaydet.TabIndex = 2;
            btnkaydet.Text = "KAYDET";
            btnkaydet.UseVisualStyleBackColor = false;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // txtKira
            // 
            txtKira.Location = new Point(131, 302);
            txtKira.Name = "txtKira";
            txtKira.Size = new Size(313, 27);
            txtKira.TabIndex = 3;
            // 
            // labelKira
            // 
            labelKira.AutoSize = true;
            labelKira.Location = new Point(65, 309);
            labelKira.Name = "labelKira";
            labelKira.Size = new Size(48, 20);
            labelKira.TabIndex = 4;
            labelKira.Text = "KİRA :";
            // 
            // txtMaaslar
            // 
            txtMaaslar.Location = new Point(131, 255);
            txtMaaslar.Name = "txtMaaslar";
            txtMaaslar.Size = new Size(313, 27);
            txtMaaslar.TabIndex = 5;
            // 
            // labelMaaslar
            // 
            labelMaaslar.AutoSize = true;
            labelMaaslar.Location = new Point(30, 262);
            labelMaaslar.Name = "labelMaaslar";
            labelMaaslar.Size = new Size(83, 20);
            labelMaaslar.TabIndex = 6;
            labelMaaslar.Text = "MAAŞLAR :";
            // 
            // txtInternet
            // 
            txtInternet.Location = new Point(131, 213);
            txtInternet.Name = "txtInternet";
            txtInternet.Size = new Size(313, 27);
            txtInternet.TabIndex = 7;
            // 
            // labelInternet
            // 
            labelInternet.AutoSize = true;
            labelInternet.Location = new Point(30, 220);
            labelInternet.Name = "labelInternet";
            labelInternet.Size = new Size(83, 20);
            labelInternet.TabIndex = 8;
            labelInternet.Text = "İNTERNET :";
            // 
            // txtDogalgaz
            // 
            txtDogalgaz.Location = new Point(131, 171);
            txtDogalgaz.Name = "txtDogalgaz";
            txtDogalgaz.Size = new Size(313, 27);
            txtDogalgaz.TabIndex = 9;
            // 
            // labelDogalgaz
            // 
            labelDogalgaz.AutoSize = true;
            labelDogalgaz.Location = new Point(19, 178);
            labelDogalgaz.Name = "labelDogalgaz";
            labelDogalgaz.Size = new Size(94, 20);
            labelDogalgaz.TabIndex = 10;
            labelDogalgaz.Text = "DOĞALGAZ :";
            // 
            // txtSu
            // 
            txtSu.Location = new Point(131, 129);
            txtSu.Name = "txtSu";
            txtSu.Size = new Size(313, 27);
            txtSu.TabIndex = 11;
            // 
            // labelSu
            // 
            labelSu.AutoSize = true;
            labelSu.Location = new Point(74, 136);
            labelSu.Name = "labelSu";
            labelSu.Size = new Size(34, 20);
            labelSu.TabIndex = 12;
            labelSu.Text = "SU :";
            // 
            // txtElektrik
            // 
            txtElektrik.Location = new Point(131, 80);
            txtElektrik.Name = "txtElektrik";
            txtElektrik.Size = new Size(313, 27);
            txtElektrik.TabIndex = 13;
            // 
            // labelElektrik
            // 
            labelElektrik.AutoSize = true;
            labelElektrik.Location = new Point(35, 87);
            labelElektrik.Name = "labelElektrik";
            labelElektrik.Size = new Size(78, 20);
            labelElektrik.TabIndex = 14;
            labelElektrik.Text = "ELEKTRİK :";
            // 
            // txtId
            // 
            txtId.Location = new Point(131, 37);
            txtId.Name = "txtId";
            txtId.Size = new Size(313, 27);
            txtId.TabIndex = 15;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(77, 44);
            labelId.Name = "labelId";
            labelId.Size = new Size(31, 20);
            labelId.TabIndex = 16;
            labelId.Text = "ID :";
            // 
            // GIDERLER
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "GIDERLER";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GIDERLER";
            Load += GIDERLER_Load;
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
        private System.Windows.Forms.TextBox txtElektrik;
        private System.Windows.Forms.Label labelElektrik;
        private System.Windows.Forms.TextBox txtSu;
        private System.Windows.Forms.Label labelSu;
        private System.Windows.Forms.TextBox txtDogalgaz;
        private System.Windows.Forms.Label labelDogalgaz;
        private System.Windows.Forms.TextBox txtInternet;
        private System.Windows.Forms.Label labelInternet;
        private System.Windows.Forms.TextBox txtMaaslar;
        private System.Windows.Forms.Label labelMaaslar;
        private System.Windows.Forms.TextBox txtKira;
        private System.Windows.Forms.Label labelKira;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
    }
}
