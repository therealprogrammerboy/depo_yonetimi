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
    public partial class frmStok : Form
    {
        public frmStok()
        {
            InitializeComponent();
        }

        private void frmStok_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'depo_yonetimiDataSet1.stok_urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.stok_urunTableAdapter.Fill(this.depo_yonetimiDataSet1.stok_urun);
            // TODO: Bu kod satırı 'depo_yonetimiDataSet.stok' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           

        }
    }
}
