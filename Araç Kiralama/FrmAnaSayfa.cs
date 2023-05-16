using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_Kiralama
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMusterıler_Click(object sender, EventArgs e)
        {
            FrmMüsteriler frmMüsteriler = new();
            frmMüsteriler.Show();
            this.Hide();
           
        }

        private void btnAraclar_Click(object sender, EventArgs e)
        {
            FrmAraclar frmAraclar=new FrmAraclar();
            frmAraclar.Show();
            this.Hide();
        }

        private void btnSatısYap_Click(object sender, EventArgs e)
        {
            FrmSatısYap frmSatısYap=new FrmSatısYap();
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
