using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Factura : Documento
    {
        public float importe;

        public Factura(int numero):base(numero)
        {
            base.Numero = numero;
        }

        public Factura(int numero,string fecha, int numdControl): base(numero,fecha,numdControl)
        {
            
        }
    }
}
