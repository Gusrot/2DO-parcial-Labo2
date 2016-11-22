using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaAbstracta
{
    public abstract class Llamada
    {
        protected float _duracion;
        protected string _nrDestino;
        protected string _nrOrigen;

        #region Propiedades

        public abstract float CostoLlamada
        {
            get;
        }

        public float Duracion
        {
            get { return this._duracion; }
        }

        public string NroDestino
        {
            get { return this._nrDestino; }
        }

        public string NroOrigen
        {
            get { return this._nrOrigen; }
        }

        #endregion

        #region Constructor

        public Llamada(string origen,string destino,float duracion)
        {
            this._nrOrigen = origen;
            this._nrDestino = destino;
            this._duracion = duracion;
        }

        #endregion

        #region Metodos
        /*
        public abstract bool Equals(object obj)
        {
            return this.Equals(obj);
        }*/


        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Origen: " + this.NroOrigen);
            sb.AppendLine("Destino: " + this.NroDestino);
            sb.AppendLine("Duracion: " + this.Duracion);

            return sb.ToString();
            
        }

        public static int OrdenarPorDuracion(Llamada uno,Llamada dos)
        {
            return string.Compare(uno.Duracion.ToString(),dos.Duracion.ToString());
        }

        #endregion

        #region Sobrecarga de Operadores

        public static bool operator ==(Llamada uno, Llamada dos)
        {
            if (uno.Equals(dos) && dos.Equals(uno) && uno._nrDestino == dos._nrDestino && uno._nrOrigen == dos._nrOrigen)
                return true;
            return false;
        }

        public static bool operator !=(Llamada uno, Llamada dos)
        {
            return !(uno==dos);
        }

        #endregion

    }
}
