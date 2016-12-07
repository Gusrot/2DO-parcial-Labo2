using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modeloFinal
{
    public class ProdVendido : Producto
    {
        public int cantidad;

        public ProdVendido()
        {

        }

        public ProdVendido(string nombre,int stock) : base(nombre,stock)
        { 
            
        }
    }
}
