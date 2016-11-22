using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteFacturacion
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;
        int resultado;
        int promedio;
        float iva;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           num1 = int.Parse(this.txtIngreseNum1.Text);
            //MessageBox.Show(aux);
        }

        private void txtIngreseNum2_TextChanged(object sender, EventArgs e)
        {
            num2 = int.Parse(this.txtIngreseNum2.Text);
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            resultado = num1 + num2;
            MessageBox.Show("EL resultado es: "+resultado);
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            promedio = (num1+num2) / 2;
            MessageBox.Show("EL Promedio es: " + promedio);
        }

        private void btnPrecioFinal_Click(object sender, EventArgs e)
        {
            iva = (num2 + num2)*0.21f;
            MessageBox.Show("EL Precio Final es: " + iva);
        }
    }
}
