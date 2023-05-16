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
    public partial class FrmAraclar : Form
    {
        AracKiralama aracKiralama = new AracKiralama();
        public FrmAraclar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAracEkle ekle = new FrmAracEkle();
            ekle.Show();
        }

        private void btnMusterıler_Click(object sender, EventArgs e)
        {
            FrmMüsteriler frmMüsteriler = new FrmMüsteriler();
            frmMüsteriler.Show();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtPlaka.Text = satır.Cells["plaka"].Value.ToString();
            cmbMarka.Text = satır.Cells["marka"].Value.ToString();
            cmbSeri.Text = satır.Cells["seri"].Value.ToString();
            txtModel.Text = satır.Cells["yıl"].Value.ToString();
            txtRenk.Text = satır.Cells["renk"].Value.ToString();
            txtKm.Text = satır.Cells["km"].Value.ToString();
            cmbYakıt.Text = satır.Cells["yakıt"].Value.ToString();
            txtFiyat.Text = satır.Cells["ücret"].Value.ToString();
            pictureBox1.ImageLocation = satır.Cells["resim"].Value.ToString();

        }

        private void FrmAraclar_Load(object sender, EventArgs e)
        {
            YenileAraçlarListesi();
            
                comboBox1.SelectedIndex = 0;
          
        }

        private void YenileAraçlarListesi()
        {
            string cümle = "select * from araç";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = aracKiralama.listele(adtr2, cümle);
            dataGridView1.Columns["ID"].Visible = false;
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update araç set marka=@marka,seri=@seri,yıl=@yıl,renk=@renk,km=@km,yakıt=@yakıt,ücret=@ücret,resim=@resim,tarih=@tarih where plaka=@plaka";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komut.Parameters.AddWithValue("@marka", cmbMarka.Text);
            komut.Parameters.AddWithValue("@seri", cmbSeri.Text);
            komut.Parameters.AddWithValue("@yıl", txtModel.Text);
            komut.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@km", txtKm.Text);
            komut.Parameters.AddWithValue("@yakıt", cmbYakıt.Text);
            komut.Parameters.AddWithValue("@ücret", int.Parse(txtFiyat.Text));
            komut.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            aracKiralama.EkleSilGüncelle(komut, cümle);
            cmbSeri.Items.Clear();
            MessageBox.Show("Araç başarı ile Güncellendi...");
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox1.ImageLocation = "";
            YenileAraçlarListesi();
        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from araç where plaka= '" + satır.Cells["plaka"].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand();
            aracKiralama.EkleSilGüncelle(komut, cümle);
            YenileAraçlarListesi();
            pictureBox1.ImageLocation = "";
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    YenileAraçlarListesi();
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    string cümle = "select * from araç where durum='MÜSAİT'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = aracKiralama.listele(adtr2, cümle);
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    string cümle = "select * from araç WHERE durum='DOLU'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = aracKiralama.listele(adtr2, cümle);
                }
            }
            catch 
            {
                ;
               
            }
        }

        private void btnSatısYap_Click(object sender, EventArgs e)
        {
            FrmSatısYap frmSatısYap = new FrmSatısYap();
            frmSatısYap.Show();
            this.Hide();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            FrmKasa frmKasa = new FrmKasa();
            frmKasa.Show();
            this.Hide();
        }
    }
}
