using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adam_Asmaca
{
    public partial class FormYeniKelimeEkle : Form
    {
        public FormYeniKelimeEkle()
        {
            InitializeComponent();
        }

       

        private void btnYeniKelimeEkle_Click(object sender, EventArgs e)
        {
            KelimeEkle ekle = new KelimeEkle();
            ekle.Ekle(txtEkle.Text.ToUpper());
            MessageBox.Show("Kelime Eklendi");
            txtEkle.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
