using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Persona
    {
        private string _nombre;
        private string _clave;

        public Persona(string nombre, string clave)
        {
            this._nombre = nombre;
            this._clave = clave;
        }

        public override string ToString()
        {
            return this._nombre + "," + this._clave;
        }
    }
}
