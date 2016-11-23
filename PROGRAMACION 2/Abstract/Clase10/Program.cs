using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    class Program
    {
        static void Main(string[] args)
        {
            Familiar f1 = new Familiar("fam 123");
            Deportivo d1 = new Deportivo("dep 456");
            Carreta c1 = new Carreta("carr 789");
            Avion a1 = new Avion("avi 747");
            Privada p1 = new Privada("pri 159");

            List<Vehiculo> misVehiculos=new List<Vehiculo>();
            List<iAFIP> misAFIP = new List<iAFIP>();


            misVehiculos.Add(f1);
            misVehiculos.Add(d1);
            misVehiculos.Add(c1);
            misVehiculos.Add(a1);



            misAFIP.Add(d1);
            misAFIP.Add(a1);
            misAFIP.Add(p1);

            Console.WriteLine("Vehiculo");

            foreach (Vehiculo item in misVehiculos)
            {
                Console.WriteLine(item.CalcularCosto());
            }
                                                                                    
            Console.WriteLine("Impuestos ");

            foreach (iAFIP item in misAFIP)
            {
                Console.WriteLine(Gestion.MostrarImp(item));
            }

            Console.ReadLine();
        }
    }
}
