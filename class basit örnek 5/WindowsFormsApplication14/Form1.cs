using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class bisiklet
        {
            public int hiz = 0;
            public int vites = 1;
            public void hizarttir(int artis)
            {
                hiz = artis;
            }
            public void vitesarttir(int arttir)
            {
                vites = vites + arttir;
            }
            public void bilgileriyaz()
            {
                MessageBox.Show("hız:"+hiz+""+"vites:"+vites);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ev nesne = new ev();
            nesne.sigortadeger(5789);
            nesne.sigortadurum("sigortası var");
            nesne.bilgileriyaz();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bisiklet nesne1 = new bisiklet();
            nesne1.hizarttir(80);
            nesne1.vitesarttir(3);
            nesne1.bilgileriyaz();
        }
    }
}
