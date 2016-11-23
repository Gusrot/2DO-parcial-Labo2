using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eje2
{
    public partial class Form1 : Form
    {

        float LargoTerreno,AnchoTerreno,RadioTerreno;
        float cantRectangulo,cantCirculo,cantCal,cantCemento,cantMaterial;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtBLargoTerreno_TextChanged(object sender, EventArgs e)
        {
            LargoTerreno = float.Parse(txtBLargoTerreno.Text);
        }

        private void txtBAnchoTerreno_TextChanged(object sender, EventArgs e)
        {
            AnchoTerreno = float.Parse(txtBAnchoTerreno.Text);
        }

        private void txtBRadioTerreno_TextChanged(object sender, EventArgs e)
        {
            RadioTerreno = float.Parse(txtBRadioTerreno.Text);
        }

        private void btnRectanguloAlambre_Click(object sender, EventArgs e)
        {
            cantRectangulo = (LargoTerreno * 2) + (AnchoTerreno * 2);
            MessageBox.Show("La cantidad que se necesita para el terreno 'Rectangular' es: " + cantRectangulo*3+" de alambre");
        }

        private void btnCirculoAlambre_Click(object sender, EventArgs e)
        {
            cantCirculo = (RadioTerreno * 2) * 3;
            MessageBox.Show("La cantidad que se necesita para el terreno 'Circular' es: " + cantCirculo + " de alambre");
        }

        private void btnMaterialesContrapiso_Click(object sender, EventArgs e)
        {
            cantMaterial = LargoTerreno * AnchoTerreno;
            cantCal = cantMaterial * 3;
            cantCemento = cantMaterial * 2;
            MessageBox.Show("Se necesita "+ cantCal+" bolsas de Cal y "+cantCemento+" olsas de Cemento");

        }
    }
}
