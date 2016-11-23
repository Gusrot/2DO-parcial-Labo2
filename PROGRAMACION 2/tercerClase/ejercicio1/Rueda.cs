using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Rueda
    {
        public string marca;
        public float tamaño;

        /// <summary>
        /// Constructor por defecto, inicializa todas las marcas en "sin marca".
        /// </summary>
       
        public Rueda()
        {
            this.marca = "sin marca";
        }

        /// <summary>
        /// Constructor por string, inicializa la marca de la rueda segun el parametro que le pasemos.
        /// PRIMER TIPO DE FIRMA
        /// </summary>
        /// <param name="marca">Marca es la marca de la rueda</param>

        public Rueda(string marca)
        {
            this.marca = marca;
        }

        /// <summary>
        /// Constructor por int, inicializa el tamaño de la rueda segun el tamaño que le pasemos.
        /// SEGUNDO TIPO DE FIRMA
        /// </summary>
        /// <param name="tamanio">refiere al tamaño de nuestra rueda</param>

        public Rueda(int tamanio) : this()
        {
            this.tamaño = tamanio;
        }

        /// <summary>
        /// Constructor mediante un entero y una cadena, se le pasan las dos caracteristicas de la rueda a la vez (tamaño y marca)
        /// TERCER TIPO DE FIRMA
        /// </summary>
        /// <param name="marca">marca de la rueda</param>
        /// <param name="tamanio">tamaño de la rueda</param>

        public Rueda(string marca, int tamanio) : this(tamanio)
        {
            this.marca = marca;
            //this.tamaño = tamanio;
        }

        /// <summary>
        /// Constructor mediante un entero y una cadena, se le pasan las dos caracteristicas de la rueda a la vez (dueño y marca)
        /// CUARTO TIPO DE FIRMA
        /// </summary>
        /// <param name="marca">dueño de la rueda</param>
        /// <param name="tamanio">tamaño de la rueda</param>

        public Rueda(int tamanio, string marca) : this(marca, tamanio)
        {
            //this.marca = dueño;
            //this.tamaño = tamanio;
        }

        public void MostrarRueda()
        {
            Console.WriteLine("Tamaño: " + this.tamaño);
        }
    }
}
