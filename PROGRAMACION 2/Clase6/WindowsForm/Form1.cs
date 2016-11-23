using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Saludar
        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string aux;
            aux = this.textNombre.Text;
            MessageBox.Show(aux);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Mostrar
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.lvlNombre.Text = "Cambie el texto";
        }

        private void btnAprobarMateria_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAprobarMateria_MouseHover(object sender, EventArgs e)
        {
           // this.btnAprobarMateria.Visible = false;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.btnAprobarMateria.Visible = true;
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            this.btnAprobarMateria.Visible = false;
        }
    }
}
