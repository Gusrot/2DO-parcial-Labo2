using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialProducto
{
    public class Galletita : Producto
    {
        protected float _peso;

        public Galletita(int codigo, float precio, EMarcaProducto marca, float peso) : base(marca, codigo, precio)
        {
            this._peso = peso;
        }

        public string MostrarGalletita()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Producto.MostrarProducto(this));
            sb.AppendLine("Peso: "+this._peso);

            return sb.ToString();
        }

    }
}
