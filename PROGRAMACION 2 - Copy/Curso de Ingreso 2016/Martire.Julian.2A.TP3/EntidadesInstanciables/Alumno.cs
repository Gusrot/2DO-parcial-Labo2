using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    public sealed class Alumno : PersonaGimnasio
    {
        private Gimnasio.EClases _claseQueToma;
        private EEstadoCuenta _estadoCuenta;

        public enum EEstadoCuenta
        {
            MesPrueba,
            Deudor,
            AlDia
        }

        #region Constructores

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Gimnasio.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this._claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Gimnasio.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this._estadoCuenta = estadoCuenta;
        }

        #endregion

        #region Metodos

        protected override string MostrarDatos()
        {
            StringBuilder sbAlumno;
            sbAlumno = new StringBuilder();

            sbAlumno.AppendLine(base.MostrarDatos());
            sbAlumno.AppendLine(this.ParticiparEnClase());
            sbAlumno.AppendLine("Estado de cuenta: " + this._estadoCuenta);

            return sbAlumno.ToString();
        }

        protected override string ParticiparEnClase()
        {
            return ("Toma clase de: " + this._claseQueToma);
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(Alumno alumno, Gimnasio.EClases clase)
        {
            if (alumno._claseQueToma == clase && alumno._estadoCuenta != EEstadoCuenta.Deudor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Alumno alumno, Gimnasio.EClases clase)
        {
            if (alumno._claseQueToma != clase)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
