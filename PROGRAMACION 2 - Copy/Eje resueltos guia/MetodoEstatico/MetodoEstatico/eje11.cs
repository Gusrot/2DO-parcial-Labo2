using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoEstatico
{
    public static class eje11
    {
        public static bool validar(int minimo, int maximo, int numero)
        {
            if (numero > 100 || numero < -100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int dividir(int x, int y)
        {
            return x / y;
        }
    }
}
