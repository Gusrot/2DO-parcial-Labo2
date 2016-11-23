using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DespuesDeExcepciones
{
    public class Persona
    {
        public string nombre;
        public int dni;

        #region Constructor

        public Persona(string nombre, int dni)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        #endregion

        #region Metodos

        public override bool Equals(object obj)
        {
            if (this == (Persona)obj)
                return true;
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Dni: " + this.dni);
            return sb.ToString();
        }

        #endregion

        #region Sobrecarga de Operadores

        public static bool operator ==(Persona p1, Persona p2)
        {
            if (p1.nombre == p2.nombre && p1.dni == p2.dni)
                return true;
            return false;
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }

        #endregion
        
    }
}
