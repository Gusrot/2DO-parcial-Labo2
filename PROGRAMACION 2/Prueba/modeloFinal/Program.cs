using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;

namespace modeloFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Punto 2

            Stack<Double> miPila;
            miPila = new Stack<double>();

            miPila.Push(1);
            miPila.Push(2);
            miPila.Push(3);

            miPila = ClaseStack.OrdenInverso(miPila);

            /**********************************************/

            //Punto 3

            Deposito depositoUno;
            depositoUno = new Deposito();

            Deposito depositoDos;
            depositoDos = new Deposito();

            depositoUno.listaDeProductos.Add(new Producto("Helado",5));
            depositoUno.listaDeProductos.Add(new Producto("Azucar", 5));
            depositoDos.listaDeProductos.Add(new Producto("Carne",5));
            depositoDos.listaDeProductos.Add(new Producto("Helado", 5));

            List<Producto> listaFinal = depositoUno + depositoDos;

            /**********************************************/

            //Punto 4

            Galpon<int> galpon;
            galpon = new Galpon<int>();

            galpon.EsImpar += new Delegado(Program.Evento);

            try
            {
                galpon.Cantidad = 1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            ///Punto 6
            try
            {
                Burbujeo.burbujearStatic();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message + " y program");
            }
            ///Punto 7
            
            Galpon<Deposito> aux = new Galpon<Deposito>();
            depositoUno.listaDeProductos.Add(new ProdVendido("Carne vendida", 1));
            depositoDos.listaDeProductos.Add(new ProdExport("Helado Exportado", 3));
            depositoDos.listaDeProductos.Add(new ProdImpuesto("Impuesto al helado", 15));
            aux.lista.Add(depositoUno);
            aux.lista.Add(depositoDos);
            try
            {
                if(aux.serializarXML(aux))
                    Console.WriteLine("Serializado");
            }
            catch (ExcepcionPropia e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

        public static void Evento(Object obj, EventArgs args)
        {
            string archivo = "log.txt";
            DateTime time = new DateTime();

            StreamWriter escritor = new StreamWriter(archivo,true);

            time = DateTime.Now;
            escritor.Write("Hora de la excepcion: "+time.ToLongTimeString() + "//" + "Cantidad ingresada: "+((int)obj).ToString());

            escritor.Close();
        }
    }
}
