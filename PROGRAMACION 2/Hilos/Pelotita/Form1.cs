using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelotita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            /*Pelotita_Sin_Threads.Pelotita pelotita = new Pelotita_Sin_Threads.Pelotita(this.pictureBox1);
            pelotita.DoWork();*/
            Pelotita_Con_Threads.Pelotita pelotita = new Pelotita_Con_Threads.Pelotita(this.pictureBox1);
            pelotita.DoWork();
        }
    }
}
