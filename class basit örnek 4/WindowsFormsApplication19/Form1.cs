using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList dizi = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            kayit eklenecekkayit = new kayit();
            eklenecekkayit.ad = textBox1.Text;
            eklenecekkayit.soyad = textBox2.Text;
            dizi.Add(eklenecekkayit);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (kayit item in dizi)
            {
                listBox1.Items.Add(item.ad+"   "+item.soyad);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
