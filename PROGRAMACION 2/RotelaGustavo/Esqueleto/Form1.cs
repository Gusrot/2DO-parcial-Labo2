using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
//using System.Threading;
using Entidades;

namespace Esqueleto
{
    public partial class Form1 : Form
    {
        private Empleado _emp;
        private string path;

        public Form1()
        {
            InitializeComponent();
            this._emp = new Empleado("Gustavo", "Rotela", 104303);
            this.path = "Persona.xml";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(this.GuardarPersona);
            hilo.Start();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // falta hilos.
            //Thread hilo = new Thread();
            Thread hilo = new Thread(this.LeerPersona);
            hilo.Start();
        }

        public void LeerPersona()
        {
            Empleado aux;

            if (this._emp.leer("Persona.xml", out aux))
            {
                MessageBox.Show(aux.ToString());
            }
            else
            {
                MessageBox.Show("Empleado no leído");
            }
        }

        public void GuardarPersona()
        {
            this._emp.guardar(this.path, this._emp);
        }
    }
}
