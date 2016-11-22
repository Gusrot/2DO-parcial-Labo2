using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia6
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Ejercicio Nro 6";
            int año;

            Console.Write("Ingrese anio: ");
            año = int.Parse(Console.ReadLine());

            if (año % 4 == 0 && (año % 100 != 0 || año % 400 == 0))
                Console.Write("El anio ES bisiesto");
            else
                Console.Write("El anio NO es bisiesto");

            Console.ReadKey();


        }
    }
}
