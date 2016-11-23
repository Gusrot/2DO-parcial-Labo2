using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class NoLeeException:Exception
    {
        public NoLeeException(Exception e)
            : this("Error al leer.", e)
        {

        }

        public NoLeeException(string message, Exception e)
            : base(message)
        {

        }
    }
}
