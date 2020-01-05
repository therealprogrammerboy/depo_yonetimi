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
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'depo_yonetimiDataSet2.stok_urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.stok_urunTableAdapter.Fill(this.depo_yonetimiDataSet2.stok_urun);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            String urunAdi = comboBox1.Text, fiyat = txtFiyat.Text, miktar = txtMiktar.Text;
            DateTime dt = dateTimePicker1.Value;
            string tarihi = dt.ToString();

            String url = "Data Source=DESKTOP-6K8V3U6;Initial Catalog=depo_yonetimi; Integrated Security=true;";
            SqlConnection baglanti = new SqlConnection(url);
            baglanti.Open();
            string sorgu = "insert into satis_urun(fiyat,isim,miktar,tarih) values('"+fiyat+"','"+urunAdi+"','"+miktar+"','"+tarihi+"') ";
            //string sorgu2 = "";
            
            SqlCommand cmd = new SqlCommand(sorgu, baglanti);
            //SqlCommand cmd2 = new SqlCommand(sorgu2, baglanti);
            cmd.ExecuteNonQuery();
            //cmd2.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarılı !");
            baglanti.Close();


        }
    }
}
