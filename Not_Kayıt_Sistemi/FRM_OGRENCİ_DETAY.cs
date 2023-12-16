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

namespace Not_Kayıt_Sistemi
{
    public partial class FRM_OGRENCİ_DETAY : Form
    {
        public FRM_OGRENCİ_DETAY()
        {
            InitializeComponent();
        }

        
        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public string numara;

        SqlConnection baglanti=new SqlConnection(@"Data Source=DESKTOP-U1QPTUU\SQLEXPRESS;Initial Catalog=DbNotKayıt;Integrated Security=True;Encrypt=False");
        private void FRM_OGRENCİ_DETAY_Load(object sender, EventArgs e)
        {
            lblnumara.Text = numara;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLDERS where OGRNUMARA=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                lblsınav1.Text = dr[4].ToString();
                lblsınav2.Text = dr[5].ToString();
                lblsınav3.Text = dr[6].ToString();
                lblOrtalama.Text = dr[7].ToString();
                lblDurum.Text = dr[8].ToString();

                if (dr[8].ToString() == "True") 
                {
                    lblDurum.Text = "Geçti";
                }
                else 
                {
                    lblDurum.Text = "Kaldı";
                }


            }
            baglanti.Close();
        }

        private void lblDurum_Click(object sender, EventArgs e)
        {

        }

        private void lblAdSoyad_Click(object sender, EventArgs e)
        {

        }
    }
}
