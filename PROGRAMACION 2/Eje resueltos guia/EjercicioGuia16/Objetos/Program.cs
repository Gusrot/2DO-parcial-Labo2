using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    class Program
    {
        static void Main()
        {
            Alumno uno = new Alumno();
            Alumno dos = new Alumno();
            Alumno tres = new Alumno();

            uno.nombre = "Jorge";
            uno.apellido = "Lopez";
            uno.legajo = 1;

            dos.nombre = "Alan";
            dos.apellido = "Brado";
            dos.legajo = 2;

            tres.nombre = "eël";
            tres.apellido = "Wiiiíle";
            tres.legajo = 3;

            uno.Estudiar(4, 4);
            dos.Estudiar(6, 7);
            tres.Estudiar(4, 4);

            uno.CalcularFinal();
            dos.CalcularFinal();
            tres.CalcularFinal();

            uno.Mostrar();
            dos.Mostrar();
            tres.Mostrar();

            Console.ReadKey();
        }
    }
}
