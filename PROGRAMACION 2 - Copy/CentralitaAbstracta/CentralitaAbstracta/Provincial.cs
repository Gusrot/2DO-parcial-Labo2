using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaAbstracta
{
    public class Provincial : Llamada
    {
        protected Franja _franjahoraria;

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Provincial(Franja miFranja,Llamada unaLlamada)
            : this(unaLlamada.NroOrigen,miFranja,unaLlamada.Duracion,unaLlamada.NroDestino)
        {

        }

        public Provincial(string origen,Franja miFranja,float duracion,string destino)
            : base(origen,destino,duracion)
        {
            this._franjahoraria = miFranja;
        }

        private float CalcularCosto()
        {
            switch (this._franjahoraria)
            {
                case Franja.Franja_1:
                    return this._duracion * 0.99f;
                case Franja.Franja_2:
                    return this._duracion * 1.25f;
                case Franja.Franja_3:
                    return this._duracion * 0.66f;
            }

            return 0f;
        }

        public override bool Equals(object obj)
        {
            if (obj is Provincial)
                return true;
            else return false;
        }

        /*public bool Equals(object obj)
        {
            if (obj is Provincial)
                return true;
            return false;
        }*/

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Franja: "+this._franjahoraria);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
