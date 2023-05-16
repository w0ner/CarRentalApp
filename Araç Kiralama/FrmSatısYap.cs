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
    public partial class FrmSatısYap : Form
    {
        public FrmSatısYap()
        {
            InitializeComponent();
        }

        AracKiralama arac = new AracKiralama();

        private void FrmSatısYap_Load(object sender, EventArgs e)
        {
            MüsaitAraçlar();
            Yenile();
        }

        private void MüsaitAraçlar()
        {
            string sorgu2 = "select * from Araç Where durum ='MÜSAİT'";
            arac.MüsaitAraçlar(cmbMüsaitArac, sorgu2);
        }

        private void Yenile()
        {
            string sorgu3 = "select * from SatışYap";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, sorgu3);
            dataGridView1.Columns["ID"].Visible = false;
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMüsaitArac_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select * from Araç Where Plaka like '" + cmbMüsaitArac.SelectedItem + "'";
            arac.CombodanGetir(cmbMüsaitArac, txtMarka, txtSeri, txtModel, txtRenk, sorgu2);
        }

        private void cmbKiraSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select * from Araç Where Plaka like '" + cmbMüsaitArac.SelectedItem + "'";
            arac.ÜcretHesapla(cmbKiraSekli, txtKiraÜcreti, sorgu2);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan toplamgun = DateTime.Parse(DateDönüş.Text) - DateTime.Parse(DateÇıkış.Text);
            int toplamgun2 = toplamgun.Days;
            txtToplamGün.Text = toplamgun2.ToString();
            txtToplamTutar.Text = (toplamgun2 * int.Parse(txtKiraÜcreti.Text)).ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            DateÇıkış.Text = DateTime.Now.ToShortDateString();
            DateDönüş.Text = DateTime.Now.ToShortDateString();
            cmbKiraSekli.Text = "";
            txtKiraÜcreti.Text = "";
            txtToplamGün.Text = "";
            txtToplamTutar.Text = "";
        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into SatışYap(Tc,AdSoyad,Telefon,EhliyetNo,ETarihi,EYer,Plaka,Marka,Seri,Yıl,Renk,KiraSekli,Ücreti,Gün,Tutar,CTarih,DTarih) values(@Tc,@AdSoyad,@Telefon,@EhliyetNo,@ETarihi,@EYer,@Plaka,@Marka,@Seri,@Yıl,@Renk,@KiraSekli,@Ücreti,@Gün,@Tutar,@CTarih,@DTarih)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@EhliyetNo", txtEhliyetNo.Text);
            komut.Parameters.AddWithValue("@ETarihi", txtETarihi.Text);
            komut.Parameters.AddWithValue("@EYer", txtEVerilişYeri.Text);
            komut.Parameters.AddWithValue("@Plaka", cmbMüsaitArac.Text);
            komut.Parameters.AddWithValue("@Marka", txtMarka.Text);
            komut.Parameters.AddWithValue("@Seri", txtSeri.Text);
            komut.Parameters.AddWithValue("@yıl", txtModel.Text);
            komut.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@KiraSekli", cmbKiraSekli.Text);
            komut.Parameters.AddWithValue("@Ücreti", int.Parse(txtKiraÜcreti.Text));
            komut.Parameters.AddWithValue("@Gün", int.Parse(txtToplamGün.Text));
            komut.Parameters.AddWithValue("@Tutar", int.Parse(txtToplamTutar.Text));
            komut.Parameters.AddWithValue("@CTarih", DateÇıkış.Text);
            komut.Parameters.AddWithValue("@DTarih", DateDönüş.Text);
            arac.EkleSilGüncelle(komut, sorgu2);
            string sorgu3 = "Update Araç set Durum='DOLU' Where Plaka= '" + cmbMüsaitArac.Text + "'";
            SqlCommand komut3 = new SqlCommand();
            arac.EkleSilGüncelle(komut3, sorgu3);
            cmbMüsaitArac.Items.Clear();
            MüsaitAraçlar();
            Yenile();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            cmbMüsaitArac.Text = "";
            Temizle();
            MessageBox.Show("Satış başarı ile yapıldı. Güncelleme yapmak için işleminize tablo üzerinde çift tıklayın.");
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            if (txtTcAra.Text == "") foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            string sorgu2 = "select * from Müşteri Where Tc like '" + txtTcAra.Text + "'";
            arac.TcAra(txtTcAra, txtTc, txtAdSoyad, txtTelefon, sorgu2);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update SatışYap set tc=@tc,adsoyad=@adsoyad,telefon=@telefon,ehliyetno=@ehliyetno,etarihi=@etarihi,eyer=@EYer,marka=@Marka,seri=@Seri,yıl=@Yıl,renk=@renk,kirasekli=@KiraSekli,Ücreti=@Ücreti,Gün=@Gün,Tutar=@Tutar,CTarih=@CTarih,DTarih=@DTarih Where Plaka=@plaka";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@EhliyetNo", txtEhliyetNo.Text);
            komut.Parameters.AddWithValue("@ETarihi", txtETarihi.Text);
            komut.Parameters.AddWithValue("@EYer", txtEVerilişYeri.Text);
            komut.Parameters.AddWithValue("@Plaka", cmbMüsaitArac.Text);
            komut.Parameters.AddWithValue("@Marka", txtMarka.Text);
            komut.Parameters.AddWithValue("@Seri", txtSeri.Text);
            komut.Parameters.AddWithValue("@yıl", txtModel.Text);
            komut.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@KiraSekli", cmbKiraSekli.Text);
            komut.Parameters.AddWithValue("@Ücreti", int.Parse(txtKiraÜcreti.Text));
            komut.Parameters.AddWithValue("@Gün", int.Parse(txtToplamGün.Text));
            komut.Parameters.AddWithValue("@Tutar", int.Parse(txtToplamTutar.Text));
            komut.Parameters.AddWithValue("@CTarih", DateÇıkış.Text);
            komut.Parameters.AddWithValue("@DTarih", DateDönüş.Text);
            arac.EkleSilGüncelle(komut, sorgu2);
            cmbMüsaitArac.Items.Clear();
            MüsaitAraçlar();
            Yenile();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            cmbMüsaitArac.Text = "";
            Temizle();
            MessageBox.Show("Satış başarılı bir şekilde Güncellendi..");
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTc.Text = satır.Cells[1].Value.ToString();
            txtAdSoyad.Text = satır.Cells[2].Value.ToString();
            txtTelefon.Text = satır.Cells[3].Value.ToString();
            txtEhliyetNo.Text = satır.Cells[4].Value.ToString();
            txtETarihi.Text = satır.Cells[5].Value.ToString();
            txtEVerilişYeri.Text = satır.Cells[6].Value.ToString();
            cmbMüsaitArac.Text = satır.Cells[7].Value.ToString();
            txtMarka.Text = satır.Cells[8].Value.ToString();
            txtSeri.Text = satır.Cells[8].Value.ToString();
            txtModel.Text = satır.Cells[10].Value.ToString();
            txtRenk.Text = satır.Cells[11].Value.ToString();
            cmbKiraSekli.Text = satır.Cells[12].Value.ToString();
            txtKiraÜcreti.Text = satır.Cells[13].Value.ToString();
            txtToplamGün.Text = satır.Cells[14].Value.ToString();
            txtToplamTutar.Text = satır.Cells[15].Value.ToString();
            DateÇıkış.Text = satır.Cells[16].Value.ToString();
            DateDönüş.Text = satır.Cells[17].Value.ToString();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            //Gün Farkı Hesapla
            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime dönüş = DateTime.Parse(satır.Cells["DTarih"].Value.ToString());
            int ucret = int.Parse(satır.Cells["Ücreti"].Value.ToString());
            TimeSpan gunfarkı = bugün - dönüş;
            int _gunfarkı = gunfarkı.Days;
            int ucretfarkı;
            //Ücret Farkı Hesapla
            ucretfarkı = _gunfarkı * ucret;
            txtEkstra.Text = ucretfarkı.ToString();
            //Toplam Tutar Hesapla
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            if (txtEkstra.Text != "")
            {
                DataGridViewRow satır = dataGridView1.CurrentRow;
                DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
                int ucret = int.Parse(satır.Cells["Ücreti"].Value.ToString());
                int tutar = int.Parse(satır.Cells["Tutar"].Value.ToString());
                DateTime çıkış = DateTime.Parse(satır.Cells["CTarih"].Value.ToString());
                TimeSpan gun = bugün - çıkış;
                int _gun = gun.Days;
                int toplamtutar = _gun * ucret;
                //Toplam Tutar,_gun ve ucret satış tablosuna aktarılacak
                string sorgu1 = "delete from SatışYap where Plaka='" + satır.Cells["Plaka"].Value.ToString() + "'";
                SqlCommand komut = new SqlCommand();
                arac.EkleSilGüncelle(komut, sorgu1);
                string sorgu2 = "Update Araç set Durum='MÜSAİT' where Plaka='" + satır.Cells["Plaka"].Value.ToString() + "'";
                SqlCommand komut2 = new SqlCommand();
                arac.EkleSilGüncelle(komut2, sorgu2);


                string sorgu3 = "insert into Kasa(Tc,AdSoyad,Plaka,Marka,Seri,Yıl,Renk,Gün,Ücret,Tutar,Tarih1,Tarih2) values(@Tc,@AdSoyad,@Plaka,@Marka,@Seri,@Yıl,@Renk,@Gün,@Ücret,@Tutar,@Tarih1,@Tarih2)";
                SqlCommand komut3 = new SqlCommand();
                komut3.Parameters.AddWithValue("@tc", satır.Cells["Tc"].Value.ToString());
                komut3.Parameters.AddWithValue("@adsoyad", satır.Cells["AdSoyad"].Value.ToString());
                komut3.Parameters.AddWithValue("@Plaka", satır.Cells["Plaka"].Value.ToString());
                komut3.Parameters.AddWithValue("@Marka", satır.Cells["Marka"].Value.ToString());
                komut3.Parameters.AddWithValue("@Seri", satır.Cells["Seri"].Value.ToString());
                komut3.Parameters.AddWithValue("@yıl", satır.Cells["Yıl"].Value.ToString());
                komut3.Parameters.AddWithValue("@renk", satır.Cells["Renk"].Value.ToString());
                komut3.Parameters.AddWithValue("@Gün", _gun);
                komut3.Parameters.AddWithValue("@Ücret", ucret);
                komut3.Parameters.AddWithValue("@Tutar", toplamtutar);
                komut3.Parameters.AddWithValue("@Tarih1", satır.Cells["ctarih"].Value.ToString());
                komut3.Parameters.AddWithValue("@Tarih2", DateTime.Now.ToShortDateString());
                arac.EkleSilGüncelle(komut3, sorgu3);
                MessageBox.Show("Araç Teslim Edildi..");
                cmbMüsaitArac.Text = "";
                cmbMüsaitArac.Items.Clear();
                MüsaitAraçlar();
                Yenile();
                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                cmbMüsaitArac.Text = "";
                Temizle();
                txtEkstra.Text = "";
            }
            else if (txtEkstra.Text == "")
            {
                MessageBox.Show("Lütfen seçim yapınız", "Uyarı..!");
            }
        }

        private void btnMusterıler_Click(object sender, EventArgs e)
        {
            FrmMüsteriler frmMüsteriler = new FrmMüsteriler();
            frmMüsteriler.Show();
            this.Hide();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            FrmKasa frmKasa = new FrmKasa();
            frmKasa.Show();
            this.Hide();
        }

        private void btnAraclar_Click(object sender, EventArgs e)
        {
            FrmAraclar frmAraclar = new FrmAraclar();
            frmAraclar.Show();
            this.Hide();
        }
    }
}
