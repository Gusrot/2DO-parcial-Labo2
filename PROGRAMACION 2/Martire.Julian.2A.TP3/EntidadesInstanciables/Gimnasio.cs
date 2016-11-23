using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excepciones;

namespace EntidadesInstanciables
{
    public class Gimnasio
    {
        private List<Alumno> _alumnos;
        private List<Instructor> _instructores;
        private List<Jornada> _jornada;

        public enum EClases
        {
            CrossFit,
            Natacion,
            Pilates,
            Yoga
        }

        #region Constructores

        public Gimnasio()
        {
            this._alumnos = new List<Alumno>();
            this._instructores = new List<Instructor>();
            this._jornada = new List<Jornada>();
        }

        #endregion

        #region Metodos

        public static bool Guardar(Gimnasio gim)
        {
            return true;
        }

        private static string MostrarDatos(Gimnasio gim)
        {
            StringBuilder sbGimnasio;
            sbGimnasio = new StringBuilder();

            foreach (Alumno item in gim._alumnos)
            {
                sbGimnasio.AppendLine(item.ToString());
            }

            foreach (Jornada item in gim._jornada)
            {
                sbGimnasio.AppendLine(item.ToString());
            }

            foreach (Instructor item in gim._instructores)
            {
                sbGimnasio.AppendLine(item.ToString());
            }

            return sbGimnasio.ToString();
        }

        public override string ToString()
        {
            return Gimnasio.MostrarDatos(this);
        }

        #endregion

        #region Propiedades

        public List<Alumno> Alumnos
        {
            get
            {
                return this._alumnos;
            }
        }

        public List<Instructor> Instructores
        {
            get
            {
                return this._instructores;
            }
        }

        public Jornada this[int i]
        {
            get
            {
                return this._jornada[i];
            }
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(Gimnasio gim, Alumno a)
        {
            /*foreach (Alumno item in gim._alumnos)
            {*/
            if (gim._alumnos.Contains(a))
            {
                return true;
            }
            //}

            return false;
        }

        public static bool operator !=(Gimnasio gim, Alumno a)
        {
            return !(gim == a);
        }

        public static Instructor operator ==(Gimnasio gim, EClases clase)
        {
            foreach (Instructor item in gim._instructores)
            {
                if (item == clase)
                {
                    return item;
                }
            }

            throw new Exception("No hay instructor");
        }

        public static Instructor operator !=(Gimnasio gim, EClases clase)
        {
            foreach (Instructor item in gim._instructores)
            {
                if (item != clase)
                {
                    return item;
                }
            }

            throw new Exception("Todos los instructores están en esa clase");
        }

        public static bool operator ==(Gimnasio gim, Instructor i)
        {
            if (gim._instructores.Contains(i))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Gimnasio gim, Instructor i)
        {
            return !(gim == i);
        }

        public static Gimnasio operator +(Gimnasio gim, Alumno alu)
        {
            if (gim != alu)
            {
                gim._alumnos.Add(alu);
            }
            else
            {
                Console.WriteLine("El alumno ingresado ya existe en el gimnasio");
            }

            return gim;
        }

        public static Gimnasio operator +(Gimnasio gim, EClases clase)
        {
            switch (clase)
            {
                case EClases.CrossFit:
                    Jornada auxJornadaUno;
                    auxJornadaUno = new Jornada(clase, gim == clase);

                    for (int i = 0; i < gim._alumnos.Count; i++)
                    {
                        if (gim._alumnos[i] == clase)
                        {
                            auxJornadaUno = auxJornadaUno + gim._alumnos[i];
                        }
                    }

                    gim._jornada.Add(auxJornadaUno);
                    return gim;
                case EClases.Natacion:
                    Jornada auxJornadaDos;
                    auxJornadaDos = new Jornada(clase, gim == clase);

                    for (int i = 0; i < gim._alumnos.Count; i++)
                    {
                        if (gim._alumnos[i] == clase)
                        {
                            auxJornadaDos = auxJornadaDos + gim._alumnos[i];
                        }
                    }

                    gim._jornada.Add(auxJornadaDos);
                    return gim;
                case EClases.Pilates:
                    Jornada auxJornadaTres;
                    auxJornadaTres = new Jornada(clase, gim == clase);

                    for (int i = 0; i < gim._alumnos.Count; i++)
                    {
                        if (gim._alumnos[i] == clase)
                        {
                            auxJornadaTres = auxJornadaTres + gim._alumnos[i];
                        }
                    }

                    gim._jornada.Add(auxJornadaTres);
                    return gim;
                default:
                    return gim;
            }
        }

        public static Gimnasio operator +(Gimnasio gim, Instructor i)
        {
            if (gim != i)
            {
                gim._instructores.Add(i);
            }
            else
            {
                Console.WriteLine("El instructor ya existe");
            }

            return gim;
        }

        #endregion
    }
}
