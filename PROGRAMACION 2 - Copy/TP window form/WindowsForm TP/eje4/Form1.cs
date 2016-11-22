using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eje4
{
    public partial class Form1 : Form
    {

        float cantidadLamparas,total;
        public string marca;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtBcantidadLamparas_TextChanged(object sender, EventArgs e)
        {
            cantidadLamparas = float.Parse(txtBcantidadLamparas.Text);
        }

        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string op = cboMarca.Text;

             switch (op)
             {
                case "ArgentinaLuz":
                     if (cantidadLamparas == 5)
                     {
                         total = (cantidadLamparas * 35f) * 0.40f;
                         if (total >= 120)
                         {
                             total *= 1.10f;
                             MessageBox.Show("IIBB Usted pago: " + total + "$");
                         }
                         else
                             MessageBox.Show("Se compro " + cantidadLamparas + " lampartitas y tuvo un descuento del 40%, lo que le sale: " + total + "$");
                         

                     }
                     else
                     {
                         if (cantidadLamparas == 4)
                         {
                             total = (cantidadLamparas * 35f) * 0.25f;
                             if (total >= 120)
                             {
                                 total *= 1.10f;
                                 MessageBox.Show("IIBB Usted pago: " + total + "$");
                             }
                             else
                                MessageBox.Show("Se compro " + cantidadLamparas + " lampartitas y tuvo un descuento del 25%, lo que le sale: " + total + "$");
                         }
                         else
                         {
                             if (cantidadLamparas == 3)
                             {
                                 total = (cantidadLamparas * 35f) * 0.15f;
                                 if (total >= 120)
                                 {
                                     total *= 1.10f;
                                     MessageBox.Show("IIBB Usted pago: " + total + "$");
                                 }
                                 else
                                     MessageBox.Show("Se compro " + cantidadLamparas + " lampartitas y tuvo un descuento del 15%, lo que le sale: " + total + "$");
                             }
                         }
                     }

                    break;
                 case "FelipeLamparas":
                    if (cantidadLamparas == 4)
                    {
                        total = (cantidadLamparas * 35f) * 0.25f;
                        if (total >= 120)
                        {
                            total *= 1.10f;
                            MessageBox.Show("IIBB Usted pago: " + total + "$");
                        }
                        else
                            MessageBox.Show("Se compro " + cantidadLamparas + " lampartitas y tuvo un descuento del 25%, lo que le sale: " + total + "$");
                    }
                    else
                    {
                        if (cantidadLamparas == 3)
                        {
                            total = (cantidadLamparas * 35f) * 0.10f;
                            if (total >= 120)
                            {
                                total *= 1.10f;
                                MessageBox.Show("IIBB Usted pago: " + total + "$");
                            }
                            else
                                MessageBox.Show("Se compro " + cantidadLamparas + " lampartitas y tuvo un descuento del 10%, lo que le sale: " + total + "$");
                        }
                    }
                    break;
                default:
                    if (cantidadLamparas > 5)
                    {
                        total = (cantidadLamparas * 35f) * 0.50f;
                        if (total >= 120)
                        {
                            total *= 1.10f;
                            MessageBox.Show("IIBB Usted pago: " + total + "$");
                        }
                        else
                            MessageBox.Show("Se compro " + cantidadLamparas + " lampartitas y tuvo un descuento del 50%, lo que le sale: " + total+"$");
                    }
                    else
                    {
                        if (cantidadLamparas ==4)
                        {
                            total = (cantidadLamparas * 35f)*0.20f;
                            if (total >= 120)
                            {
                                total *= 1.10f;
                                MessageBox.Show("IIBB Usted pago: " + total + "$");
                            }
                            else
                                MessageBox.Show("Se compro " + cantidadLamparas + " lampartitas y tuvo un descuento del 20%, lo que le sale: " + total + "$");
                        }
                        else
                        {
                            if (cantidadLamparas == 5)
                            {
                                total = (cantidadLamparas * 35f) * 0.30f;
                                if (total >= 120)
                                {
                                    total *= 1.10f;
                                    MessageBox.Show("IIBB Usted pago: " + total + "$");
                                }
                                else
                                    MessageBox.Show("Se compro " + cantidadLamparas + " lampartitas y tuvo un descuento del 30%, lo que le sale: " + total + "$");
                            }
                            else
                            {
                                if (cantidadLamparas == 3)
                                {
                                    total = (cantidadLamparas * 35f) * 0.05f;
                                    if (total >= 120)
                                    {
                                        total *= 1.10f;
                                        MessageBox.Show("IIBB Usted pago: " + total + "$");
                                    }
                                    else
                                        MessageBox.Show("Se compro " + cantidadLamparas + " lampartitas y tuvo un descuento del 5%, lo que le sale: " + total + "$");
                                }
                                else
                                {
                                    if (cantidadLamparas <1)
                                    {
                                        MessageBox.Show("Error, ingrese la cantidad de lamaprita/s ");
                                    }
                                    else
                                    {
                                        total = cantidadLamparas * 35f;
                                         MessageBox.Show("Se compro " + cantidadLamparas + " lampartitas y el total es: " + total + "$");
                                    }
                                    
                                }
                                
                                
                            }
                            
                            
                        }
                        
                    }
                    break;
             }
             
        }
    }
}

