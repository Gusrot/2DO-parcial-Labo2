using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia19
{
    class Program
    {
        static void Main()
        {
            ejercicio19_boligrafo.Boligrafo lapiceraJudia;
            lapiceraJudia = new ejercicio19_boligrafo.Boligrafo(ConsoleColor.Blue, 100);

            ejercicio19_boligrafo.Boligrafo lapiceraNegra;
            lapiceraNegra = new ejercicio19_boligrafo.Boligrafo(ConsoleColor.Red, 50);

            lapiceraJudia.pintar(50);
            lapiceraJudia.recargar();

            Console.Write("\nColor de la judia: " + lapiceraJudia.getColor());
            Console.Write("\nTinta de la judia: " + lapiceraJudia.getTinta());
            Console.ReadKey();


        }
    }
}
