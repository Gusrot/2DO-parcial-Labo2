using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase3;


namespace UI
{
    public partial class Form1 : Form
    {
        private Carrera _miCarrera;
        private Auto _miAuto;

        public Form1()
        {
            InitializeComponent();
            foreach (EFabricante item in Enum.GetValues(typeof(EFabricante)))
            {
                this.cmbFabricante.Items.Add(item);
            }
            this.cmbFabricante.SelectedIndex = 1;
            grbAutos.Enabled = false;
            txtNombre.Text = "Quilmes";
            txtFecha.Text = "05/03/1998";
            txtLugar.Text = "Quilmes";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _miCarrera = new Carrera(this.txtNombre.Text,this.txtFecha.Text,this.txtLugar.Text);
            grbCarrera.Enabled = false;
            grbAutos.Enabled = true;

        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            _miAuto = new Auto(this.txtNombrePiloto.Text,(EFabricante)this.cmbFabricante.SelectedItem);
            this._miCarrera += _miAuto;
            MostrarListado();
            
        }

        private void MostrarListado()
        {
            this.lsbAutos.Items.Clear();
            foreach (Auto item in this._miCarrera.listaAutos)
            {
                this.lsbAutos.Items.Add(item.datosEnString);
            }
        }

        private void lsbAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lsbResultado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCorrerTiempo_Click(object sender, EventArgs e)
        {
            _miCarrera.CorrerCarrera((Tiempo)10);
        }

        private void btnCorrerKm_Click(object sender, EventArgs e)
        {
            _miCarrera.CorrerCarrera((Kilometro)10);
        }
    }
}
