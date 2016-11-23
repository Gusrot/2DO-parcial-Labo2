using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MisClases;
using System.Threading.Tasks;

namespace Indexador
{
    class Program
    {
        static void Main()
        {
            PC pc1 = "asd";
            PC pc2 = "qwe";
            PC pc3 = "jorge";
            PC pc4 = "LG nieri";
            PC pc5 = "asd";
            PC pc6 = "qwe";
            PC pc7= "jorge";

            Laboratorio lab1 = new Laboratorio("JOrge");

            /*lab1[0] = pc1;
            lab1[1] = pc2;
            

            for (int i = 0; i < lab1.misPc.Count; i++)
            {
                Console.WriteLine(lab1.misPc[i].marca);
                Console.WriteLine(lab1.misPc[i].SO);
            }*/

            lab1[0] = pc1;
            lab1[1] = pc2;
            lab1[2] = pc3;
            lab1[3] = pc4;
            lab1[4] = pc5;
            lab1[5] = pc6;
            lab1[6] = pc7;

            

            for (int i = 0; i < lab1.misPc.Count; i++)
            {
                Console.WriteLine(lab1.misPc[i].marca);
                Console.WriteLine(lab1.misPc[i].SO);
                Console.WriteLine(lab1.misPc[i].numero);
                Console.WriteLine("***********");
            }

            
            Console.ReadLine();

        }
    }
}
