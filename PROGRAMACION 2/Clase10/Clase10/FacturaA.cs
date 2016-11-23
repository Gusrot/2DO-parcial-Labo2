using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class FacturaA : Factura
    {
        public int Iva;

        public FacturaA(int iva,Factura unaFac):base(unaFac.Numero,unaFac.Fecha,unaFac._numeroDeControl)
        {
            this.Iva = iva;
        }
    }
}
