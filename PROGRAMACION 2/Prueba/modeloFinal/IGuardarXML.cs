using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modeloFinal
{
    public interface IGuardarXML<T>
    {
       bool serializarXML(Galpon<T> arg);
    }
}
