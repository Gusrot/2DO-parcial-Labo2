using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eje3
{
    public partial class Form1 : Form
    {

        double temperatura,f,c;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtbIngresoTemperatura_TextChanged(object sender, EventArgs e)
        {
            temperatura = double.Parse(txtbIngresoTemperatura.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c = temperatura;
            f = (c * 1.8) + 32;
            MessageBox.Show("De Centigrados a Fahrenheit: " + f);
        }

        private void btnFaC_Click(object sender, EventArgs e)
        {
            f = temperatura;
            c = (f - 32) / 1.8;

            MessageBox.Show("De Fahrenheit a Centigrados: "+ c);
        }
    }
}
