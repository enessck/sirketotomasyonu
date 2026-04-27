using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ŞİRKETOTOMASYONU
{
    public partial class ŞİRKETLER : Form
    {
        public ŞİRKETLER()
        {
            InitializeComponent();
        }

        SqlBaglanti baglanti = new SqlBaglanti();

        void listele()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("Select * From TBLSIRKETLER", baglanti.baglanti());
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri listelenirken hata oluştu (TBLSIRKETLER tablosu eksik olabilir): " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ŞİRKETLER_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cm = new SqlCommand("insert into TBLSIRKETLER (AD, YETKILI, YETKILIADSOYAD, TEL1, TEL2, MAIL, IL, ILCE, VERGIDAIRESI, ADRES) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)", baglanti.baglanti());
                cm.Parameters.AddWithValue("@p1", txtAd.Text);
                cm.Parameters.AddWithValue("@p2", txtYetkili.Text);
                cm.Parameters.AddWithValue("@p3", txtYetkiliAdSoyad.Text);
                cm.Parameters.AddWithValue("@p4", txtTel1.Text);
                cm.Parameters.AddWithValue("@p5", txtTel2.Text);
                cm.Parameters.AddWithValue("@p6", txtMail.Text);
                cm.Parameters.AddWithValue("@p7", txtIl.Text);
                cm.Parameters.AddWithValue("@p8", txtIlce.Text);
                cm.Parameters.AddWithValue("@p9", txtVergiDairesi.Text);
                cm.Parameters.AddWithValue("@p10", txtAdres.Text);
                
                int sonuc = cm.ExecuteNonQuery();
                if (sonuc == 1) MessageBox.Show("Şirket Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Şirket Eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();
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
                SqlCommand cm = new SqlCommand("Delete From TBLSIRKETLER where ID = @p1", baglanti.baglanti());
                cm.Parameters.AddWithValue("@p1", txtId.Text);
                int sonuc = cm.ExecuteNonQuery();
                if (sonuc == 1) MessageBox.Show("Şirket Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Şirket Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();
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
                SqlCommand cm = new SqlCommand("Update TBLSIRKETLER set AD=@p1, YETKILI=@p2, YETKILIADSOYAD=@p3, TEL1=@p4, TEL2=@p5, MAIL=@p6, IL=@p7, ILCE=@p8, VERGIDAIRESI=@p9, ADRES=@p10 where ID=@p11", baglanti.baglanti());
                cm.Parameters.AddWithValue("@p1", txtAd.Text);
                cm.Parameters.AddWithValue("@p2", txtYetkili.Text);
                cm.Parameters.AddWithValue("@p3", txtYetkiliAdSoyad.Text);
                cm.Parameters.AddWithValue("@p4", txtTel1.Text);
                cm.Parameters.AddWithValue("@p5", txtTel2.Text);
                cm.Parameters.AddWithValue("@p6", txtMail.Text);
                cm.Parameters.AddWithValue("@p7", txtIl.Text);
                cm.Parameters.AddWithValue("@p8", txtIlce.Text);
                cm.Parameters.AddWithValue("@p9", txtVergiDairesi.Text);
                cm.Parameters.AddWithValue("@p10", txtAdres.Text);
                cm.Parameters.AddWithValue("@p11", txtId.Text);
                
                int sonuc = cm.ExecuteNonQuery();
                if (sonuc == 1) MessageBox.Show("Şirket Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Şirket Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) {
                txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "";
                txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";
                txtYetkili.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "";
                txtYetkiliAdSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";
                txtTel1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? "";
                txtTel2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value?.ToString() ?? "";
                txtMail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value?.ToString() ?? "";
                txtIl.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value?.ToString() ?? "";
                txtIlce.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value?.ToString() ?? "";
                txtVergiDairesi.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value?.ToString() ?? "";
                txtAdres.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value?.ToString() ?? "";
            }
        }
    }
}