using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public abstract class Local
    {
        private string _direccion;
        private int _anchoDeFrente;

        public string Direccion
        {
            set { this._direccion = value; }
            get { return this._direccion; }
        }

        public int AnchoDeFrente
        {
            set { this._anchoDeFrente = value; }
            get { return this._anchoDeFrente; }
        }

        protected abstract int Legajo
        {
            get;
            set;
        }

        public Local(string direccion, int ancho)
        {
            this._direccion = direccion;
            this._anchoDeFrente = ancho;
        }

        public Local() { }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Direccion: " + this._direccion);
            sb.AppendLine("Ancho del frente: " + this._anchoDeFrente);
            sb.AppendLine("Legajo: " + this.Legajo);

            return sb.ToString();
        }
    }
}
