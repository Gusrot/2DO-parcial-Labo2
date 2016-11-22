using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eje5
{
    public partial class Form1 : Form
    {

        int ingrosenumero;
        int randomNUM;
        int intento=1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Random randomm = new Random();
            randomNUM = randomm.Next(1,100);
            MessageBox.Show("ATR!!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ingrosenumero == randomNUM)
                MessageBox.Show("Ganaste!!!!");
            else
            {
                //MessageBox.Show("Segui participando");
                this.txtBIntentos.Text = Convert.ToString(intento);
                if (ingrosenumero < randomNUM)
                    MessageBox.Show("Te falta maquina");
                else
                    MessageBox.Show("Baja un cambio lince");
            }
            intento++;
        }
        

        private void txtBingreseNum_TextChanged(object sender, EventArgs e)
        {
            ingrosenumero = int.Parse(txtBingreseNum.Text);
        }

        private void txtBIntentos_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
