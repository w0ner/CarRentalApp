using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araç_Kiralama
{
    internal class AracKiralama
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-3P5KSU4T\\TEW_SQLEXPRESS;Initial Catalog=OtoKiralamaDB;Integrated Security=True");
        DataTable tablo;
        public void EkleSilGüncelle(SqlCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public DataTable listele(SqlDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        public void MüsaitAraçlar(ComboBox combo, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["Plaka"].ToString());
            }
            baglanti.Close();
        }

        public void TcAra(TextBox tcara,TextBox tc, TextBox adsoyad, TextBox telefon, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                tc.Text = read["Tc"].ToString();
                adsoyad.Text = read["AdSoyad"].ToString();
                telefon.Text = read["Telefon"].ToString();
            }
            baglanti.Close();
        }

        public void CombodanGetir(ComboBox araclar, TextBox marka, TextBox seri, TextBox yıl, TextBox renk, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["Marka"].ToString();
                seri.Text = read["Seri"].ToString();
                yıl.Text = read["Yıl"].ToString();
                renk.Text = read["Renk"].ToString();
            }
            baglanti.Close();
        }

        public void ÜcretHesapla(ComboBox cmbkiraşekli, TextBox ücret, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (cmbkiraşekli.SelectedIndex == 0) ücret.Text = (int.Parse(read["Ücret"].ToString()) * 1).ToString();
                if (cmbkiraşekli.SelectedIndex == 1) ücret.Text = (int.Parse(read["Ücret"].ToString()) * 0.80).ToString();
                if (cmbkiraşekli.SelectedIndex == 2) ücret.Text = (int.Parse(read["Ücret"].ToString()) * 0.70).ToString();


            }
            baglanti.Close();
        }

        public void SatışHesapla(Label lbl)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(tutar) from Kasa", baglanti);
            lbl.Text = "Toplam Tutar=" + komut.ExecuteScalar() + " TL";
            baglanti.Close();
        }
    }
}
