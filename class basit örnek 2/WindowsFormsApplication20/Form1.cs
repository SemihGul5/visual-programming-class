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

namespace WindowsFormsApplication20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ad = new ArrayList();
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ad.Add(textBox1.Text);
            ad.Add(textBox2.Text);
            ad.Add(Convert.ToInt32(textBox3.Text));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in ad)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
