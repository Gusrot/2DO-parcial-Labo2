using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    public abstract class Vehiculo
    {
        private string _patente;


        public Vehiculo(string patente)
        {
            this._patente = patente;
        }

        public override string ToString()
        {
            return this._patente;
        }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Vehiculo");
            sb.AppendLine("Patente: "+this._patente);
            return sb.ToString();
        }

        public abstract float CalcularCosto();
        /*public abstract float calcularCosto
        {
            get;
            set;
        }*/
        


        
    }
}
