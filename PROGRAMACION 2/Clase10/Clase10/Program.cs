using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Factura miFactura = new Factura(12,"hoy",45);
            List<Documento> miDocumento=new List<Documento>();
            FacturaA miFacturaA=new FacturaA(33,miFactura);
            FacturaAPagada miFacturaAPagada=new FacturaAPagada("hoy",miFacturaA);
            //Remito miRemito = new Remito(12);

            miDocumento.Add(miFactura);            
            //miDocumento.Add(miRemito);
            miDocumento.Add(miFacturaA);
            miDocumento.Add(miFacturaAPagada);
            foreach (Documento item in miDocumento)
            {
                item.Mostrar();
            }

            Console.ReadKey();

        }
    }
}
