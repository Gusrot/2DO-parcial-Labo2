using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia14
{
    class Program
    {
        static void Main()
        {
            double basecuadrado,cuadrado,circuloradio,trianguloBase,trianguloAltura,triangulo,circulo;

            Console.WriteLine("*** Cuadrado ***");
            Console.WriteLine("Ingrese la base del cuadrado: ");
            basecuadrado = double.Parse(Console.ReadLine());
            Console.WriteLine("*** Triangulo ***");
            Console.WriteLine("Ingrese la base del triangulo: ");
            trianguloBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo: ");
            trianguloAltura = double.Parse(Console.ReadLine());
            Console.WriteLine("*** Circulo ***");
            Console.WriteLine("Ingrese el radio del circulo: ");
            circuloradio = double.Parse(Console.ReadLine());

            cuadrado = CalculoDeArea.CalcularCuadrado(basecuadrado);
            triangulo = CalculoDeArea.CalcularTriangulo(trianguloBase,trianguloAltura);
            circulo = CalculoDeArea.CalcularCirculo(circuloradio);

            Console.WriteLine("El area del cuadrado es: " + cuadrado);
            Console.WriteLine("El area del triangulo es: " + triangulo);
            Console.WriteLine("El area del circulo es: " + circulo);
            Console.ReadKey();



        }
    }
}
