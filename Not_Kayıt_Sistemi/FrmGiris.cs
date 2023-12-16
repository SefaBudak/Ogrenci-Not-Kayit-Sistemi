using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Kayıt_Sistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_OGRENCİ_DETAY frm = new FRM_OGRENCİ_DETAY();
            frm.numara = maskedTextBox1.Text;
            frm.Show();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "1111")
            {
                FRMOGRETMENDETAY fr = new FRMOGRETMENDETAY();
                fr.Show();
            }
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
