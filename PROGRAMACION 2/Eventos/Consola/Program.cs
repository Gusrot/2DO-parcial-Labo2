using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main()
        {
            Clase c = new Clase("jorge");

            c.jorgeEvento += Metodo;

            c.AgregarJorge("jorge");

            Console.ReadLine();
        }
        public static void Metodo(string nombree)
        {
            Console.WriteLine(nombree);
        }
        
    }
}
