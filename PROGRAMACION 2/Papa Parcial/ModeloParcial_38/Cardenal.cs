using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial_38
{
    public class Cardenal
    {
        private string _nombrePapal, _nombre;
        private ENacionalidades _nacionalidad;
        private int _cantVotosRecibidos;

        #region Constructores

        private Cardenal()
        {
            _cantVotosRecibidos = 0;
        }

        public Cardenal(string nombre,string nombrePapal)
        {
            this._nombre = nombre;
            this._nombrePapal = nombrePapal;
        }

        public Cardenal(string nombre, string nombrePapal,ENacionalidades nacionalidad):this(nombre,nombrePapal)
        {
            this._nacionalidad = nacionalidad;
        }
        #endregion

        #region Metodos

        public int getCantidadVotosRecibidos()
        {
            return this._cantVotosRecibidos;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ObtenerNombreyNombrePapal());
            sb.AppendLine("Nacionalidad: "+this._nacionalidad);
            sb.AppendLine("Votos: "+this._cantVotosRecibidos);

            return sb.ToString();
        }

        public static string Mostrar(Cardenal c)
        {
            return c.Mostrar();
        }

        public string ObtenerNombreyNombrePapal()
        {
            return (("El cardenal " + this._nombre + " se llamara " + this._nombrePapal).ToString());
        }

        #endregion

        #region Operadores

        public static bool operator ==(Cardenal c1,Cardenal c2)
        {
            if (c1._nombre == c2._nombre && c1._nombrePapal == c2._nombrePapal && c1._nacionalidad == c2._nacionalidad)
                return true;
            return false;
        }

        public static bool operator !=(Cardenal c1,Cardenal c2)
        {
            return !(c1==c2);
        }

        public static Cardenal operator ++(Cardenal c)
        {
            c._cantVotosRecibidos++;
            return c;
        }

        #endregion
    }
}
