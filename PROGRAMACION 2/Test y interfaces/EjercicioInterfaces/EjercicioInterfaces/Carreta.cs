using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class Carreta : Vehiculo, IARBA
    {
        public Carreta(double precio)
            : base(precio)
        {

        }

        public override double Precio
        {
            get
            {
                return base.Precio;
            }
            set
            {
                base.Precio = value;
            }
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio: " + this._precio);
        }


        public double CalcularImpuesto()
        {
            return this._precio * 1.18;
        }
    }
}
