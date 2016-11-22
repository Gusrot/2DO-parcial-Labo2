using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia7
{
    class Program
    {
        static void Main()
        {
            int anio;
            int mes;
            int dia;

            Console.WriteLine("Ingrese dia de nacimiento: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese mes de nacimiento: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese año de nacimiento: ");
            anio = int.Parse(Console.ReadLine());

            DateTime fechaActual = DateTime.Now;
            DateTime vivido = new DateTime(anio,mes,dia);

            TimeSpan ts = fechaActual - vivido;

            int diasVividos = ts.Days;

            Console.Write("Ustedes vivio " + diasVividos + " dias");
            Console.ReadKey();
        }
    }
}
