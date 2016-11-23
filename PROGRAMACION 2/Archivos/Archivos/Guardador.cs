using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public static class Guardador
    {
        // Pasar obj de memoria a archivo ===> Serializacion
        public static bool GuardarPersona(Persona unaPersona)
        {
            bool flag;
            StreamWriter escritor = null;
            try
            {
                escritor = new StreamWriter("Personas.txt", true);
                escritor.WriteLine(unaPersona.ToString());
                flag = true;
            }
            catch (Exception)
            {
                flag = false;
            }
            finally
            {
                escritor.Close();
            }

            return flag;
        }

        public static Persona LeerUnaPersona()
        {
            Persona unaPersona = null;
            StreamReader lector = null;

            try
            {
                string st;
                string[] arrayString;
                lector = new StreamReader("Personas.txt");
                st = lector.ReadLine();
                arrayString = st.Split(',');
                unaPersona = new Persona(arrayString[0], arrayString[1]);
            }
            catch (Exception)
            {

            }
            finally
            {
                lector.Close();
            }

            return unaPersona;
        }

        public static List<Persona> RetornarListado()
        {
            List<Persona> listadoPersonas = null;
            try
            {
                listadoPersonas = new List<Persona>();
                using (StreamReader lector = new StreamReader("Personas.txt"))
                {
                    string renglon;
                    string[] arrayString;

                    while ((renglon = lector.ReadLine()) != null)
                    {
                        arrayString = renglon.Split(',');
                        listadoPersonas.Add(new Persona(arrayString[0], arrayString[1]));
                    }
                }
            }
            catch (Exception)
            {
                
            }

            return listadoPersonas;
        }
    }
}
