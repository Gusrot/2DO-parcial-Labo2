using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devaluacion
{
    public class Dolar
    {
        public double _cantidad;

        public Dolar(double cantidad)
        {
            this._cantidad = cantidad;
 
        }
        public static implicit operator Dolar(double cantidad)
        {
            return new Dolar(cantidad);
 
        }
        public static implicit operator double(Dolar moneda)
        {
            return moneda._cantidad;
 
        }
        public static implicit operator Dolar(Peso cambio)
        {
            cambio._cantidad = cambio._cantidad / 15;

            return new Dolar(cambio._cantidad);
        }
        public static Dolar operator +(Dolar aux1, Peso aux2)
        {
            aux1._cantidad = aux1._cantidad + (aux2._cantidad / 15);

            return aux1;
        }


    }
}
