using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ŞİRKETOTOMASYONU
{
    public partial class ANASAYFA : Form
    {
        public ANASAYFA()
        {
            InitializeComponent();
        }

        SqlBaglanti baglanti = new SqlBaglanti();

        private void ANASAYFA_Load(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToString("dd MMMM yyyy, dddd");
            lblSaat.Text = DateTime.Now.ToString("HH:mm");
            YukleIstatistikler();
        }

        private int TabloSayisi(string tablo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM " + tablo, baglanti.baglanti());
                return (int)cmd.ExecuteScalar();
            }
            catch { return 0; }
        }

        private void YukleIstatistikler()
        {
            lblUrunSayi.Text = TabloSayisi("TBLURUNLER").ToString();
            lblStokSayi.Text = TabloSayisi("TBLSTOK").ToString();
            lblMusteriSayi.Text = TabloSayisi("TBLMUSTERILER").ToString();
            lblSirketSayi.Text = TabloSayisi("TBLSIRKETLER").ToString();
            lblPersonelSayi.Text = TabloSayisi("TBLPERSONEL").ToString();
            lblBankaSayi.Text = TabloSayisi("TBLBANKALAR").ToString();
            lblFaturaSayi.Text = TabloSayisi("TBLFATURA").ToString();
            lblGiderSayi.Text = TabloSayisi("TBLGIDERLER").ToString();

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("HH:mm");
            YukleIstatistikler();
            MessageBox.Show("Veriler güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSaat_Click(object sender, EventArgs e)
        {

        }
    }
}
