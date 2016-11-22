using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DespuesDeExcepciones
{
    public class Vehiculo
    {
        public string marca;
        public ConsoleColor color;
        public int patente;

        #region Constructores

        public Vehiculo(string marca, ConsoleColor color, int patente)
        {
            this.marca = marca;
            this.color = color;
            this.patente = patente;
        }

        #endregion

        public override bool Equals(object obj)
        {
            if (this == (Vehiculo)obj)
                return true;
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Marca: " + this.marca);
            sb.AppendLine("Patente: " + this.patente);
            sb.AppendLine("Color: " + this.color);
            return sb.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (v1.patente == v2.patente && v1.color == v2.color && v1.marca == v2.marca)
                return true;
            else return false;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
