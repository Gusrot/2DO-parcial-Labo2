using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {

        public bool guardar(string archivo, out T datos)
        {
            throw new NotImplementedException();
        }

        public bool leer(string archivo,out T datos)
        {
            throw new NotImplementedException();
        }
    }
}
