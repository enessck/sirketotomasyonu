namespace ŞİRKETOTOMASYONU
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            anasayfaToolStripMenuItem = new ToolStripMenuItem();
            ürünlerToolStripMenuItem = new ToolStripMenuItem();
            stoklarToolStripMenuItem = new ToolStripMenuItem();
            müşterilerToolStripMenuItem = new ToolStripMenuItem();
            şirketlerToolStripMenuItem = new ToolStripMenuItem();
            personellerToolStripMenuItem = new ToolStripMenuItem();
            giderlerToolStripMenuItem = new ToolStripMenuItem();
            kasaToolStripMenuItem = new ToolStripMenuItem();
            bankalarToolStripMenuItem = new ToolStripMenuItem();
            faturalarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStrip1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            menuStrip1.ImageScalingSize = new Size(48, 48);
            menuStrip1.ImeMode = ImeMode.NoControl;
            menuStrip1.Items.AddRange(new ToolStripItem[] { anasayfaToolStripMenuItem, ürünlerToolStripMenuItem, stoklarToolStripMenuItem, müşterilerToolStripMenuItem, şirketlerToolStripMenuItem, personellerToolStripMenuItem, giderlerToolStripMenuItem, kasaToolStripMenuItem, bankalarToolStripMenuItem, faturalarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(200, 468);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // anasayfaToolStripMenuItem
            // 
            anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            anasayfaToolStripMenuItem.Size = new Size(164, 76);
            anasayfaToolStripMenuItem.Text = "Anasayfa";
            anasayfaToolStripMenuItem.Click += anasayfaToolStripMenuItem_Click;
            // 
            // ürünlerToolStripMenuItem
            // 
            ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            ürünlerToolStripMenuItem.Size = new Size(152, 76);
            ürünlerToolStripMenuItem.Text = "Ürünler";
            ürünlerToolStripMenuItem.Click += ürünlerToolStripMenuItem_Click;
            // 
            // stoklarToolStripMenuItem
            // 
            stoklarToolStripMenuItem.Name = "stoklarToolStripMenuItem";
            stoklarToolStripMenuItem.Size = new Size(140, 76);
            stoklarToolStripMenuItem.Text = "Stoklar";
            stoklarToolStripMenuItem.Click += stoklarToolStripMenuItem_Click;
            // 
            // müşterilerToolStripMenuItem
            // 
            müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            müşterilerToolStripMenuItem.Size = new Size(173, 76);
            müşterilerToolStripMenuItem.Text = "Müşteriler";
            müşterilerToolStripMenuItem.Click += müşterilerToolStripMenuItem_Click;
            // 
            // şirketlerToolStripMenuItem
            // 
            şirketlerToolStripMenuItem.Name = "şirketlerToolStripMenuItem";
            şirketlerToolStripMenuItem.Size = new Size(158, 76);
            şirketlerToolStripMenuItem.Text = "Şirketler";
            şirketlerToolStripMenuItem.Click += şirketlerToolStripMenuItem_Click;
            // 
            // personellerToolStripMenuItem
            // 
            personellerToolStripMenuItem.Name = "personellerToolStripMenuItem";
            personellerToolStripMenuItem.Size = new Size(190, 76);
            personellerToolStripMenuItem.Text = "Personeller ";
            personellerToolStripMenuItem.Click += personellerToolStripMenuItem_Click;
            // 
            // giderlerToolStripMenuItem
            // 
            giderlerToolStripMenuItem.Name = "giderlerToolStripMenuItem";
            giderlerToolStripMenuItem.Size = new Size(154, 76);
            giderlerToolStripMenuItem.Text = "Giderler";
            giderlerToolStripMenuItem.Click += giderlerToolStripMenuItem_Click;
            // 
            // kasaToolStripMenuItem
            // 
            kasaToolStripMenuItem.Name = "kasaToolStripMenuItem";
            kasaToolStripMenuItem.Size = new Size(127, 76);
            kasaToolStripMenuItem.Text = "Kasa";
            kasaToolStripMenuItem.Click += kasaToolStripMenuItem_Click;
            // 
            // bankalarToolStripMenuItem
            // 
            bankalarToolStripMenuItem.Name = "bankalarToolStripMenuItem";
            bankalarToolStripMenuItem.Size = new Size(162, 76);
            bankalarToolStripMenuItem.Text = "Bankalar";
            bankalarToolStripMenuItem.Click += bankalarToolStripMenuItem_Click;
            // 
            // faturalarToolStripMenuItem
            // 
            faturalarToolStripMenuItem.Name = "faturalarToolStripMenuItem";
            faturalarToolStripMenuItem.Size = new Size(158, 76);
            faturalarToolStripMenuItem.Text = "Faturalar";
            faturalarToolStripMenuItem.Click += faturalarToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 468);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem anasayfaToolStripMenuItem;
        private ToolStripMenuItem ürünlerToolStripMenuItem;
        private ToolStripMenuItem stoklarToolStripMenuItem;
        private ToolStripMenuItem müşterilerToolStripMenuItem;
        private ToolStripMenuItem şirketlerToolStripMenuItem;
        private ToolStripMenuItem personellerToolStripMenuItem;
        private ToolStripMenuItem giderlerToolStripMenuItem;
        private ToolStripMenuItem kasaToolStripMenuItem;
        private ToolStripMenuItem bankalarToolStripMenuItem;
        private ToolStripMenuItem faturalarToolStripMenuItem;
    }
}
