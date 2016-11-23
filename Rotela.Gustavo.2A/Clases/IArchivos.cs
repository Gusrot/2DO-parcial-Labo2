using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    interface IArchivos<T>
    {
        bool guardar(string archivo, T datos);
        bool leer(string archivo, out T datos);
    }
}
