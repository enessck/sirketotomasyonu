using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ŞİRKETOTOMASYONU
{
    public partial class STOKLAR : Form
    {
        public STOKLAR()
        {
            InitializeComponent();
        }

        SqlBaglanti baglanti = new SqlBaglanti();

        void listele()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("Select * From TBLSTOK", baglanti.baglanti());
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri listelenirken hata oluştu (TBLSTOK tablosu eksik olabilir): " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void STOKLAR_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTur.Text) || string.IsNullOrEmpty(txtAdet.Text))
            {
                MessageBox.Show("Lütfen Stok Türü ve Adet Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                SqlCommand cm = new SqlCommand("insert into TBLSTOK (STOKTUR, STOKADET) values (@p1, @p2)", baglanti.baglanti());
                cm.Parameters.AddWithValue("@p1", txtTur.Text);
                cm.Parameters.AddWithValue("@p2", int.Parse(txtAdet.Text));
                int sonuc = cm.ExecuteNonQuery();
                if (sonuc == 1) MessageBox.Show("Stok Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Stok Eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();
                txtTur.Clear();
                txtAdet.Clear();
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
                MessageBox.Show("Lütfen Silinecek Stok ID'sini Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                SqlCommand cm = new SqlCommand("Delete From TBLSTOK where ID = @p1", baglanti.baglanti());
                cm.Parameters.AddWithValue("@p1", txtId.Text);
                int sonuc = cm.ExecuteNonQuery();
                if (sonuc == 1) MessageBox.Show("Stok Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Stok Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();
                txtId.Clear();
                txtTur.Clear();
                txtAdet.Clear();
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
                MessageBox.Show("Lütfen Güncellenecek Stok ID'sini Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                SqlCommand cm = new SqlCommand("Update TBLSTOK set STOKTUR=@p1, STOKADET=@p2 where ID=@p3", baglanti.baglanti());
                cm.Parameters.AddWithValue("@p1", txtTur.Text);
                cm.Parameters.AddWithValue("@p2", int.Parse(txtAdet.Text));
                cm.Parameters.AddWithValue("@p3", txtId.Text);
                int sonuc = cm.ExecuteNonQuery();
                if (sonuc == 1) MessageBox.Show("Stok Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Stok Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listele();
                txtTur.Clear();
                txtAdet.Clear();
                txtId.Clear();
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
                txtTur.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";
                txtAdet.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "";
            }
        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }
    }
}