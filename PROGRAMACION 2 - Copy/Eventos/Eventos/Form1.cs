using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaEventos;

namespace Eventos
{
    public partial class Form1 : Form
    {
        public Cuenta cuenta;

        public Form1()
        {
            InitializeComponent();
            this.cuenta = new Cuenta();
            this.cuenta.saldoNegativo += this.mostrarSaldoNegativoDeLaCuenta;
        }

        public void mostrarSaldoNegativoDeLaCuenta(float dinero)
        {
            MessageBox.Show(dinero.ToString());
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.cuenta.SacarDinero(1000);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("textBox1_KeyPress");
        }
        private void textBox1_KeyPress2(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("textBox1_KeyPress2");
        }
        private void mio(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("mio");
        }
    }
}
