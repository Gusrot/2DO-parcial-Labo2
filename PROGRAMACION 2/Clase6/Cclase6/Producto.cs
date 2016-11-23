using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cclase6
{
    public class Producto
    {
        private int _Cantidad;

        public Producto(int cantidad)
        {
            _Cantidad = cantidad;
        }

        public static implicit operator int(Producto prod)
        {
            return prod._Cantidad;
        }


        public static implicit operator Producto(int numero)
        {
            return new Producto(numero);
        }

        public static Producto operator +(Producto prod1, Producto prod2)
        {
            prod1._Cantidad = prod1._Cantidad + prod2._Cantidad;
            return prod1;
        }


    }
}
