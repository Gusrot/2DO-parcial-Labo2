using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioInterfaces
{
    public abstract class Auto : Vehiculo
    {
        protected string _patente;

        public Auto(double precio, string patente)
            : base(precio)
        {
            this._patente = patente;
        }

        public abstract void MostrarPatente();

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

    }
}
