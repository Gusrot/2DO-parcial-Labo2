using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eje8
{
    public partial class Form1 : Form
    {

        private int opcion;
        private int random;
        private Random rng;

        int gano;
        int perdio;
        int empato;

        public Form1()
        {
            InitializeComponent();
        }

        private void IniciarJuego()
        {
            rng = new Random();
            random = rng.Next(1, 6);
            opcion = 0;
        }


        private void btnPiedra_Click(object sender, EventArgs e)
        {
            IniciarJuego();

            switch (random)
            {
                case 1:
                case 4:
                    empato++;
                    MessageBox.Show("Usted Empato");
                    this.txtbEmpato.Text = "Usted empato " + empato + " veces";
                    break;
                case 2:
                case 5:
                    perdio++;
                    MessageBox.Show("Usted perdio");
                    this.txtbPerdio.Text = "Usted perdio " + perdio + " veces";
                    break;
                case 3:
                case 6:
                    gano++;
                    MessageBox.Show("Usted gano");
                    this.txtbGano.Text = "Usted gano " + gano + " veces";
                    break;

            }

            
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            IniciarJuego();

            switch (random)
            {
                case 1:
                case 4:
                    empato++;
                    MessageBox.Show("Usted Empato");
                    this.txtbEmpato.Text = "Usted empato " + empato + " veces";
                    break;
                case 2:
                case 5:
                    perdio++;
                    MessageBox.Show("Usted perdio");
                    this.txtbPerdio.Text = "Usted perdio " + perdio + " veces";
                    break;
                case 3:
                case 6:
                    gano++;
                    MessageBox.Show("Usted gano");
                    this.txtbGano.Text = "Usted gano " + gano + " veces";
                    break;

            }
        }

        private void btnTijera_Click(object sender, EventArgs e)
        {
            IniciarJuego();

            switch (random)
            {
                case 1:
                case 4:
                    empato++;
                    MessageBox.Show("Usted Empato");
                    this.txtbEmpato.Text = "Usted empato " + empato + " veces";
                    break;
                case 2:
                case 5:
                    perdio++;
                    MessageBox.Show("Usted perdio");
                    this.txtbPerdio.Text = "Usted perdio " + perdio + " veces";
                    break;
                case 3:
                case 6:
                    gano++;
                    MessageBox.Show("Usted gano");
                    this.txtbGano.Text = "Usted gano " + gano + " veces";
                    break;

            }
        }

        private void txtbGano_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
