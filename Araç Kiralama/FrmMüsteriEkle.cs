using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_Kiralama
{
    public partial class FrmMüsteriEkle : Form
    {
        AracKiralama aracKiralama = new AracKiralama();
        public FrmMüsteriEkle()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string cümle = "Insert Müşteri values(@tc,@adsoyad,@telefon,@adres,@email)";
            SqlCommand komut = new();
            komut.Parameters.AddWithValue("@tc", txtTC.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtMail.Text);
            aracKiralama.EkleSilGüncelle(komut, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            MessageBox.Show("Müşteri başarı ile eklendi...");
        }

       
    }
}
