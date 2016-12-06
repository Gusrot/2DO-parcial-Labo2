using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modeloFinal
{
    public static class MetodosDeExtension
    {
        public static bool EsPar(this Int32 numero)
        {
            if ((numero % 2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool EsImpar(this Int32 numero)
        {
            return !(EsPar(numero));
        }
    }
}
