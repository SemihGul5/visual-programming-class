using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ev nesne = new ev();
            nesne.sigortadeger(Convert.ToInt32(textBox1.Text));
            nesne.sigortadurum(textBox2.Text);
            nesne.bilgileriyaz();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
