using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    public sealed class Instructor : PersonaGimnasio
    {
        private Queue<Gimnasio.EClases> _clasesDelDia;
        private static Random _random;

        #region Constructores

        static Instructor()
        {
            _random = new Random();
        }

        public Instructor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this._randomClase();
        }

        #endregion

        #region Metodos

        private void _randomClase()
        {
            int randomUno;
            int randomDos;

            randomUno = _random.Next(1, 3);
            randomDos = _random.Next(1, 3);

            this._clasesDelDia.Enqueue((Gimnasio.EClases)randomUno);
            this._clasesDelDia.Enqueue((Gimnasio.EClases)randomDos);
        }

        protected override string MostrarDatos()
        {
            StringBuilder sbInstructor;
            sbInstructor = new StringBuilder();

            sbInstructor.AppendLine(base.MostrarDatos());
            sbInstructor.AppendLine(this.ParticiparEnClase());

            return sbInstructor.ToString();
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder sbInstructor;
            sbInstructor = new StringBuilder();

            sbInstructor.AppendLine("--Clases del dia--");

            foreach (Gimnasio.EClases item in this._clasesDelDia)
            {
                sbInstructor.AppendLine(item.ToString());
            }

            return sbInstructor.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(Instructor instructor, Gimnasio.EClases clase)
        {
            foreach (var item in instructor._clasesDelDia)
            {
                if (item == clase)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Instructor instructor, Gimnasio.EClases clase)
        {
            return !(instructor == clase);
        }

        #endregion
    }
}
