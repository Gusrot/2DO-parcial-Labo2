using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Clases;

namespace Formulario
{
    public partial class Form1 : Form
    {
        private Tienda _tienda;

        public Form1()
        {
            InitializeComponent();
            this._tienda = new Tienda("Bv. Italianos 948", 2 , 104303);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(this.GuardarPersona);
            hilo.Start();
        }

        private void brn_leer_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(this.LeerPersona);
            hilo.Start();
        }

        public void LeerPersona()
        {
            Tienda aux;

            if (this._tienda.leer("Local.xml",out aux))
            {
                MessageBox.Show(aux.ToString());
            }
            else
            {
                MessageBox.Show("Local no leido");
            }
        }

        public void GuardarPersona()
        {
            this._tienda.guardar("Local.xml", this._tienda);
        }
    }
}
