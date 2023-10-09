using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication17
{
    class islem
    {
        public int a;
        public int b;
        public int sonucc;
        public void islem1(int deger1)
        {
            a = deger1;
        }
        public void islem2(int deger2)
        {
            b = deger2;
        }
        public void toplama(int sonuc)
        {
            sonucc = a + b;
        }
        public void yaz()
        {
            System.Windows.Forms.MessageBox.Show(sonucc.ToString());
        }


    }
}
