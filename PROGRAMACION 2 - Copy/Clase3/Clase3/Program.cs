using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    class Program
    {
        static void Main()
        {
            Console.Title="Clase 3";

            List<Auto> listaAutos = new List<Auto>();
            Stack<Auto> stackAutos = new Stack<Auto>();
            ArrayList arraylista = new ArrayList();
            Queue<Auto> SoloQ = new Queue<Auto>();


            arraylista.Add("Hola");
            arraylista.Add("jorge");

            
            

            

            Carrera race1 = new Carrera();
            
            race1 = race1 + new Auto();
            for (int i = 0; i < 20; i++)
            {
                race1 = race1 + new Auto();
            }

            
            //race1.CorrerCarrera((Tiempo)10);           
            //race1.CorrerCarrera((Kilometro)10,(Tiempo)10);
            race1.MostrarCarrera();

            
            

            

            //Depetricated por colleccion.
            /*Carrera race1 = new Carrera();
            Carrera race2 = new Carrera();
            Console.WriteLine("Carrera por km");
            race1.CorrerCarrera((Kilometro)10);
            race1.MostrarCarreraPorKm();
            Console.ReadLine();
            Console.WriteLine("Carrera por tiempo");
            race2.CorrerCarrera((Tiempo)10);
            race2.MostrarCarreraPorTiempo();*/


            //Rueda otrarueda = new Rueda("Pirulo",3);
            
            /*Carrera carrera = new Carrera();
            carrera.MostrarCarrera();*/
            //otrarueda.MostrarRueda();
            /*Tiempo t1 = 5;
            Tiempo t2 = 10;
            Tiempo result;
            Kilometro km; */

            /*result = t1 + 10;
            result.MostrarTiempo();

            result = t1 + t2;
            result.MostrarTiempo();
            result = t1 - 10;
            result.MostrarTiempo();
            result = t1 - t2;
            result.MostrarTiempo();
            if (t1 == t2)
                Console.WriteLine("son iguales");
            else
                Console.WriteLine("son distintos");

            if (t1 < 20)
                Console.WriteLine("t1 es menor");
            else
                Console.WriteLine("t1 es mayor");

            if (t1 > 20)
                Console.WriteLine("t1 es mayor");
            else
                Console.WriteLine("t1 es menor");*/

            /*result = 10;
            km = 20;*/


            

            /*EFabricante fabricante;
            fabricante = EFabricante.Honda;
            Console.WriteLine(fabricante);
            fabricante = (EFabricante)101 ;
            Console.WriteLine(fabricante);
            fabricante = (EFabricante)5;
            Console.WriteLine(fabricante);
            Console.ReadKey();*/

            /*Carrera r1 = new Carrera();
            Auto a1 = new Auto();
            Auto a2 = new Auto();
            Auto a3 = new Auto();
            Auto a4 = new Auto();
            Auto a5 = new Auto();*/


            

            

            Console.ReadKey();
        }
    }
}
