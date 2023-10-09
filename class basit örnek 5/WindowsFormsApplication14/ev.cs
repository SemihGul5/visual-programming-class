using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace WindowsFormsApplication14
{
    class ev
    {
        public int sigortabedeli = 0;
        public string sigortadurumu;
        public void sigortadeger(int deger)
        {
            sigortabedeli = deger;
        }
        public void sigortadurum(string durum)
        {
            sigortadurumu = durum;
        }
        public void bilgileriyaz()
        {
            MessageBox.Show("sigorta bedeli"+sigortabedeli.ToString());
            MessageBox.Show("sigorta durumu"+sigortadurumu);
        }
    }
   
}
