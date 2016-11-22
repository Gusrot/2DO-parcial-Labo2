using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cclase6
{
    class Program
    {
        static void Main()
        {
            /*Producto Prod = (Producto)33;

            int Resultado;

            Resultado = Prod + Prod;

            Console.WriteLine("Prod + Prod: "+Resultado);*/

            Dolar unD;
            Peso unP;

            unD = 1;
            unP = (Peso)1;

            Console.WriteLine(unD);
            Console.WriteLine(unP);


            unD = unD + unP;
            Console.WriteLine("1 dolar + 1 peso: "+unD._valor);


            Console.ReadKey();



        }
    }
}
