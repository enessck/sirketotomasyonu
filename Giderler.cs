using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ŞİRKETOTOMASYONU
{
    public partial class GIDERLER : Form
    {
        public GIDERLER()
        {
            InitializeComponent();
        }

        SqlBaglanti baglanti = new SqlBaglanti();

        void listele()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("Select * From TBLGIDERLER", baglanti.baglanti());
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri listelenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GIDERLER_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cm = new SqlCommand("insert into TBLGIDERLER (ELEKTIRIK, SU, DOGALGAZ, INTERNET, MAASLAR, KIRA) values (@p1, @p2, @p3, @p4, @p5, @p6)", baglanti.baglanti());
                cm.Parameters.AddWithValue("@p1", txtElektrik.Text);
                cm.Parameters.AddWithValue("@p2", txtSu.Text);
                cm.Parameters.AddWithValue("@p3", txtDogalgaz.Text);
                cm.Parameters.AddWithValue("@p4", txtInternet.Text);
                cm.Parameters.AddWithValue("@p5", txtMaaslar.Text);
                cm.Parameters.AddWithValue("@p6", txtKira.Text);

                int sonuc = cm.ExecuteNonQuery();
                if (sonuc == 1) MessageBox.Show("Gider Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Gider Eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SqlCommand cm = new SqlCommand("Delete From TBLGIDERLER where ID = @p1", baglanti.baglanti());
                cm.Parameters.AddWithValue("@p1", txtId.Text);
                int sonuc = cm.ExecuteNonQuery();
                if (sonuc == 1) MessageBox.Show("Gider Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Gider Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SqlCommand cm = new SqlCommand("Update TBLGIDERLER set ELEKTIRIK=@p1, SU=@p2, DOGALGAZ=@p3, INTERNET=@p4, MAASLAR=@p5, KIRA=@p6 where ID=@p7", baglanti.baglanti());
                cm.Parameters.AddWithValue("@p1", txtElektrik.Text);
                cm.Parameters.AddWithValue("@p2", txtSu.Text);
                cm.Parameters.AddWithValue("@p3", txtDogalgaz.Text);
                cm.Parameters.AddWithValue("@p4", txtInternet.Text);
                cm.Parameters.AddWithValue("@p5", txtMaaslar.Text);
                cm.Parameters.AddWithValue("@p6", txtKira.Text);
                cm.Parameters.AddWithValue("@p7", txtId.Text);

                int sonuc = cm.ExecuteNonQuery();
                if (sonuc == 1) MessageBox.Show("Gider Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Gider Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtElektrik.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";
                txtSu.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "";
                txtDogalgaz.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";
                txtInternet.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? "";
                txtMaaslar.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value?.ToString() ?? "";
                txtKira.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value?.ToString() ?? "";
            }
        }

        void Temizle()
        {
            txtId.Clear(); txtElektrik.Clear(); txtSu.Clear();
            txtDogalgaz.Clear(); txtInternet.Clear(); txtMaaslar.Clear(); txtKira.Clear();
        }
    }
}
