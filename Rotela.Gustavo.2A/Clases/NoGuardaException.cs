using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class NoGuardaException:Exception
    {
        public NoGuardaException():base()
        {

        }

        public NoGuardaException(Exception e)
            : this(e, "Error al guardar mensaje")
        {
 
        }

        public NoGuardaException(Exception e, string mensaje):base(mensaje)
        {

        }
    }
}
