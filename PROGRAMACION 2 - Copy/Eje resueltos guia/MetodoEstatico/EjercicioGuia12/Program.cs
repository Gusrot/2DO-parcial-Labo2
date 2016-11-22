using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia12
{
    class Program
    {
        static void Main()
        {
            int num,suma=0;
            bool retorno;

            do{
                Console.Write("Ingrese Numero: ");
                num=int.Parse(Console.ReadLine());
                suma += num;
                retorno = eje12.ValidaS_N();
            }while(retorno==true);

            Console.WriteLine("La suma es: " + suma);
            Console.ReadKey();

        }
    }
}
