using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eje6
{
    public partial class Form1 : Form
    {
        int ingrosenumero;
        int randomNUM;
        int intento;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtBingreseNum_TextChanged(object sender, EventArgs e)
        {
            ingrosenumero = int.Parse(txtBingreseNum.Text);
        }

        private void txtBIntentos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            intento++;
            if (ingrosenumero == randomNUM)
            {
                MessageBox.Show("Ganaste!!!!");
                switch (intento)
                {
                    case 1:
                        MessageBox.Show("1° intento: “usted es un Psíquico”.");
                        break;
                    case 2:
                        MessageBox.Show("2° intento: “excelente percepción”. ");
                        break;
                    case 3:
                        MessageBox.Show("3° intento: “Esto es suerte”.  ");
                        break;
                    case 4:
                        MessageBox.Show("4° intento: “Excelente técnica”. ");
                        break;
                    case 5:
                        MessageBox.Show("5° intento: “usted está en la media”.  ");
                        break;
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        MessageBox.Show("Afortunado en el amor! ");
                        break;
                    default:
                        MessageBox.Show("Falta tecnica");
                        break;
                }
            }
            else
            {
                this.txtBIntentos.Text = Convert.ToString(intento);
                if (ingrosenumero < randomNUM)
                    MessageBox.Show("Te falta maquina");
                else
                    MessageBox.Show("Baja un cambio lince");
            }
            

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random randomm = new Random();
            randomNUM = randomm.Next(1, 100);
            MessageBox.Show("ATR!!!");
            intento=0;
        }
    }
}
