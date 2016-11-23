using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia13
{
    class Program
    {
        static void Main()
        {
            double numero,resultado2;
            string resultado,binario;

            Console.WriteLine("Ingrese numero decimal: ");
            numero = int.Parse(Console.ReadLine());
            resultado = Conversor.DecimalBinario(numero);
            Console.WriteLine(resultado);



            Console.WriteLine("Ingrese numero binario: ");
            binario = Console.ReadLine();
            resultado2 = Conversor.BinarioDecimal(binario);
            Console.WriteLine(resultado2);
            
            Console.ReadLine();
        }
    }
}
