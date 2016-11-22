using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devaluacion
{
    public class Peso
    {
        public double _cantidad;

        public Peso(double cantidad)
        {
            this._cantidad = cantidad;
 
        }
        public static implicit operator Peso(double cantidad)
        {
            return new Peso(cantidad);
 
        }
        public static implicit operator double(Peso moneda)
        {
            return moneda._cantidad;
 
        }
        public static implicit operator Peso(Dolar cambio)
        {
            cambio._cantidad = cambio._cantidad * 15;

            return new Peso(cambio._cantidad);
        }
        public static Peso operator +(Peso aux1, Dolar aux2)
        {
            aux1._cantidad = aux1._cantidad + (aux2._cantidad * 15);

            return aux1;
        }
    }
}
