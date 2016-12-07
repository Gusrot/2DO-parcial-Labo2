using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modeloFinal
{
    public class ProdImpuesto : Producto
    {
        public int cantidad;

        public ProdImpuesto()
        {

        }

        public ProdImpuesto(string nombre,int impuesto) : base(nombre,impuesto)
        { 
            
        }
    }
}
