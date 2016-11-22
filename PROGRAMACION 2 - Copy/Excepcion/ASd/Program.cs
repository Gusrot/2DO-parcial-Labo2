using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASd
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                kl l = new kl();
                l.ASD();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        
    }
}
