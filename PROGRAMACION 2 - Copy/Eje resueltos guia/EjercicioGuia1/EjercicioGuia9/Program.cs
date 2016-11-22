using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int contador;
            int contador2;
            String cad = "*";


            Console.Write("Ingresar numero");
            numero = int.Parse(Console.ReadLine());

            for (contador2 = 0; contador2 < numero; contador2++)
            {
                for (contador = 0; contador < contador2; contador++)
                {
                    cad = cad + "**";
                }
                cad = cad + "\n";
            }
            Console.WriteLine(cad);
            Console.ReadLine();



        }
    }
}
