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
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }

        AracKiralama arac = new AracKiralama();

        private void FrmKasa_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from Kasa";
            SqlDataAdapter adtr = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr, sorgu);
            arac.SatışHesapla(label1);
        }

        private void btnMusterıler_Click(object sender, EventArgs e)
        {
            FrmMüsteriler frmMüsteriler = new FrmMüsteriler();
            frmMüsteriler.Show();
            this.Hide();
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
    }
}
