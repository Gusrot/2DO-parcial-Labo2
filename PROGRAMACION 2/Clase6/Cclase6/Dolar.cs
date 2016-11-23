using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cclase6
{
    public class Dolar
    {
        public float _valor;

        public Dolar(int valor)
        {
            this._valor = valor;
        }

        public static implicit operator int(Dolar dolar)
        {
            return dolar._valor;
        }

        public static implicit operator Dolar(int valor)
        {
            return new Dolar(valor);
        }

        public static Dolar operator +(Dolar dolar, Peso peso)
        {
            dolar._valor += peso._valor/15;
            return dolar;
        }
        public static implicit operator Dolar(Peso valor)
        {
            valor._valor = valor._valor / 15;
            return new Dolar(valor._valor);
        }

        

    }
}
