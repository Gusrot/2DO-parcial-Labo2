using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoEstatico
{
    class Program
    {
        static void Main()
        {
            int numeros;
            int i,minimo=0,maximo=0,acumulador=0,promedio=0;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese numero: ");
                numeros = int.Parse(Console.ReadLine());
                while (eje11.validar(-100, 100, numeros))
                {
                    Console.Write("Reingrese numero: ");
                    numeros = int.Parse(Console.ReadLine());
                }

                Console.ReadKey();

                acumulador = acumulador + numeros;
                if (i == 0)
                {
                    minimo = numeros;
                    maximo = numeros;
                }
                else
                {
                    if (numeros < minimo)
                    {
                        minimo = numeros;
                    }
                    else if (numeros > maximo)
                    {
                        maximo = numeros;
                    }
                }
                

            }
            promedio = eje11.dividir(acumulador, i);

            Console.WriteLine("Minimo" + minimo);
            Console.WriteLine("Maximo" + maximo);
            Console.WriteLine("Promedio" + promedio);
            Console.ReadKey();
        }
    }
}
