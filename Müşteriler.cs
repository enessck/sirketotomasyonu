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
    public partial class MÜŞTERİLER : Form
    {
        public MÜŞTERİLER()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();
        void listele()

        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLMUSTERILER", baglanti.baglanti());
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        void illistesi()
        {
            SqlCommand komut = new SqlCommand("select sehiradi from iller", baglanti.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbil.Items.Add(dr[0]);
            }
            baglanti.baglanti().Close();
        }
        //void ilcelerlistesi()
        //{
        //    cbilçe.Items.Clear();
        //    SqlCommand komut = new SqlCommand("select ilceadi from ilceler where sehirid=@p1", baglanti.baglanti());
        //    komut.Parameters.AddWithValue("@p1", cbil.SelectedIndex + 1);
        //    SqlDataReader dr = komut.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        cbilçe.Items.Add(dr[0]);
        //    }
        //}

        private void MÜŞTERİLER_Load(object sender, EventArgs e)
        {
            listele();
            illistesi();
            //ilcelerlistesi();
        }

        private void cbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbilçe.Items.Clear();
            SqlCommand komut = new SqlCommand("select ilceadi from ilceler where sehirid=@p1", baglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", cbil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbilçe.Items.Add(dr[0]);
            }
            baglanti.baglanti().Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (txtad.Text == string.Empty)
                hata = 1;
            if (txtsoyad.Text == string.Empty)
                hata = 1;
            if (maskedtelno.Text == string.Empty)
                hata = 1;
            if (maskedtc.Text == string.Empty)
                hata = 1;
            if (txtmail.Text == string.Empty)
                hata = 1;
            if (cbil.Text == string.Empty)
                hata = 1;
            if (cbilçe.Text == string.Empty)
                hata = 1;
            if (txtadres.Text == string.Empty)
                hata = 1;
            if (txtvergid.Text == string.Empty)
                hata = 1;
            if (hata == 1)
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SqlCommand komut = new SqlCommand("insert into TBLMUSTERILER (AD,SOYAD,TEL,TC,MAİL,İL,İLÇE,ADRES,VERGIDAIRESI) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", txtad.Text);
                komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
                komut.Parameters.AddWithValue("@p3", maskedtelno.Text);
                komut.Parameters.AddWithValue("@p4", maskedtc.Text);
                komut.Parameters.AddWithValue("@p5", txtmail.Text);
                komut.Parameters.AddWithValue("@p6", cbil.Text);
                komut.Parameters.AddWithValue("@p7", cbilçe.Text);
                komut.Parameters.AddWithValue("@p8", txtadres.Text);
                komut.Parameters.AddWithValue("@p9", txtvergid.Text);
                int basari = komut.ExecuteNonQuery();
                if (basari == 1)
                    MessageBox.Show("Müşteri Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Müşteri Kaydedilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            listele();
            txtad.Clear();
            txtsoyad.Clear();
            maskedtelno.Clear();
            maskedtc.Clear();
            txtmail.Clear();
            cbil.Text = string.Empty;
            cbilçe.Text = string.Empty;
            txtadres.Clear();
            txtvergid.Clear();
            baglanti.baglanti().Close();

        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
      
        {
            
            if (e.RowIndex >= 0)
            {
                
                txtıd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                maskedtelno.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                maskedtc.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtmail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                cbil.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbilçe.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtadres.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtvergid.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (txtıd.Text == string.Empty)
                hata = 1;
            if (hata == 1)
                MessageBox.Show("Lütfen Silinecek Müşteriyi Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SqlCommand komut = new SqlCommand("select * from TBLMUSTERILER where ID=@p1", baglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", txtıd.Text);
                komut.ExecuteNonQuery();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    SqlCommand cm = new SqlCommand("Delete  From TBLMUSTERILER where ID = @p1", baglanti.baglanti());
                    cm.Parameters.AddWithValue("@p1", txtıd.Text);
                    int basari = cm.ExecuteNonQuery();
                    baglanti.baglanti().Close();
                    if (basari == 1)
                    MessageBox.Show("Müşteri Başarı İle Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else                    
                    MessageBox.Show("Müşteri Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Bu ID'ye sahip bir müşteri bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.baglanti().Close();
                txtıd.Clear();
                txtad.Clear();
                txtsoyad.Clear();
                maskedtelno.Clear();
                maskedtc.Clear();
                txtmail.Clear();
                cbil.Text = string.Empty;
                cbilçe.Text = string.Empty;
                txtadres.Clear();
                txtvergid.Clear();

                listele();

            }
        }

    }
}
