using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Adam_Asmaca
{
    class KelimeEkle
    {
        public void Ekle(string kelime)
        {
            StreamWriter dosya = File.AppendText("KelimeDeposu.txt");
            dosya.Write(kelime + "\n");
            dosya.Close();
            
        }
	   
    }
}
