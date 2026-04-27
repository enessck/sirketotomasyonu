using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ŞİRKETOTOMASYONU
{
    public partial class ÜRÜNLER : Form
    {
        public ÜRÜNLER()
        {
            InitializeComponent();
        }

        SqlBaglanti baglantı = new SqlBaglanti();

        void listele()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLURUNLER", baglantı.baglanti());
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void ÜRÜNLER_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (txtad.Text == string.Empty)
                hata = 1;
            if (txtmarka.Text == string.Empty)
                hata = 2;
            if (txtmodel.Text == string.Empty)
                hata = 3;
            if (maskedtxtyıl.Text == string.Empty)
                hata = 4;
            if (numericadet.Text == string.Empty)
                hata = 5;
            if (txtalısfıyat.Text == string.Empty)
                hata = 6;
            if (txtsatısfıyat.Text == string.Empty)
                hata = 7;
            if (hata == 1)
                MessageBox.Show("Lütfen Ürün Adını Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (hata == 2)
                MessageBox.Show("Lütfen Marka Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (hata == 3)
                MessageBox.Show("Lütfen Model Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (hata == 4)
                MessageBox.Show("Lütfen Yıl Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (hata == 5)
                MessageBox.Show("Lütfen Adet Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (hata == 6)
                MessageBox.Show("Lütfen Alış Fiyatı Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (hata == 7)
                MessageBox.Show("Lütfen Satış Fiyatı Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            { }
            SqlCommand cm = new SqlCommand("insert into TBLURUNLER (URUNAD,MARKA,MODEL,YIL,ADET,ALIŞFIYATI,SATIŞFIYATI) values ('" + txtad.Text + "','" + txtmarka.Text + "','" + txtmodel.Text + "','" + maskedtxtyıl.Text + "','" + numericadet.Text + "','" + txtalısfıyat.Text + "','" + txtsatısfıyat.Text + "')", baglantı.baglanti());
            int sonuc = cm.ExecuteNonQuery();
            baglantı.baglanti().Close();

            if (sonuc == 1)
                MessageBox.Show("Ürün Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Ürün Eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtıd.Clear();
            txtad.Clear();
            txtmarka.Clear();
            txtmodel.Clear();
            maskedtxtyıl.Clear();
            numericadet.Value = 0;
            txtalısfıyat.Clear();
            txtsatısfıyat.Clear();
            listele();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int hata = 0;
            if (txtıd.Text == string.Empty)
                hata = 1;
            if (hata == 1)
                MessageBox.Show("Lütfen Silinecek Ürünün ID'sini Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SqlCommand komut = new SqlCommand("Select * From TBLURUNLER where ID = '" + txtıd.Text + "'", baglantı.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    SqlCommand cm = new SqlCommand("Delete From TBLURUNLER where ID = '" + txtıd.Text + "'", baglantı.baglanti());
                    int sonuc = cm.ExecuteNonQuery();
                    baglantı.baglanti().Close();
                    if (sonuc == 1)
                        MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Ürün Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    listele();

                }
                else
                {
                    MessageBox.Show("Bu ID'ye sahip bir ürün bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtıd.Clear();
            listele();
            baglantı.baglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtıd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtmarka.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtmodel.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            maskedtxtyıl.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            // numericadet.Value = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            // numericadet.Value = decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value?.ToString() ?? "0");
            string cellValue = dataGridView1.Rows[e.RowIndex].Cells[5].Value?.ToString();

            if (string.IsNullOrWhiteSpace(cellValue))
            {
                numericadet.Value = 0;
            }
            else
            {
                numericadet.Value = decimal.Parse(cellValue);
            }
            txtalısfıyat.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtsatısfıyat.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cm=new SqlCommand("Update TBLURUNLER set URUNAD =@p1,MARKA = @p2,MODEL = @p3,YIL = @p4,ADET = @p5,ALIŞFIYATI = @p6,SATIŞFIYATI = @p7 where ID = @p8", baglantı.baglanti());
            cm.Parameters.AddWithValue("@p1", txtad.Text);
            cm.Parameters.AddWithValue("@p2", txtmarka.Text);
            cm.Parameters.AddWithValue("@p3", txtmodel.Text);
            cm.Parameters.AddWithValue("@p4", maskedtxtyıl.Text);
            cm.Parameters.AddWithValue("@p5", int .Parse(numericadet.Value.ToString()));
            cm.Parameters.AddWithValue("@p6", decimal.Parse(txtalısfıyat.Text));
            cm.Parameters.AddWithValue("@p7", decimal.Parse(txtsatısfıyat.Text));
            cm.Parameters.AddWithValue("@p8", txtıd.Text);
            int sonuc = cm.ExecuteNonQuery();
            baglantı.baglanti().Close();
            if (sonuc == 1)
                MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Ürün Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
            txtad.Clear();
            txtmarka.Clear();
            txtmodel.Clear();
            maskedtxtyıl.Clear();
            numericadet.Value = 0;
            txtalısfıyat.Clear();
            txtsatısfıyat.Clear();
            txtıd.Clear();
        }
    }
}
