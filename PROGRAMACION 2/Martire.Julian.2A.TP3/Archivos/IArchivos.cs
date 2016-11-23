using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Archivos
{
    public interface IArchivos<T>
    {
        abstract bool guardar(string archivos, out T datos);
        abstract bool leer(string archivos, out T datos);
    }
}
