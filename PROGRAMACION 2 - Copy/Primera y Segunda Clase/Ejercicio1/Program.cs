using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ejercicio1
{
    class Program
    {
        static void Main()
        {
            int edades;
            int prom;
            int contador;
            int acumulador = 0;
            Console.Title = "Julian Martire";
            Console.Write("Hola mundo");
            Console.ReadKey();
            for (contador = 0; contador < 5; contador++)
            {
                Console.Write(contador+1+")Ingrese edad: ");
                edades = int.Parse(Console.ReadLine());
                acumulador += edades;
            }
            prom = acumulador/5;
            Console.Write("El promedio es:"+prom);
            Console.ReadKey();
            Ejercicio3.Calculadora.Sumar(6, 6);
            Ejercicio3.Calculadora.Dividir(6, 6);
            Ejercicio3.Calculadora.EsMayorQue(10,5);
        }
    }
}
