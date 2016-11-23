using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eje47
{
    public interface ISerializable<T>
    {
        bool serializar(string archivo, T datos);
    }
}
