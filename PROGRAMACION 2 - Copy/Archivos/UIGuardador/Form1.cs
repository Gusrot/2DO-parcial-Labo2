using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Archivos;

namespace UIGuardador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Guardador.GuardarPersona(new Persona(this.txtNombre.Text, this.txtClave.Text));
            this.txtNombre.Clear();
            this.txtClave.Clear();
            this.CargarListado(Guardador.RetornarListado());
        }

        private void CargarListado(List<Persona> personas)
        {
            lsbListadoPersonas.Items.Clear();
            foreach (Persona item in personas)
            {
                this.lsbListadoPersonas.Items.Add(item.ToString());
            }
        }
    }
}
