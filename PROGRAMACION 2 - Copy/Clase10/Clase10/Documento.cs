using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Documento
    {
        public int Numero;
        public string Fecha;
        public int _numeroDeControl;

        public Documento(int numero,string fecha, int numdControl): this(numero)
        {
            this.Fecha = fecha;
            this._numeroDeControl = numero;
        }

        public Documento(int numero)
        {
            this.Numero = numero;
        }


        public void Mostrar()
        { 
            Console.WriteLine(this.Numero);
            Console.WriteLine(this._numeroDeControl);
            Console.WriteLine(this.Fecha);
        }
    }
}
