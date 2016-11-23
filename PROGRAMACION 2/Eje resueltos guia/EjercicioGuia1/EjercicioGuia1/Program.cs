using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia1
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Ejercicio Nro 1";
            int[] numero;
            int contador;
            int acumulador=0;
            int minimo = 0;
            int maximo = 0;
            int flag = 0;


            numero = new int[5];


            for (contador = 0; contador < 5; contador++)
            {
                Console.Write("Ingrese numero: ");
                numero[contador] = int.Parse(Console.ReadLine());
                acumulador += numero[contador];
                if (flag == 0 || minimo > numero[contador])
                {
                    minimo = numero[contador];
                }

                if (flag == 0 || maximo < numero[contador])
                {
                    flag = 1;
                    maximo = numero[contador];
                }

            }

                Console.WriteLine("Maximo: " + maximo);
                Console.WriteLine("Minimo: " + minimo);
                Console.WriteLine("Promedio:" + (acumulador / contador));
                Console.ReadKey();

        }
    }
}
