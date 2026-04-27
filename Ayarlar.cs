using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ŞİRKETOTOMASYONU
{
    public partial class AYARLAR : Form
    {
        public AYARLAR()
        {
            InitializeComponent();
        }

        private void AYARLAR_Load(object sender, EventArgs e)
        {
            lblSunucu.Text = "localhost";
            lblVeritabani.Text = "DBOSIRKETOTOMASYON";
            lblBaglanti.Text = "Windows Authentication";
            BaglantiTest();
        }

        private void BaglantiTest()
        {
            try
            {
                SqlBaglanti bag = new SqlBaglanti();
                SqlConnection conn = bag.baglanti();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    lblDurum.Text = "✅ BAĞLANTI BAŞARILI";
                    lblDurum.ForeColor = System.Drawing.Color.DarkGreen;
                    conn.Close();
                }
            }
            catch
            {
                lblDurum.Text = "❌ BAĞLANTI BAŞARISIZ";
                lblDurum.ForeColor = System.Drawing.Color.DarkRed;
            }
        }

        private void btnBaglantiTest_Click(object sender, EventArgs e)
        {
            BaglantiTest();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTabloBilgi_Click(object sender, EventArgs e)
        {
            try
            {
                SqlBaglanti bag = new SqlBaglanti();
                SqlCommand cmd = new SqlCommand(
                    "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' ORDER BY TABLE_NAME",
                    bag.baglanti());
                SqlDataReader dr = cmd.ExecuteReader();
                string tablolar = "VERİTABANINDAKİ TABLOLAR:\n\n";
                int sayac = 1;
                while (dr.Read())
                {
                    tablolar += sayac + ". " + dr["TABLE_NAME"].ToString() + "\n";
                    sayac++;
                }
                dr.Close();
                MessageBox.Show(tablolar, "Tablo Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grpSistem_Enter(object sender, EventArgs e)
        {

        }
    }
}
