using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace modeloFinal
{
    [Serializable]
    [XmlInclude(typeof(ProdVendido))]
    [XmlInclude(typeof(ProdImpuesto))]
    [XmlInclude(typeof(ProdExport))]
    public class Producto
    {
        public string nombre;
        public int stock;

        public Producto()
        { 
        
        }

        public Producto(string nombre, int stock)
        {
            this.nombre = nombre;
            this.stock = stock;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Stock
        {
            get { return this.stock; }
            set { this.stock = value;  }
        }

        public static bool operator ==(Producto productoUno, Producto productoDos)
        {
            if (productoUno.nombre == productoDos.nombre)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Producto productoUno, Producto productoDos)
        {
            return !(productoUno == productoDos);
        }
    }
}
