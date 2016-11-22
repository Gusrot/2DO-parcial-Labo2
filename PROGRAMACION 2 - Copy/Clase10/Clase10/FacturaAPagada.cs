using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class FacturaAPagada : FacturaA
    {
        public string fechadepago;

        public FacturaAPagada(string FechaDePago,FacturaA unaFacA):base(unaFacA.Iva,unaFacA)
        {
            this.fechadepago = FechaDePago;
        }
    }
}
