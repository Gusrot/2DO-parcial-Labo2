using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DespuesDeExcepciones
{
    public class Mascota
    {
        public string nombre;
        public string raza;

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        public override bool Equals(object obj)
        {
            if (this == (Mascota)obj)
                return true;
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: "+this.nombre);
            sb.AppendLine("Raza: "+this.raza);
            return sb.ToString();
        }

        public static bool operator ==(Mascota m1, Mascota m2)
        {
            if (m1.raza == m2.raza && m1.nombre == m2.nombre)
                return true;
            return false;
        }

        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }
    }
}
