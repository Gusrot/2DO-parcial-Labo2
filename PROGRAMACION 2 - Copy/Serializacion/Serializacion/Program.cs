using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serializacion
{
    class Program
    {
        static void Main()
        {
            /*List<Persona> listadoPer = new List<Persona>();

            listadoPer.Add(new Persona("Jorge"));
            listadoPer.Add(new Persona("Alan"));
            listadoPer.Add(new Alumno("Juan",123));

            Aula a1 = new Aula(12, new Persona("Jorge Profe"), listadoPer,"Aula de jorge");*/

            Persona per = new Persona("Jorge");
            ((ISerializable2016)per).serializar();
            ((ISerializable2016)per).deserializar();
            

            //Serializador.SerializarAula(a1);
        }
    }
}
