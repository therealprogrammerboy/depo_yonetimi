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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            int gelenId = Convert.ToInt32(txtId.Text), gelenPwd = Convert.ToInt32(txtPwd.Text);
            if (gelenId==1 && gelenPwd==1)
            {
                MessageBox.Show("Başarılı Giriş!");
                frmAnaEkran yeni = new frmAnaEkran();
                yeni.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş!");
            }
        }
    }
}
