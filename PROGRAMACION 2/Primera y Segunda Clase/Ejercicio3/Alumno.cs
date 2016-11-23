using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Alumno
    {
        public int nota;
        public string nombre;

        public void MostrarDatos()
        {
            Console.WriteLine(this.nombre);
            Console.WriteLine(this.nota);
        }
        //Metodo Estatico (No funciona el this)
        public static bool Comparar(Alumno uno, Alumno dos)
        {
            if(uno.nombre == dos.nombre)
                return true;
            else
                return false;
            //return uno.Comparame(dos);
        }
        //Metodo Instancia
        public bool Comparame(Alumno otro)
        {
            if(this.nombre == otro.nombre)
                return true;
            else
                return false;


            //return Comparar(this, otro);

            
	    
        }
    }
}
