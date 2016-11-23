using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    public class Producto
    {
        private int _cantidad;

        public Producto(int cantidad)
        {
            this._cantidad = cantidad; 
        }
        public static implicit operator Producto(int cantidad)
        {
            return new Producto(cantidad);
        }
        public static implicit operator int(Producto productoaux)
        {
            return productoaux._cantidad;
        }
        public static Producto operator +(Producto productoAux, int cantidad)
        {
            productoAux._cantidad = productoAux._cantidad + cantidad;

            return productoAux;
        }
        public static Producto operator +(Producto aux1, Producto aux2)
        {
            aux1._cantidad = aux1._cantidad + aux2._cantidad;
            return aux1;
        }

    }
}
