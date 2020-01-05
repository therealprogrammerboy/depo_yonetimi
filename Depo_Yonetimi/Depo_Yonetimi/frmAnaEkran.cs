using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depo_Yonetimi
{
    public partial class frmAnaEkran : Form
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        private void gelenUrunKayit_Click(object sender, EventArgs e)
        {
            frmGelen yeni = new frmGelen();
            yeni.Show();
        }

        private void satis_Click(object sender, EventArgs e)
        {
            frmSatis yeni = new frmSatis();
            yeni.Show();
        }

        private void stok_Click(object sender, EventArgs e)
        {
            frmStok yeni = new frmStok();
            yeni.Show();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            frmArama yeni = new frmArama();
            yeni.Show();
        }
    }
}
