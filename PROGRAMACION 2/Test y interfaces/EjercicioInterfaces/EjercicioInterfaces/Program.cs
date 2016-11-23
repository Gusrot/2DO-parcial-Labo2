using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Avion av = new Avion(100, 120);
            Carreta c = new Carreta(100);
            Deportivo d = new Deportivo(100, "asd", 2);

            Console.WriteLine("Avion");
            Console.WriteLine(((IAFIP)av).CalcularImpuesto());
            Console.WriteLine(((IARBA)av).CalcularImpuesto());
            Console.WriteLine(Gestion.MostrarImpuestoNacional(av));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(av));
            Console.WriteLine("Carreta");
            Console.WriteLine(((IARBA)c).CalcularImpuesto());
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(c));
            Console.WriteLine("DEportivo");
            Console.WriteLine(((IAFIP)d).CalcularImpuesto());
            Console.WriteLine(((IARBA)d).CalcularImpuesto());
            Console.WriteLine(Gestion.MostrarImpuestoNacional(d));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(d));
            Console.ReadLine();
        }
    }
}
