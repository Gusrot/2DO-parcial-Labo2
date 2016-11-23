using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Serializacion
{
    [XmlInclude(typeof(Alumno))]
    public class Persona : ISerializable2016
    {
        public string nombre;

        public Persona()
        {
 
        }

        public Persona(string nombre) : this()
        {
            this.nombre=nombre;
        }



        bool ISerializable2016.serializar()
        {
            return Serializador.SerializarPersona(this);
        }


        
    }
}
