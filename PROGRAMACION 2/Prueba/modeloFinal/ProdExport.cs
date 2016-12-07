using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modeloFinal
{
    public class ProdExport : Producto
    {
        public int cantidad;

        public ProdExport() : base()
        { 
            
        }

        public ProdExport(string nombre,int stock):base(nombre,stock)
        {

        }
    }
}
