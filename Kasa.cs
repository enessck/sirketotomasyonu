using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ŞİRKETOTOMASYONU
{
    public partial class KASA : Form
    {
        public KASA()
        {
            InitializeComponent();
        }

        SqlBaglanti baglanti = new SqlBaglanti();

        void listele()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("Select * From TBLKASA ORDER BY TARIH DESC", baglanti.baglanti());
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                BakiyeHesapla();
            }
            catch (Exception ex)
            {
                // Tablo yoksa oluştur
                try
                {
                    SqlCommand create = new SqlCommand(
                        "IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='TBLKASA' AND xtype='U') " +
                        "CREATE TABLE TBLKASA (ID INT IDENTITY(1,1) PRIMARY KEY, ISLEMTURU NVARCHAR(50), ACIKLAMA NVARCHAR(250), TUTAR DECIMAL(18,2), TARIH NVARCHAR(50))",
                        baglanti.baglanti());
                    create.ExecuteNonQuery();
                }
                catch { }
            }
        }

        void BakiyeHesapla()
        {
            try
            {
                decimal toplamGelir = 0;
                decimal toplamGider = 0;

                SqlCommand cmGelir = new SqlCommand("SELECT ISNULL(SUM(TUTAR),0) FROM TBLKASA WHERE ISLEMTURU='GELİR'", baglanti.baglanti());
                toplamGelir = Convert.ToDecimal(cmGelir.ExecuteScalar());

                SqlCommand cmGider = new SqlCommand("SELECT ISNULL(SUM(TUTAR),0) FROM TBLKASA WHERE ISLEMTURU='GİDER'", baglanti.baglanti());
                toplamGider = Convert.ToDecimal(cmGider.ExecuteScalar());

                decimal bakiye = toplamGelir - toplamGider;

                lblToplamGelir.Text = toplamGelir.ToString("N2") + " ₺";
                lblToplamGider.Text = toplamGider.ToString("N2") + " ₺";
                lblBakiye.Text = bakiye.ToString("N2") + " ₺";

                if (bakiye >= 0)
                    lblBakiye.ForeColor = System.Drawing.Color.DarkGreen;
                else
                    lblBakiye.ForeColor = System.Drawing.Color.DarkRed;
            }
            catch
            {
                lblToplamGelir.Text = "0,00 ₺";
                lblToplamGider.Text = "0,00 ₺";
                lblBakiye.Text = "0,00 ₺";
            }
        }

        private void KASA_Load(object sender, EventArgs e)
        {
            cmbIslemTuru.Items.Add("GELİR");
            cmbIslemTuru.Items.Add("GİDER");
            cmbIslemTuru.SelectedIndex = 0;
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTutar.Text))
            {
                MessageBox.Show("Lütfen Tutar Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                SqlCommand cm = new SqlCommand("insert into TBLKASA (ISLEMTURU, ACIKLAMA, TUTAR, TARIH) values (@p1, @p2, @p3, @p4)", baglanti.baglanti());
                cm.Parameters.AddWithValue("@p1", cmbIslemTuru.SelectedItem.ToString());
                cm.Parameters.AddWithValue("@p2", txtAciklama.Text);
                cm.Parameters.AddWithValue("@p3", decimal.Parse(txtTutar.Text));
                cm.Parameters.AddWithValue("@p4", DateTime.Now.ToString("dd.MM.yyyy HH:mm"));

                int sonuc = cm.ExecuteNonQuery();
                if (sonuc == 1) MessageBox.Show("Kasa Kaydı Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Kayıt Eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();
                txtTutar.Clear();
                txtAciklama.Clear();
                txtId.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Lütfen Silinecek ID'yi Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                SqlCommand cm = new SqlCommand("Delete From TBLKASA where ID = @p1", baglanti.baglanti());
                cm.Parameters.AddWithValue("@p1", txtId.Text);
                int sonuc = cm.ExecuteNonQuery();
                if (sonuc == 1) MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Kayıt Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();
                txtId.Clear(); txtTutar.Clear(); txtAciklama.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "";
                string islemTuru = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";
                if (islemTuru == "GELİR") cmbIslemTuru.SelectedIndex = 0;
                else cmbIslemTuru.SelectedIndex = 1;
                txtAciklama.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "";
                txtTutar.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";
            }
        }
    }
}
