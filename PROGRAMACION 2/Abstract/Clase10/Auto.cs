using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    public abstract class Auto : Vehiculo
    {
        private int cantidadPuertas;
        public int CantidadPuertas
        {
            set
            {
                this.cantidadPuertas = value;
            }
        }

        public Auto(string patente):base(patente)
        {
 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Auto");
            sb.AppendLine(this.cantidadPuertas.ToString());

            return sb.ToString();
        }


        
    }
}
