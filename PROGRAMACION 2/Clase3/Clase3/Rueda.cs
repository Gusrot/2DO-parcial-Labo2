using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    public class Rueda
    {
        public string _Marca;
        public float _Tamaño;
        /// <summary>
        /// Este inicializa la marca en "Sin marca".
        /// </summary>
        public Rueda ()
        {
            this._Marca="Sin marca";
        }
        /// <summary>
        /// Este se inicializa la marca y el tamaño de la rueda.
        /// </summary>
        /// <param name="marca"></param>Se pasa la marca de la rueda.
        /// <param name="tamaño"></param>Se pasa el tamaño de la rueda.
        public Rueda(int tamaño):this()
        {
            this._Tamaño = tamaño;
        }
        /// <summary>
        /// Este se inicializa el tamaño y la marca de la rueda.
        /// </summary>
        /// <param name="tamaño"></param>Se pasa el tamaño de la rueda.
        /// <param name="marca"></param>Se pasa la marca de la rueda.
        public Rueda(string marca,int tamaño):this(tamaño)
        {
            this._Marca=marca;
        }


        public void MostrarTamaño()
        {
            Console.WriteLine("El tamaño es: " + this._Tamaño);
        }
        public void MostrarRueda()
        {
            Console.WriteLine("El tamaño es: " + this._Tamaño);
            Console.WriteLine("El rueda es: " + this._Marca);
        }
    }
}
