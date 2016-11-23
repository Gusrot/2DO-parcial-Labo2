using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia8
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorHora;
            string nombre;
            int antiguedad;
            int horasTrabajadas;
            int importeCobrar;
            int cobroBruto;
            int descuentos;
            int valorNeto;

            Console.Write("\nIngrese el nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.Write("\nIngrese valor de hora: ");
            valorHora = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese antigüedad en años: ");
            antiguedad = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese horas trabajadas: ");
            horasTrabajadas = int.Parse(Console.ReadLine());

            importeCobrar = (valorHora * horasTrabajadas) + (antiguedad * 150);
            descuentos = (importeCobrar * 13) / 100;
            cobroBruto = importeCobrar;
            valorNeto = importeCobrar - descuentos;

            Console.Write("\nNombre: " + nombre);
            Console.Write("\nAntiguedad: " + antiguedad + " años");
            Console.Write("\nValor por hora: " + valorHora);
            Console.Write("\nCobro en bruto: " + cobroBruto);
            Console.Write("\nDescuentos: " + descuentos);
            Console.Write("\nCobro en neto: " + valorNeto);
            Console.ReadKey();
        }
    }
}
