using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {

        bool IArchivo<Texto>.guardar(string archivo,string  datos)
        {
            bool band;
            StreamWriter guardador = null;
            try
            {
                guardador = new StreamWriter(archivo, false);
                guardador.WriteLine(datos);
                band = true;
            }
            catch (Exception)
            {
                band = false;
            }
            finally
            {
                guardador.Close();
            }
            return band;
        }

        bool IArchivo<Texto>.leer(string archivo,out  string datos)
        {
            try
            {
                StreamReader sr = new StreamReader(archivo);

                datos = sr.ReadToEnd();

                sr.Close();

                return true;
            }
            catch (Exception e)
            {
                datos = default(string);
                throw new ArchivosException(e);
            }
        }
        
    }
}
