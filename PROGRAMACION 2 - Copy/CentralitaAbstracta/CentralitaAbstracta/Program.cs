using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaAbstracta
{
    class Program
    {
        static void Main()
        {
            Centralita miCentralita = new Centralita("Telefonica");
            Local l1 = new Local("casa", 30f, "jorge", 2.65f);
            Provincial l2 = new Provincial("casa2",  Franja.Franja_1,21f, "austaquio");
            Local l3 = new Local("casa", 1f, "luis", 3.07f);
            //Local l3 = new Local("casa3", 45f, "luis", 1.99f);
            Provincial l4 = new Provincial(Franja.Franja_3, l2);
            
            Console.WriteLine("*******************************************");
            Console.WriteLine("Mostrando las Llamas desordenadas");
            Console.WriteLine("*******************************************");

            miCentralita += l1;
            miCentralita += l2;
            miCentralita += l3;
            miCentralita += l4;

            Console.WriteLine("Mostrando llamda 1");
            Console.WriteLine(l1.ToString());
            Console.ReadKey();
            Console.WriteLine("******************");
            Console.WriteLine("Mostrando llamda 2");
            Console.WriteLine(l2.ToString());
            Console.ReadKey();
            Console.WriteLine("******************");
            Console.WriteLine("Mostrando llamda 3");
            Console.WriteLine(l3.ToString());
            Console.ReadKey();
            Console.WriteLine("******************");
            Console.WriteLine("Mostrando llamda 4");
            Console.WriteLine(l4.ToString());
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("*******************************************");
            Console.WriteLine("Mostrando las Llamas ordenadas por duracion");
            Console.WriteLine("*******************************************");

            miCentralita.OrdenarLlamadas();
            Console.WriteLine(miCentralita.ToString());

            /*
            miCentralita += l1;
            miCentralita += l3;

            if (l1 == l3)
                Console.WriteLine("Son iguales");
            else Console.WriteLine("No son iguales");*/

            Console.ReadKey();
        }
    }
}
