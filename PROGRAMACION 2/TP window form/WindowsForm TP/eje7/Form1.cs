using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eje7
{
    public partial class Form1 : Form
    {

        private int opcion;
        private int random;
        private Random rng;

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
                    MessageBox.Show("Usted Empato");
                    break;
                case 2:
                case 5:
                    MessageBox.Show("Usted perdio");
                    break;
                case 3:
                case 6:
                    MessageBox.Show("Usted gano");
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
                    MessageBox.Show("Usted Empato");
                    break;
                case 2:
                case 5:
                    MessageBox.Show("Usted perdio");
                    break;
                case 3:
                case 6:
                    MessageBox.Show("Usted gano");
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
                    MessageBox.Show("Usted Empato");
                    break;
                case 2:
                case 5:
                    MessageBox.Show("Usted perdio");
                    break;
                case 3:
                case 6:
                    MessageBox.Show("Usted gano");
                    break;

            }


        }
    }
}
