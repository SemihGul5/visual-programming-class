using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication18
{
    class ev
    {
        int sigortabedel = 0;
        string sigortadurumu;
        public void sigortadeger(int deger)
        {
            sigortabedel = deger;
        }
        public void sigortadurum(string durum)
        {
            sigortadurumu = durum;
        }
        public void bilgileriyaz()
        {
            MessageBox.Show("Sigorta bedeli: "+sigortabedel+" Sigorta durumu: "+sigortadurumu);
        }
    }
}
