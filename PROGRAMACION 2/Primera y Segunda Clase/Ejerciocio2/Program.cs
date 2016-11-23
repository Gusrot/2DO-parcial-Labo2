using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciocio2
{
    class Program
    {
        static void Main()
        {
            int i;
            int numRandom;
            int cont1 = 0;
            int cont2 = 0;
            int cont3 = 0;
            int cont4 = 0;
            int cont5 = 0;
            int cont6 = 0;
            int cont7 = 0;
            int cont8 = 0;
            int cont9 = 0;
            int cont10 = 0;

            Random random = new Random();

            for (i = 0; i < 100; i++)
            { 
                
                numRandom = random.Next(1 , 11);
                /*Console.Write(numRandom+"_");
                Console.ReadKey();*/
                switch (numRandom)
                {
                    case 1:
                        cont1++;
                        break;
                    case 2:
                        cont2++;
                        break;
                    case 3:
                        cont3++;
                        break;
                    case 4:
                        cont4++;
                        break;
                    case 5:
                        cont5++;
                        break;
                    case 6:
                        cont6++;
                        break;
                    case 7:
                        cont7++;
                        break;
                    case 8:
                        cont8++;
                        break;
                    case 9:
                        cont9++;
                        break;
                    case 10:
                        cont10++;
                        break;

                }
                    
            }
            //Console.Write("--"+cont1+" Unos");
            Console.WriteLine("Cantidad de 1: " + ((cont1*100)/100) +"%");
            Console.WriteLine("Cantidad de 2: " + ((cont2 * 100) / 100) + "%");
            Console.WriteLine("Cantidad de 3: " + ((cont3 * 100) / 100) + "%");
            Console.WriteLine("Cantidad de 4: " + ((cont4 * 100) / 100) + "%");
            Console.WriteLine("Cantidad de 5: " + ((cont5 * 100) / 100) + "%");
            Console.WriteLine("Cantidad de 6: " + ((cont6 * 100) / 100) + "%");
            Console.WriteLine("Cantidad de 7: " + ((cont7 * 100) / 100) + "%");
            Console.WriteLine("Cantidad de 8: " + ((cont8 * 100) / 100) + "%");
            Console.WriteLine("Cantidad de 9: " + ((cont9 * 100) / 100) + "%");
            Console.WriteLine("Cantidad de 10: " + ((cont10 * 100) / 100) + "%");
            Console.ReadKey();
            
        }
    }
}
