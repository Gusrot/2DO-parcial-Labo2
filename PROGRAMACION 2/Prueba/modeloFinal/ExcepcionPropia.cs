using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modeloFinal
{
    public class ExcepcionPropia:Exception
    {
        public ExcepcionPropia(string mensaje):base(mensaje)
        {

        }
    }
}
