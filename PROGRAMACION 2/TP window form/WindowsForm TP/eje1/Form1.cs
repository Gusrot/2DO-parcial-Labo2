using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eje1
{
    public partial class Form1 : Form
    {
        float num1, num2, num3,resultado,promedio,resultFinal;

        public Form1()
        {
            InitializeComponent();
        }
        //2 text box
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            num2 = int.Parse(this.textBoxIngrese1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //1 text box
        private void textBoxIngrese1_TextChanged(object sender, EventArgs e)
        {
            num1 = int.Parse(this.textBoxIngrese1.Text);
        }
        //3 text box
        private void textBoxIngrese3_TextChanged(object sender, EventArgs e)
        {
            num3 = int.Parse(this.textBoxIngrese1.Text);
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            resultado = num1 + num2 + num3;
            MessageBox.Show("La suma es: "+resultado);
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            promedio = (num1 + num2 + num3)/3;
            MessageBox.Show("El promedio es: " + promedio);
        }

        private void btnPrecioFinal_Click(object sender, EventArgs e)
        {
            resultFinal = (num1 + num2 + num3) *0.21f;
            MessageBox.Show("El promedio es: " + resultFinal);
        }
    }
}
