using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesInstanciables
{
    public class Jornada
    {
        private List<Alumno> _alumnos;
        private Gimnasio.EClases _clase;
        private Instructor _instructor;

        #region Constructores

        private Jornada()
        {
            this._alumnos = new List<Alumno>();
        }

        public Jornada(Gimnasio.EClases clase, Instructor instructor)
            : this()
        {
            this._clase = clase;
            this._instructor = instructor;
        }

        #endregion

        #region Metodos

        public bool Guardar(Jornada jornada)
        {
            return true;
        }

        public override string ToString()
        {
            StringBuilder sbJornada;
            sbJornada = new StringBuilder();

            foreach (var item in this._alumnos)
            {
                sbJornada.AppendLine(item.ToString());
            }

            return sbJornada.ToString();
        }

        #endregion

        #region Propiedades

        public Alumno this[int i]
        {
            get
            {
                if (i >= 0 && i < this._alumnos.Count)
                {
                    return this._alumnos[i];
                }
                else
                {
                    return null;
                }
            }
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach (Alumno item in j._alumnos)
            {
                if (j._alumnos.Contains(a))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            foreach (Alumno item in j._alumnos)
            {
                if (j != a)
                {
                    j._alumnos.Add(a);
                }
            }

            return j;
        }

        #endregion
    }
}
