using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7
{
    public class Alumno
    {
        public string nombre;
        public int legajo;

        public Alumno(string nombre, int legajo)
        {
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public static bool operator ==(Alumno alumno1, Alumno alumno2)
        {
                if (alumno1.legajo == alumno2.legajo)
                    return true;            
            return false;
        }

        public static bool operator ==(Aula aula, Alumno alumno)
        {
            /*if (aula == alumno)
                return true;
            return false;*/
            return aula.existeAlumno(alumno);
        }

        public static bool operator !=(Alumno alumno1, Alumno alumno2)
        {
            if (alumno1.legajo != alumno2.legajo)
               return true;
            
            return false;
        }

        public static bool operator !=(Aula aula, Alumno alumno)
        {
            return !(aula.existeAlumno(alumno));
        }

        public static Aula operator +(Aula aula, Alumno alumno)
        {
            aula.agregarAlumno(alumno);
            return aula;
        }

        public static Aula operator -(Aula aula, Alumno alumno)
        {
            aula.borrarAlumno(alumno);
            return aula;
        }

        public bool Equals(Alumno alumno, Aula aula)
        {
            if ((object)alumno == aula)
                return true;
            return false;
        }
    }
}
