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
    public partial class FrmAracEkle : Form
    {
        AracKiralama aracKiralama = new AracKiralama();
        public FrmAracEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbSeri.Items.Clear();
                if (cmbMarka.SelectedItem.ToString() == "Bmw")
                {
                    cmbSeri.Items.Add("Bmw 1 Serisi");
                    cmbSeri.Items.Add("Bmw 2 Serisi");
                    cmbSeri.Items.Add("Bmw 3 Serisi");
                }
                else if (cmbMarka.SelectedItem.ToString() == "Mercedes")
                {
                    cmbSeri.Items.Add("C serisi");
                    cmbSeri.Items.Add("E serisi");
                    cmbSeri.Items.Add("CLA");
                }
                else if (cmbMarka.SelectedItem.ToString() == "Fiat")
                {
                    cmbSeri.Items.Add("Egea");
                    cmbSeri.Items.Add("Doblo");
                    cmbSeri.Items.Add("Captur");
                }
                else if (cmbMarka.SelectedItem.ToString() == "Renault")
                {
                    cmbSeri.Items.Add("Clio");
                    cmbSeri.Items.Add("Megan");
                    cmbSeri.Items.Add("Talisman");
                }

            }
            catch 
            {

               
            }


        }

        private void FrmAracEkle_Load(object sender, EventArgs e)
        {

        }

        private void cmbSeri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            string cümle = "insert into araç(plaka,marka,seri,yıl,renk,km,yakıt,ücret,resim,tarih,durum) values(@plaka,@marka,@seri,@yıl,@renk,@km,@yakıt,@ücret,@resim,@tarih,@durum)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komut.Parameters.AddWithValue("@marka", cmbMarka.Text);
            komut.Parameters.AddWithValue("@seri", cmbSeri.Text);
            komut.Parameters.AddWithValue("@yıl", txtModel.Text);
            komut.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@km", txtKm.Text);
            komut.Parameters.AddWithValue("@yakıt", cmbYakıt.Text);
            komut.Parameters.AddWithValue("@ücret", int.Parse(txtKiraÜcreti.Text));
            komut.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut.Parameters.AddWithValue("@durum", "MÜSAİT");
            aracKiralama.EkleSilGüncelle(komut, cümle);
            cmbSeri.Items.Clear();
            MessageBox.Show("Araç başarı ile eklendi...");
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox1.ImageLocation = "";
        }
    }
}
