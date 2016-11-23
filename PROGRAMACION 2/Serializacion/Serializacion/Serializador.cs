using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Serializacion
{
    public static class Serializador
    {
        public static bool SerializarPersona(Persona per)
        {
            using (XmlTextWriter escritor = new XmlTextWriter("Persona.xml", Encoding.UTF8))
            {
                try
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Persona));
                    serializador.Serialize(escritor, per);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static void SerializarListadoPersona(List<Persona> per)
        {
            using (XmlTextWriter escritor = new XmlTextWriter("ListadoPersona.xml", Encoding.UTF8))
            {
                try
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<Persona>));
                    serializador.Serialize(escritor, per);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        

        public static void SerializarAula(Aula aula)
        {
            using (XmlTextWriter escritor = new XmlTextWriter("ListadoAula.xml", Encoding.UTF8))
            {
                try
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Aula));
                    serializador.Serialize(escritor, aula);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static bool SerializarGenerico(ISerializable2016 is2016)
        {
            return is2016.serializar();
        }

        public static Persona DeserializarPersona()
        {
            Persona persona = null;

            using (XmlTextReader lector = new XmlTextReader("PersonaSerializada.xml"))
            {
                try
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Persona));
                    persona = (Persona)serializador.Deserialize(lector);
                    return persona;
                }
                catch (Exception)
                {

                    return persona;
                }
            }
        }

        /*public static Persona DeserializarPersona(Persona per)
        {
            Persona persona = null;

            using (XmlTextReader lector = new XmlTextReader("PersonaSerializada.xml")) 
            {
                try
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Persona));
                    persona=(Persona)serializador.Deserialize(lector);
                    return persona;
                }
                catch (Exception)
                {

                    return persona;
                }
            }
        }*/

        
    }
}
