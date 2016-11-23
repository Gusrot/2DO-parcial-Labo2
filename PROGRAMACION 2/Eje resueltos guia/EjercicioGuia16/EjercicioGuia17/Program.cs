using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia17
{
    class Program
    {
        static void Main()
        {
            Cuenta cuenta;
            cuenta = new Cuenta();

            cuenta.setNombre("Julian Martire");
            cuenta.setSaldo(30000);
            cuenta.setNroCuenta(1998);
            cuenta.setTipoInteres(ETipoInteres.TAE);

            Console.Write("\nNombre: " + cuenta.getNombre());
            Console.Write("\nSaldo: " + cuenta.getSaldo());
            Console.Write("\nNumero de cuenta: " + cuenta.getNroCuenta());
            Console.Write("\nInteres de la cuenta: " + cuenta.getTipoInteres());
            Console.ReadKey();
        }
    }
}
