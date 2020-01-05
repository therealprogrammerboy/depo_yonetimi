using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Depo_Yonetimi
{
    public partial class frmArama : Form
    {
        public frmArama()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6K8V3U6;Initial Catalog=depo_yonetimi;Integrated Security=True");
        private void goster()
        {
            string isim = textBox1.Text;

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from stok_urun where isim like '%"+isim+"%' ",baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["adet"].ToString();
                ekle.SubItems.Add(oku["isim"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            goster();
        }
    }
}
