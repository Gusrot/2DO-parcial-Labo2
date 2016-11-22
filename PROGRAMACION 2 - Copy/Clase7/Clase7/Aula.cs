using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7
{
    public class Aula
    {
        public int numero;
        public Alumno[] listaDeAlumno;

        public Aula()
        {
            this.listaDeAlumno = new Alumno[10];
            /*for (int contadorDeAlumnos = 0; contadorDeAlumnos < 10; contadorDeAlumnos++)
            {
                this.listaDeAlumno[contadorDeAlumnos] = new Alumno();
            }
            No hacer nunca asi.
            foreach (Alumno objAlum in this.listaDeAlumno)
            {
                objAlum.nombre = "Natalia Natalia";
            }*/
        }

        public static void mostrarAlumno(Aula aula)
        {
            foreach (Alumno objAlum in aula.listaDeAlumno)
            {
                if ((object)objAlum != null)
                    Console.WriteLine("nombre: " + objAlum.nombre + " legajo: " + objAlum.legajo);
            }
        }
        /// <summary>
        /// devuelve el indice del primer elemento null de la contrario return -1
        /// </summary>
        /// <returns></returns>
        public int obtenerIndice()
        {
            int i;

            for (i = 0; i < 10; i++)
            {
                if ((object)listaDeAlumno[i] == null)
                    break;
            }

            if (i < 10)
                return i;
            return -1;
        }
        /// <summary>
        /// retorna el indice del objeto, de lo contrario retorna -1.
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>
        public int obtenerIndice(Alumno alumno)
        {
            int i;

            for (i = 0; i < 10; i++)
            {
                if ((object)this.listaDeAlumno[i] != null && this.listaDeAlumno[i] == alumno)
                    return this.listaDeAlumno[i].legajo;
            }
            return -1;
        }

        public void agregarAlumno(Alumno alumno)
        {
            int indice = this.obtenerIndice();
            int indice1 = this.obtenerIndice(alumno);

            if (indice != -1 && indice1 == -1)
            {
                this.listaDeAlumno[indice] = alumno;
            }
            else
            {
                if (indice == -1)
                    Console.WriteLine("Ya existe");
                else
                    Console.WriteLine("Array lleno");
            }
        }

        public void borrarAlumno(Alumno alumno)
        {
            int i;

            for (i = 0; i < 10; i++)
            {
                if ((object)this.listaDeAlumno[i] != null && this.listaDeAlumno[i].legajo == alumno.legajo)
                {
                    this.listaDeAlumno[i] = null;
                    break;
                }
            }
        }

        public bool existeAlumno(Alumno alumno)
        {
            for (int i = 0; i < 10; i++)
            {
                if ((object)this.listaDeAlumno[i] != null && this.listaDeAlumno[i].legajo == alumno.legajo)
                    return true;
            }
            return false;
        }

        

    }
}
