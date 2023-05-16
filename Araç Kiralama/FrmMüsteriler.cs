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
    public partial class FrmMüsteriler : Form
    {
        AracKiralama aracKiralama = new();
        public FrmMüsteriler()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa anaSayfa = new();
            anaSayfa.Show();
            this.Hide();
        }

        private void btnMüsEkle_Click(object sender, EventArgs e)
        {
            FrmMüsteriEkle frmMüsteriEkle = new();
            frmMüsteriEkle.Show();
        }

        private void FrmMüsteriler_Load(object sender, EventArgs e)
        {
            YenileListele();
        }

        private void YenileListele()
        {
            string cümle = "Select * from Müşteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = aracKiralama.listele(adtr2, cümle);
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["AdSoyad"].HeaderText = "Adı Soyadı";
            dataGridView1.Columns["Telefon"].HeaderText = "Telefon No";
            dataGridView1.Columns["Email"].HeaderText = "E-Posta";
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string cümle = "Select * from Müşteri Where Tc like '%"+txtArama.Text+"%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = aracKiralama.listele(adtr2, cümle);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTC.Text = satır.Cells[1].Value.ToString();
            txtAdSoyad.Text = satır.Cells[2].Value.ToString();
            txtTelefon.Text = satır.Cells[3].Value.ToString();
            txtMail.Text = satır.Cells[4].Value.ToString();
            txtAdres.Text = satır.Cells[5].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string cümle = "Update Müşteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@tc";
            SqlCommand komut = new();
            komut.Parameters.AddWithValue("@tc", txtTC.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtMail.Text);
            aracKiralama.EkleSilGüncelle(komut, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            MessageBox.Show("Müşteri başarı ile Güncellendi...");
            YenileListele();
        
              
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from Müşteri where tc='" + satır.Cells["TC"].Value.ToString()+"'";
            SqlCommand komut = new();
            aracKiralama.EkleSilGüncelle(komut, cümle);
            MessageBox.Show("Müşteri başarı ile Silindi...");
            YenileListele();
        }

        private void btnAraclar_Click(object sender, EventArgs e)
        {
            FrmAraclar frmAraclar = new FrmAraclar();
            frmAraclar.Show();
            this.Hide();
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
