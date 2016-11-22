using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> listado = Guardador.RetornarListado();
            foreach (Persona item in listado)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
