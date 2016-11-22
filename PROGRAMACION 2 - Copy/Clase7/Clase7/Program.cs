using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7
{
    class Program
    {
        static void Main()
        {
            Aula miPrimerAula = new Aula();
            //Aula.mostrarAlumno(miPrimerAula);
            bool existe;

            Alumno alumno1 = new Alumno("Alan", 1);
            Alumno alumno2 = new Alumno("Alan", 1);
            Alumno alumno3 = new Alumno("Tevez", 3);
            Alumno alumno4 = new Alumno("Braian", 4);

            /*miPrimerAula.agregarAlumno(alumno1);
            miPrimerAula.agregarAlumno(alumno2);
            miPrimerAula.agregarAlumno(alumno3);
            miPrimerAula.borrarAlumno(alumno2);
            miPrimerAula.agregarAlumno(alumno4);*/
            miPrimerAula.agregarAlumno(alumno1);
            miPrimerAula.agregarAlumno(alumno2);
            miPrimerAula.agregarAlumno(alumno3);
            miPrimerAula = miPrimerAula + alumno1;

            if (alumno1 != alumno2)
                Console.WriteLine("el alu 1 no es igual al alu2");
            else Console.WriteLine("el alu 1 es igual al alu2");

            //miPrimerAula.listaDeAlumno[0].nombre="lalala";
            existe = miPrimerAula.existeAlumno(alumno2);
            Aula.mostrarAlumno(miPrimerAula);
            Console.WriteLine(existe);
            Console.ReadKey();
        }
    }
}
