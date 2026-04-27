namespace ŞİRKETOTOMASYONU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string iconDir = System.IO.Path.Combine(Application.StartupPath, "icons");
            if (!System.IO.Directory.Exists(iconDir))
            {
                System.IO.Directory.CreateDirectory(iconDir);
            }

            var icons = new System.Collections.Generic.Dictionary<ToolStripMenuItem, string>
            {
                { anasayfaToolStripMenuItem, "home.png" },
                { ürünlerToolStripMenuItem, "product.png" },
                { stoklarToolStripMenuItem, "box.png" },
                { müşterilerToolStripMenuItem, "user-group-man-man.png" },
                { şirketlerToolStripMenuItem, "company.png" },
                { personellerToolStripMenuItem, "worker-male.png" },
                { giderlerToolStripMenuItem, "money-bag.png" },
                { kasaToolStripMenuItem, "cash-register.png" },
                { bankalarToolStripMenuItem, "bank-building.png" },
                { faturalarToolStripMenuItem, "bill.png" }
            };

            using (var client = new System.Net.Http.HttpClient())
            {
                var tasks = new System.Collections.Generic.List<System.Threading.Tasks.Task>();
                foreach (var item in icons)
                {
                    string filePath = System.IO.Path.Combine(iconDir, item.Value);
                    if (!System.IO.File.Exists(filePath))
                    {
                        tasks.Add(System.Threading.Tasks.Task.Run(async () =>
                        {
                            try
                            {
                                var imageBytes = await client.GetByteArrayAsync("https://img.icons8.com/color/48/000000/" + item.Value);
                                System.IO.File.WriteAllBytes(filePath, imageBytes);
                            }
                            catch { }
                        }));
                    }
                }
                
                if (tasks.Count > 0)
                {
                    System.Threading.Tasks.Task.WaitAll(tasks.ToArray());
                }

                foreach (var item in icons)
                {
                    string filePath = System.IO.Path.Combine(iconDir, item.Value);
                    if (System.IO.File.Exists(filePath))
                    {
                        item.Key.Image = Image.FromFile(filePath);
                    }
                }
            }

            menuStrip1.BackColor = System.Drawing.Color.FromArgb(45, 52, 54); 
            menuStrip1.Width = 250; 
            foreach (ToolStripItem item in menuStrip1.Items)
            {
                item.Padding = new Padding(15, 20, 15, 20); 
                item.ForeColor = System.Drawing.Color.White; 
                item.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
                item.ImageAlign = ContentAlignment.MiddleLeft;
                item.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ana = new ANASAYFA
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false,
            };
            ana.StartPosition = FormStartPosition.CenterParent;
            ana.ShowDialog(this);
        }

        private void şirketlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sirket = new ŞİRKETLER
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false,
            };
            sirket.StartPosition = FormStartPosition.CenterParent;
            sirket.ShowDialog(this);
        }

        private void stoklarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var stok = new STOKLAR
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false,
            };
            stok.StartPosition = FormStartPosition.CenterParent;
            stok.ShowDialog(this);
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var urun = new ÜRÜNLER
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false,
            };
            urun.StartPosition = FormStartPosition.CenterParent;
            urun.ShowDialog(this);
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var musteri = new MÜŞTERİLER
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false,
            };
             musteri.StartPosition = FormStartPosition.CenterParent;
             musteri.ShowDialog(this);
        }

        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var personel = new PERSONELLER
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false,
            };
            personel.StartPosition = FormStartPosition.CenterParent;
            personel.ShowDialog(this);
        }

        private void giderlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gider = new GIDERLER
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false,
            };
            gider.StartPosition = FormStartPosition.CenterParent;
            gider.ShowDialog(this);
        }

        private void kasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var kasa = new KASA
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false,
            };
            kasa.StartPosition = FormStartPosition.CenterParent;
            kasa.ShowDialog(this);
        }

        private void bankalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var banka = new BANKALAR
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false,
            };
            banka.StartPosition = FormStartPosition.CenterParent;
            banka.ShowDialog(this);
        }

        private void faturalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fatura = new FATURALAR
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false,
            };
            fatura.StartPosition = FormStartPosition.CenterParent;
            fatura.ShowDialog(this);
        }
    }
}
