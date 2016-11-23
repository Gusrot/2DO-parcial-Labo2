using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DespuesDeExcepciones
{
    class Program
    {
        static void Main()
        {
            Deposito<Persona> DepositoPersona = new Deposito<Persona>(3);

            DepositoPersona.Agregar(new Persona("A", 1));
            DepositoPersona.Agregar(new Persona("B", 2));
            DepositoPersona.Agregar(new Persona("C", 3));

            Deposito<Vehiculo> DepositoVehiculo = new Deposito<Vehiculo>(3);

            DepositoVehiculo.Agregar(new Vehiculo("Ford", ConsoleColor.Red, 123));
            DepositoVehiculo.Agregar(new Vehiculo("Fiat", ConsoleColor.Black, 456));
            DepositoVehiculo.Agregar(new Vehiculo("Volvo", ConsoleColor.Blue, 789));

            Deposito<Mascota> DepositoMascota = new Deposito<Mascota>(3);

            DepositoMascota.Agregar(new Mascota("Ciro", "Salchicha"));
            DepositoMascota.Agregar(new Mascota("Perro", "Raza"));
            DepositoMascota.Agregar(new Mascota("Perro2", "Raza2"));

            Console.WriteLine("********************");
            Console.WriteLine("Deposito de Personas");
            Console.WriteLine("********************");

            foreach (Persona item in DepositoPersona)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("********************");
            Console.WriteLine("Deposito de Vehiculos");
            Console.WriteLine("********************");
            

            foreach (Vehiculo item in DepositoVehiculo)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("********************");
            Console.WriteLine("Deposito de Mascotas");
            Console.WriteLine("********************");

            foreach (Mascota item in DepositoMascota)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }
    }
}
