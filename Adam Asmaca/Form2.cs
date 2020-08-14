using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Adam_Asmaca
{
    public partial class Form2 : Form
    {
        Form1 form1 = new Form1();
        public Form2()
        {
            InitializeComponent();
        }

        private int kalanHak;
        private string secilenKelime;
        private string[] harfler;
        private int bilinenHarfler=0;
        public int skor = 0;
        int x = 30, y = 31;
        List<TextBox> txtList = new List<TextBox>();
        //private string[] metin;
        TextBox txt;
        Button secim;
        SkorYaz skorlar;
        private void btnTahmin_Click(object sender, EventArgs e)
        {
            secim = (Button)sender;
            for (int i = 0; i < secilenKelime.Length; i++)
            {
                if (secim.Text==harfler[i])
                {
                    foreach (TextBox txt in txtList)
                    {
                        txtList[i].Text = secim.Text;
                    }
                    secim.Enabled = false;
                    
                    secim.BackColor = System.Drawing.Color.Green;
                    bilinenHarfler++;
                    skor += 20;
                    if (skor == secilenKelime.Length*20)
                    {
                        MessageBox.Show("Tebrikler Oyunu Bitirdiniz!\n"+"Skorunuz kaydedildi: "+skor);
                        skorlar = new SkorYaz();
                        skorlar.oyuncuSkor(skor);
                        skorlar.skorYaz();
                    }
                }
            }
            if (secim.BackColor != System.Drawing.Color.Green)
            {
                secim.BackColor = System.Drawing.Color.Red;
                secim.Enabled = false;
                kalanHak--;
                label1.Text = kalanHak.ToString();
                if (kalanHak==0)
                {
                    MessageBox.Show("Oyunu Kaybettiniz\n"+"Skorunuz Kaydedildi: "+skor);
                    skorlar = new SkorYaz();
                    skorlar.skorYaz();
                    this.Close();
                }
            }
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] kelimeOkuyucu = File.ReadAllLines("KelimeDeposu.txt");
            
            Random rand = new Random();
            secilenKelime = kelimeOkuyucu[rand.Next(kelimeOkuyucu.Length)];
            MessageBox.Show(secilenKelime);
            txt = new TextBox();

            for (int i = 0; i < secilenKelime.Length; i++)
            {
                txt = new TextBox();
                txt.Size = new Size(35, 37);
                txt.Location = new Point(x, y);
                txt.Name = i.ToString();
                txt.Enabled = false;
                this.Controls.Add(txt);
                txtList.Add(txt);
                x += 41;
            }
            
            harfler = new string[secilenKelime.Length];
            
            kalanHak = secilenKelime.Length + 2;
            label1.Text = kalanHak.ToString();
            diziyeAt();

            
            
        }

        
        void diziyeAt() 
        {
            for (int i = 0; i < secilenKelime.Length; i++)
            {
                harfler[i] = secilenKelime.Substring(i,1);
            }

        }

       
        
    }
}
