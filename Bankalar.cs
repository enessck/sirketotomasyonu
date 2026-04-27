using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ŞİRKETOTOMASYONU
{
    public partial class BANKALAR : Form
    {
        public BANKALAR()
        {
            InitializeComponent();
        }

        SqlBaglanti baglanti = new SqlBaglanti();

        void listele()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("Select * From TBLBANKALAR", baglanti.baglanti());
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri listelenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BANKALAR_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cm = new SqlCommand("insert into TBLBANKALAR (BANKAAD, SUBE, IBAN, HESAPNO, YETKILI, TARIH) values (@p1, @p2, @p3, @p4, @p5, @p6)", baglanti.baglanti());
                cm.Parameters.AddWithValue("@p1", txtBankaAd.Text);
                cm.Parameters.AddWithValue("@p2", txtSube.Text);
                cm.Parameters.AddWithValue("@p3", txtIban.Text);
                cm.Parameters.AddWithValue("@p4", txtHesapNo.Text);
                cm.Parameters.AddWithValue("@p5", txtYetkili.Text);
                cm.Parameters.AddWithValue("@p6", txtTarih.Text);

                int sonuc = cm.ExecuteNonQuery();
                if (sonuc == 1) MessageBox.Show("Banka Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Banka Eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SqlCommand cm = new SqlCommand("Delete From TBLBANKALAR where ID = @p1", baglanti.baglanti());
                cm.Parameters.AddWithValue("@p1", txtId.Text);
                int sonuc = cm.ExecuteNonQuery();
                if (sonuc == 1) MessageBox.Show("Banka Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Banka Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SqlCommand cm = new SqlCommand("Update TBLBANKALAR set BANKAAD=@p1, SUBE=@p2, IBAN=@p3, HESAPNO=@p4, YETKILI=@p5, TARIH=@p6 where ID=@p7", baglanti.baglanti());
                cm.Parameters.AddWithValue("@p1", txtBankaAd.Text);
                cm.Parameters.AddWithValue("@p2", txtSube.Text);
                cm.Parameters.AddWithValue("@p3", txtIban.Text);
                cm.Parameters.AddWithValue("@p4", txtHesapNo.Text);
                cm.Parameters.AddWithValue("@p5", txtYetkili.Text);
                cm.Parameters.AddWithValue("@p6", txtTarih.Text);
                cm.Parameters.AddWithValue("@p7", txtId.Text);

                int sonuc = cm.ExecuteNonQuery();
                if (sonuc == 1) MessageBox.Show("Banka Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Banka Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtBankaAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";
                txtSube.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "";
                txtIban.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";
                txtHesapNo.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? "";
                txtYetkili.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value?.ToString() ?? "";
                txtTarih.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value?.ToString() ?? "";
            }
        }

        void Temizle()
        {
            txtId.Clear(); txtBankaAd.Clear(); txtSube.Clear();
            txtIban.Clear(); txtHesapNo.Clear(); txtYetkili.Clear(); txtTarih.Clear();
        }
    }
}
