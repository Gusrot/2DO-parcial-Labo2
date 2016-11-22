using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DespuesDeExcepciones
{
    public class Producto
    {
        public int codigo;
        public string descripcion;
        public float precioDeVenta;

        #region Constructor

        public Producto(int codigo, string descripcion, float precio)
        {
            this.precioDeVenta = precio;
            this.descripcion = descripcion;
            this.codigo = codigo;
        }

        #endregion

        #region Metodos

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Codigo: " + this.codigo);
            sb.AppendLine("Precio Venta: " + this.precioDeVenta);
            sb.AppendLine("Descripcion: " + this.descripcion);

            return sb.ToString();
        }

        #endregion

        #region Sobrecarga de Operadores

        public static bool operator ==(Producto uno, Producto dos)
        {
            if (uno.codigo == dos.codigo)
                return true;
            return false;
        }

        public static bool operator !=(Producto uno, Producto dos)
        {
            return !(uno == dos);
        }

        public override bool Equals(object obj)
        {
            if (this == (Producto)obj)
                return true;
            return false;
        }

        #endregion
        

        

    }
}
