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
    public partial class frmGelen : Form
    {
        public frmGelen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adi = txtUrunAdi.Text, adett = txtUrunAdedi.Text, fiyati = txtUrunFiyati.Text;
            int adet = Convert.ToInt32(adett);
            DateTime dt = dateTimePicker1.Value;
            string tarihi = dt.ToString();
            String url = "Data Source=DESKTOP-6K8V3U6;Initial Catalog=depo_yonetimi; Integrated Security=true;";
            SqlConnection baglanti = new SqlConnection(url);
            baglanti.Open(); 
            string sorgu= "insert into gelen_urun(gelen_aded,gelen_isim,fiyat,tarih) values("+adet+",'"+adi+"','"+fiyati+"','"+tarihi+"')";
            string sorgu2 = "insert into stok_urun(adet,isim) values("+adet+",'"+adi+"')";
            SqlCommand cmd = new SqlCommand(sorgu,baglanti);
            SqlCommand cmd2 = new SqlCommand(sorgu2, baglanti);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarılı !");
            baglanti.Close();
            //MessageBox.Show(tarihi);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
        }
    }
}
