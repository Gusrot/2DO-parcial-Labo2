using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rueda otra;
            Tiempo tiempo;
            Kilometro kilo;
            Carrera carrera;

            otra = new Rueda("Gomas",3);
            //tiempo = new Tiempo(10);
            //kilo = new Kilometro(10);

            tiempo = 10;
            kilo = 10;

            /*tiempo  = tiempo + 10;
            tiempo.MostrarTiempo();
            tiempo = tiempo + tiempo;
            tiempo.MostrarTiempo();            
            kilo = kilo + 10;
            kilo.MostrarKilometro();
            kilo = kilo + kilo;
            kilo.MostrarKilometro();
            tiempo = tiempo - 10;
            tiempo.MostrarTiempo();
            

            if (tiempo == 10)
            {
                Console.WriteLine("son iguales");
            }
            else
            {
                Console.WriteLine("El conocimiento es poder");

            }*/
            
            
            carrera = new Carrera();
            carrera.CorrerCarrera(kilo);
            carrera.MostrarCarrera();            
            Console.ReadKey();
           
            

            
            
        }
    }
}
