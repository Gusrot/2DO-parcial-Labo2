using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    class Program
    {
        static void Main()
        {
            Dolar dolar = new Dolar(1);
            Console.WriteLine("el dolar vale: "+dolar._Plata);
            Euro euro = new Euro(1);
            Console.WriteLine("el euro vale: "+euro._Plata);

            dolar--;
            Console.WriteLine("dolar++" + dolar._Plata);



            Console.ReadKey();
        }
    }
}
