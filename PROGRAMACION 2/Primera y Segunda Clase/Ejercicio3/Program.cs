using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main()
        {
            /*int resultadoDividir = 0;
            int resultadoSuma = 0;
            resultadoSuma= Calculadora.Sumar(6, 6);
            resultadoDividir=Calculadora.Dividir(0,0);

            Console.WriteLine("Suma: "+resultadoSuma);
            Console.WriteLine("Division: "+resultadoDividir);
            Console.ReadKey();*/

            Alumno Alguien;
            Alguien = new Alumno();
            Alumno otro = new Alumno();
            otro.nombre = "Julian";
            Alguien.nombre = "Matias";

            otro.MostrarDatos();
            Alguien.MostrarDatos();


            

            Console.ReadKey();

        }

    }
}
