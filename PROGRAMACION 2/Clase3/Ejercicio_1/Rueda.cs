using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Rueda
    {
        public string _marca;
        public float _tamanio;
        /// <summary>
        /// constructor por defecto, inicializa la marca en 'sin marca'
        /// </summary>
        public Rueda() //Constructor por defecto
        {
            this._marca = "Sin marca";

        }
        /// <summary>
        /// constructor en sobrecarga, carga _marca con la pasada por parametro
        /// </summary>
        /// <param name="marca">
        /// marca a cargar
        /// </param>
        public Rueda(string marca)
        {
            this._marca = marca; 
        }
        /// <summary>
        /// constructor en sobrecarga, carga _tamanio con el pasado por parametro
        /// </summary>
        /// <param name="tamaño">
        /// tamaño a cargar
        /// </param>
        public Rueda(float tamaño):this()
        {
            
            this._tamanio = tamaño;
        }
        /// <summary>
        /// Constructor en sobrecarga, carga _marca con la pasada por parametro,
        /// carga _tamanio con el pasado por parametro
        /// </summary>
        /// <param name="marca"> Marca a cargar </param>
        /// <param name="tamaño"> Tamaño a cargar </param>
        public Rueda(string marca, float tamaño):this(tamaño)
        {
            this._marca = marca;
            
        }
        /// <summary>
        /// Constructor en sobrecarga, carga _marca con la pasada por parametro,
        /// carga _tamanio con el pasado por parametro
        /// </summary>
        /// <param name="marca"> Marca a cargar </param>
        /// <param name="tamaño"> Tamaño a cargar </param>
        public Rueda(float tamaño, string marca):this(marca)
        {
            
 
        }

        public void MostrarRueda()
        {
            Console.WriteLine("La marca es: " + _marca);
            Console.WriteLine("El tamaño es:" + _tamanio);
        }
    }
}
