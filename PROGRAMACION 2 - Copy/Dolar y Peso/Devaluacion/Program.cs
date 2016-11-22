using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devaluacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar und;
            Peso unp;

            und = 1;
            unp = (Peso)1;

            //und = und + unp;
           // Console.WriteLine(und);
            unp = unp + und;
            Console.WriteLine(unp);

            Console.ReadLine();


        }
    }
}
