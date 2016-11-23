using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Text;

namespace eje47
{
    public class Serializador<T> : ISerializable<T>
    {
        /*public static void Serializar(List<Animal> datos)
        {
            XmlSerializer serializador;
            XmlTextWriter escritor;

            try
            {
                using (escritor = new XmlTextWriter("Gato.xml", Encoding.UTF8))
                {
                    serializador = new XmlSerializer(typeof(Animal));

                    serializador.Serialize(escritor, datos);
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }*/

        public bool serializar(string archivo, T datos)
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(T));
                    serializador.Serialize(escritor, datos);
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
