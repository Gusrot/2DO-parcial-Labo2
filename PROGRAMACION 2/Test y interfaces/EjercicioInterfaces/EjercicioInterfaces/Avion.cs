using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioInterfaces
{
    public class Avion : Vehiculo,IAFIP,IARBA
    {
        protected double _velocidadMaxima;

        public Avion(double precio, double velMax)
            : base(precio)
        {
            this._velocidadMaxima = velMax;
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

        double IAFIP.CalcularImpuesto()
        {
            return this._precio * 1.3;
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * 1.27;
        }
    }
}
