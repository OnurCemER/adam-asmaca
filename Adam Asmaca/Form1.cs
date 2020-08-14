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
    public partial class Form1 : Form
    {
        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                        
            if (txtAd.Text != "" && txtSoyad.Text != "")
            {
                Form2 form2 = new Form2();
                SkorYaz skor = new SkorYaz();
                skor.oyuncuBilgileri(txtAd.Text,txtSoyad.Text);
                form2.Show();
                
            }
            else 
            {
                MessageBox.Show("Lütfen Ad Soyad Girin!");
            }
            
     }
        
        private void btnKelimeEkle_Click(object sender, EventArgs e)
        {
            FormYeniKelimeEkle yeniKelime = new FormYeniKelimeEkle();
            yeniKelime.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTopScorers_Click(object sender, EventArgs e)
        {
            Skorlar formSkor = new Skorlar();
            formSkor.Show();
        }

        

        
    }
}
