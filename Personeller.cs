using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ŞİRKETOTOMASYONU
{
    public partial class PERSONELLER : Form
    {
        public PERSONELLER()
        {
            InitializeComponent();
        }

        SqlBaglanti baglanti = new SqlBaglanti();

        void listele()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("Select * From TBLPERSONEL", baglanti.baglanti());
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri listelenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PERSONELLER_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cm = new SqlCommand("insert into TBLPERSONEL (AD, SOYAD, TC, TELEFONNO, MAİL, İL, İLÇE, ADRES, GÖREVİ) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)", baglanti.baglanti());
                cm.Parameters.AddWithValue("@p1", txtAd.Text);
                cm.Parameters.AddWithValue("@p2", txtSoyad.Text);
                cm.Parameters.AddWithValue("@p3", txtTc.Text);
                cm.Parameters.AddWithValue("@p4", txtTelefon.Text);
                cm.Parameters.AddWithValue("@p5", txtMail.Text);
                cm.Parameters.AddWithValue("@p6", txtIl.Text);
                cm.Parameters.AddWithValue("@p7", txtIlce.Text);
                cm.Parameters.AddWithValue("@p8", txtAdres.Text);
                cm.Parameters.AddWithValue("@p9", txtGorevi.Text);

                int sonuc = cm.ExecuteNonQuery();
                if (sonuc == 1) MessageBox.Show("Personel Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Personel Eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();
                Temizle();
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
                SqlCommand cm = new SqlCommand("Delete From TBLPERSONEL where ID = @p1", baglanti.baglanti());
                cm.Parameters.AddWithValue("@p1", txtId.Text);
                int sonuc = cm.ExecuteNonQuery();
                if (sonuc == 1) MessageBox.Show("Personel Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Personel Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Lütfen Güncellenecek ID'yi Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                SqlCommand cm = new SqlCommand("Update TBLPERSONEL set AD=@p1, SOYAD=@p2, TC=@p3, TELEFONNO=@p4, MAİL=@p5, İL=@p6, İLÇE=@p7, ADRES=@p8, GÖREVİ=@p9 where ID=@p10", baglanti.baglanti());
                cm.Parameters.AddWithValue("@p1", txtAd.Text);
                cm.Parameters.AddWithValue("@p2", txtSoyad.Text);
                cm.Parameters.AddWithValue("@p3", txtTc.Text);
                cm.Parameters.AddWithValue("@p4", txtTelefon.Text);
                cm.Parameters.AddWithValue("@p5", txtMail.Text);
                cm.Parameters.AddWithValue("@p6", txtIl.Text);
                cm.Parameters.AddWithValue("@p7", txtIlce.Text);
                cm.Parameters.AddWithValue("@p8", txtAdres.Text);
                cm.Parameters.AddWithValue("@p9", txtGorevi.Text);
                cm.Parameters.AddWithValue("@p10", txtId.Text);

                int sonuc = cm.ExecuteNonQuery();
                if (sonuc == 1) MessageBox.Show("Personel Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Personel Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();
                Temizle();
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
                txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";
                txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "";
                txtTc.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";
                txtTelefon.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? "";
                txtMail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value?.ToString() ?? "";
                txtIl.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value?.ToString() ?? "";
                txtIlce.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value?.ToString() ?? "";
                txtAdres.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value?.ToString() ?? "";
                txtGorevi.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value?.ToString() ?? "";
            }
        }

        void Temizle()
        {
            txtId.Clear(); txtAd.Clear(); txtSoyad.Clear(); txtTc.Clear();
            txtTelefon.Clear(); txtMail.Clear(); txtIl.Clear(); txtIlce.Clear();
            txtAdres.Clear(); txtGorevi.Clear();
        }
    }
}