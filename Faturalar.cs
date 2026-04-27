using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ŞİRKETOTOMASYONU
{
    public partial class FATURALAR : Form
    {
        public FATURALAR()
        {
            InitializeComponent();
        }

        SqlBaglanti baglanti = new SqlBaglanti();

        void listele()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("Select * From TBLFATURA", baglanti.baglanti());
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri listelenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FATURALAR_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cm = new SqlCommand("insert into TBLFATURA (SERI, SIRANO, TARIH, SAAT, VERGIDAIRESI, ALICI, TESLIMEDEN, TESLIMALAN) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", baglanti.baglanti());
                cm.Parameters.AddWithValue("@p1", txtSeri.Text);
                cm.Parameters.AddWithValue("@p2", txtSiraNo.Text);
                cm.Parameters.AddWithValue("@p3", txtTarih.Text);
                cm.Parameters.AddWithValue("@p4", txtSaat.Text);
                cm.Parameters.AddWithValue("@p5", txtVergiDairesi.Text);
                cm.Parameters.AddWithValue("@p6", txtAlici.Text);
                cm.Parameters.AddWithValue("@p7", txtTeslimEden.Text);
                cm.Parameters.AddWithValue("@p8", txtTeslimAlan.Text);

                int sonuc = cm.ExecuteNonQuery();
                if (sonuc == 1) MessageBox.Show("Fatura Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Fatura Eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrEmpty(txtFaturaId.Text))
            {
                MessageBox.Show("Lütfen Silinecek Fatura ID'sini Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                SqlCommand cm = new SqlCommand("Delete From TBLFATURA where FATURAID = @p1", baglanti.baglanti());
                cm.Parameters.AddWithValue("@p1", txtFaturaId.Text);
                int sonuc = cm.ExecuteNonQuery();
                if (sonuc == 1) MessageBox.Show("Fatura Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Fatura Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrEmpty(txtFaturaId.Text))
            {
                MessageBox.Show("Lütfen Güncellenecek Fatura ID'sini Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                SqlCommand cm = new SqlCommand("Update TBLFATURA set SERI=@p1, SIRANO=@p2, TARIH=@p3, SAAT=@p4, VERGIDAIRESI=@p5, ALICI=@p6, TESLIMEDEN=@p7, TESLIMALAN=@p8 where FATURAID=@p9", baglanti.baglanti());
                cm.Parameters.AddWithValue("@p1", txtSeri.Text);
                cm.Parameters.AddWithValue("@p2", txtSiraNo.Text);
                cm.Parameters.AddWithValue("@p3", txtTarih.Text);
                cm.Parameters.AddWithValue("@p4", txtSaat.Text);
                cm.Parameters.AddWithValue("@p5", txtVergiDairesi.Text);
                cm.Parameters.AddWithValue("@p6", txtAlici.Text);
                cm.Parameters.AddWithValue("@p7", txtTeslimEden.Text);
                cm.Parameters.AddWithValue("@p8", txtTeslimAlan.Text);
                cm.Parameters.AddWithValue("@p9", txtFaturaId.Text);

                int sonuc = cm.ExecuteNonQuery();
                if (sonuc == 1) MessageBox.Show("Fatura Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Fatura Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtFaturaId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "";
                txtSeri.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";
                txtSiraNo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "";
                txtTarih.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";
                txtSaat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? "";
                txtVergiDairesi.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value?.ToString() ?? "";
                txtAlici.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value?.ToString() ?? "";
                txtTeslimEden.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value?.ToString() ?? "";
                txtTeslimAlan.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value?.ToString() ?? "";
            }
        }

        void Temizle()
        {
            txtFaturaId.Clear(); txtSeri.Clear(); txtSiraNo.Clear(); txtTarih.Clear();
            txtSaat.Clear(); txtVergiDairesi.Clear(); txtAlici.Clear();
            txtTeslimEden.Clear(); txtTeslimAlan.Clear();
        }
    }
}
