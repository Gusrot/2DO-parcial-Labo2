using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial_38
{
    public class Conclave
    {
        private int _cantMaxCardenales;
        private List<Cardenal> _cardenales;
        private bool _habemusPapa;
        private string _lugarEleccion;
        private Cardenal _papa;
        public static int cantidadVotaciones;
        public static DateTime fechaVotacion;
        

        #region Constructores

        static Conclave()
        {
            cantidadVotaciones = 0;
            fechaVotacion = DateTime.Now;
        }

        public Conclave()
        {
            this._cantMaxCardenales = 1;
            this._lugarEleccion = "Capilla Sixtina";
        }

        private Conclave(int cantidadCardenales):this()
        {
            this._cardenales = new List<Cardenal>(cantidadCardenales);
        }

        public Conclave(int cantidadCardenales,string lugarEleccion):this(cantidadCardenales)
        {
 
        }

        #endregion

        #region Metodos

        private static void ContarVotos(Conclave conclave)
        {
        }

        public static void VotarPapa(Conclave conclave)
        {
            Random rdm = new Random();
            int i;

            foreach (var item in conclave._cardenales)
            {
                i=rdm.Next(1,conclave._cardenales.Capacity);
                conclave._cardenales[i]++;
            }

        }



        private bool HayLugar()
        {
            if (this._cantMaxCardenales < this._cardenales.Capacity)
                return true;
            return false;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lugar: "+this._lugarEleccion);
            sb.AppendLine("Fecha: "+fechaVotacion);
            sb.AppendLine("Total Votos: "+cantidadVotaciones);

            if (this._habemusPapa == true)
            {
                sb.AppendLine("HABEMUS PAPA");
                sb.AppendLine(this._papa.ObtenerNombreyNombrePapal());
            }
            else
            {
                sb.AppendLine("NO HABEMUS PAPA");
                sb.AppendLine(this.MostrarCardenales());
            }

            return sb.ToString();
        }

        private string MostrarCardenales()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Cardenal item in this._cardenales)
            {
                sb.AppendLine(Cardenal.Mostrar(item));
            }

            return sb.ToString();
        }


        #endregion

        #region Operadores

        public static explicit operator bool(Conclave con)
        {
            return con._habemusPapa;
        }

        public static implicit operator Conclave(int cantidadCardenales)
        {
            return new Conclave(cantidadCardenales);
        }

        public static bool operator ==(Conclave con, Cardenal c)
        {
            foreach (Cardenal item in con._cardenales)
            {
                if (con._cardenales.Contains(item))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Conclave con, Cardenal c)
        {
            return !(con==c);
        }

        public static Conclave operator +(Conclave con, Cardenal c)
        {
            if (con.HayLugar())
            {
                if (con == c)
                {
                    con._cardenales.Add(c);
                }
            }

            return con;

        }

        #endregion
    }
}
