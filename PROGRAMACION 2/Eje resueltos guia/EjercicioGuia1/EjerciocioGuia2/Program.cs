using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciocioGuia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 2";
            /*Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero, caso contrario,mostrar el mensaje: "ERROR. Reingresar número!!!".*/

            int num;
            double cuadrado=0,cubo=0;
            Console.Write("Ingrese numero: ");
            num = int.Parse(Console.ReadLine());
            
            while (num <= 0)
            {
                Console.WriteLine("ERROR. Reingresar numero!!!");
                Console.Beep(30000, 1500);
                num = int.Parse(Console.ReadLine());
            }
            cuadrado = Math.Pow(num, 2);
            cubo = Math.Pow(num, 3);
            Console.WriteLine("El Cuadrado de " + num + " es: " + cuadrado);
            Console.WriteLine("El Cubo de " + num + " es: " + cubo);
            Console.ReadKey();
        }
    }
}
