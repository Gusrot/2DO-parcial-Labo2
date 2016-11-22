using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public delegate void Jorge(string jorge);
    public class Clase
    {

        public string nombre;

        public Clase(string nombre)
        {
            this.nombre = nombre;
        }

        public event Jorge jorgeEvento;

        public void AgregarJorge(string nombre)
        {
            if (this.nombre == nombre)
                jorgeEvento(nombre);
        }

        /*public void Metodo2()
        {
            this.AgregarJorge("Jorge");
        }*/

        
    }
}
