using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelotita_3
{
    public partial class Form1 : Form
    {
        List<Thread> MisHilos;
        Thread _MiHilo;
        int cantHilos;

        public Form1()
        {
            InitializeComponent();
            MisHilos = new List<Thread>();
            this.cantHilos = 0;
            this.btnPausar.Click += new EventHandler(this.PausarPelotita);
            this.btnDestruir.Click += new EventHandler(this.DestruirPelotita);
            this.btnRenaudar.Click += new EventHandler(this.RenaudarPelotita);
            this.btnPausarTodo.Click += new EventHandler(this.PausarTodo);
        }

        public void PausarTodo(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in this.MisHilos)
                {
                    item.Suspend();
                }
            }
            catch (Exception) { }
        }

        public void PausarPelotita(object sender, EventArgs e)
        {
            try
            {
                this.MisHilos[this.MisHilos.Count - 1].Suspend();
            }
            catch (Exception) { }
        }

        public void RenaudarPelotita(object sender, EventArgs e)
        {
            try
            {
                this.MisHilos[this.MisHilos.Count - 1].Resume();
            }
            catch (Exception){  }
            
        }

       

        public void DestruirPelotita(object sender, EventArgs e)
        {
            try
            {
                this.MisHilos[this.MisHilos.Count - 1].Abort();
                this.MisHilos.RemoveAt(this.MisHilos.Count - 1);

                this.label1.Text = "C: "+this.MisHilos.Count;

                Graphics g = this.pictureBox1.CreateGraphics();
                g.Clear(this.pictureBox1.BackColor);
            }
            catch (Exception) { }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Pelotita_Con_Threads.Pelotita pelotita = new Pelotita_Con_Threads.Pelotita(this.pictureBox1);
            Thread hilo = new Thread(pelotita.DoWork);
            hilo.Start();
            this.MisHilos.Add(hilo);
            this.label1.Text = "C: "+this.MisHilos.Count;
            //this.btnCrear.Click -= new System.EventHandler(this.btnCrear_Click);
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {

        }

        private void btnDestruir_Click(object sender, EventArgs e)
        {

        }

        private void btnRenaudar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDestruirTodo_Click(object sender, EventArgs e)
        {

        }
    }
}
