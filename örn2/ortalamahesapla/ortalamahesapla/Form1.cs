using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ortalamahesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            double y1=Convert.ToDouble(txtyazili1.Text);
            double y2=Convert.ToDouble(txtyazili2.Text);
            Ortalama ortalama=new Ortalama(y1,y2);
            txtortalama.Text=ortalama.ortalamaHesapla().ToString();












        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtortalama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtyazili2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtyazili1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
