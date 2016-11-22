using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        Random random = new Random();

        public void CalcularFinal()
        {
            if (nota1 >= 4 && nota2 >= 4)
                notaFinal = random.Next(0, 10);
            else
                notaFinal = -1;
        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            nota1 = notaUno;
            nota2 = notaDos;
        }
        public void Mostrar()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine(nombre);
            Console.WriteLine(apellido);
            Console.WriteLine("Legajo: " + legajo);
            Console.WriteLine("Nota 1: " + nota1);
            Console.WriteLine("Nota 2: " + nota2);
            if (notaFinal != -1)
                Console.WriteLine("Final: " + notaFinal);
        }
    }
}
