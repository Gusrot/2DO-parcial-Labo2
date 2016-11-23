using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialProducto
{
    public class Producto
    {
        protected int _codigoDeBarra;
        protected EMarcaProducto _marca;
        public EMarcaProducto Marca
        {
            get { return this._marca; }
        }
        protected float _precio;
        public float Precio
        {
            get { return this._precio; }
        }


        public Producto(EMarcaProducto marca,int codigoDeBarra,float precio)
        {
            this._marca = marca;
            this._codigoDeBarra = codigoDeBarra;
            this._precio = precio;
        }


        protected static string MostrarProducto(Producto prod)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Marca: "+ prod.Marca);
            sb.AppendLine("Codigo: "+prod._codigoDeBarra);
            sb.AppendLine("Precio: "+prod.Precio);

            return sb.ToString();
        }


        public static explicit operator int(Producto prod)
        {
            return ((int)prod._codigoDeBarra);
        }

        public static bool operator ==(Producto prod1, EMarcaProducto marca)
        {
            if (prod1._marca == marca)
                return true;
            return false;
        }

        public static bool operator !=(Producto prod1, EMarcaProducto marca)
        {
            return !(prod1==marca);
        }

        public static bool operator ==(Producto prod1, Producto prod2)
        {
            if (prod1._codigoDeBarra == prod2._codigoDeBarra && prod1._marca == prod2._marca)
                return true;
            return false;
        }

        public static bool operator !=(Producto prod1, Producto prod2)
        {
            return !(prod1==prod2);
        }

        
        


    }
}
