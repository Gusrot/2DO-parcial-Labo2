using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia4
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Ejercicio Nro 4";
            /*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.El primer número perfecto es 6, ya que los divisores de
              6 son 1,2 y 3; y 1 + 2 + 3 = 6. Escribir una aplicación que encuentre los 4 primeros números perfectos.*/
            int perfecto;
            int contador=1;
            int acumulador = 0, contt = 0;

            for ( ; ; )
            {
                contador++;
                acumulador = 0;
                for (perfecto = 1; perfecto < contador; perfecto++)
                {
                    if (contador % perfecto == 0)
                        acumulador += perfecto;
                }

                if (acumulador == contador)
                {
                    Console.WriteLine(contador);
                    contt++;

                }
                if (contt == 4)
                    break;

            }

            Console.ReadKey();
        }
    }
}
