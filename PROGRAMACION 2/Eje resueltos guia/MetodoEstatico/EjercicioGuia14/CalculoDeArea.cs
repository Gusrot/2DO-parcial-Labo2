using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia14
{
    public static class CalculoDeArea
    {
        public static double CalcularCuadrado(double Base)
        {
            return Base*Base;
        }
        public static double CalcularTriangulo(double Base, double altura)
        {
            return ((Base*altura)/2);
        }
        public static double CalcularCirculo(double radio)
        {
            return Math.PI*(radio*radio);
        }
    }
}
