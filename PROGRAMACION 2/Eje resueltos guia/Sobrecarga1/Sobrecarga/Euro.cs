using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    public class Euro
    {
        public double _Plata;

        public Euro(double euro)
        {
            this._Plata = euro * 1.3642;
        }

        public static implicit operator Euro(double cantidad)
        {
            return new Euro(cantidad);
        }
        public static implicit operator double(Euro cantidad)
        {
            return cantidad._Plata;
        }
        /*
        //Suma
        public static Euro operator +(Euro euro1, Euro euro2)
        {
            euro1._Plata += euro2._Plata;
            return euro1;
        }

        public static Euro operator +(Euro euro1, double valor)
        {
            euro1._Plata += valor;
            return euro1;
        }

        public static Euro operator +(Euro euro1, Dolar dolar)
        {
            euro1._Plata += dolar._Plata;
            return euro1;
        }
        //Resta
        public static Euro operator -(Euro euro1, Euro euro2)
        {
            euro1._Plata -= euro2._Plata;
            return euro1;
        }

        public static Euro operator -(Euro euro, double euro2)
        {
            euro._Plata -= euro2;
            return euro;
        }

        public static Euro operator -(Euro euro, Dolar dolar)
        {
            euro._Plata -= dolar._Plata;
            return euro;
        }
        //Comparar

        public static bool operator ==(Euro euro, double valor)
        {
            if (euro._Plata == valor)
                return true;
            else return false;
        }

        public static bool operator ==(Euro euro, Dolar dolar)
        {
            if (euro._Plata == dolar._Plata)
                return true;
            else return false;
        }

        public static bool operator ==(Euro euro1, Euro euro2)
        {
            if (euro1._Plata == euro2._Plata)
                return true;
            else return false;
        }
        //distinto
        public static bool operator !=(Euro euro, double valor)
        {
            if (euro._Plata != valor)
                return true;
            else return false;
        }

        public static bool operator !=(Euro Euro, Dolar dolar)
        {
            if (Euro._Plata != dolar._Plata)
                return true;
            else return false;
        }

        public static bool operator !=(Euro euro1, Euro euro2)
        {
            if (euro1._Plata != euro2._Plata)
                return true;
            else return false;
        }
        //Incrementar

        public static Euro operator ++(Euro euro)
        {
            euro._Plata++;
            return euro;
        }
        public static Euro operator --(Euro euro)
        {
            euro._Plata--;
            return euro;
        }


        public static implicit operator Euro(Dolar valor)
        {
            return new Euro(valor._Plata / 1.3642);
        }*/
        public static Euro operator ++(Euro euroaux)
        {
            euroaux._Plata = euroaux._Plata + 1;

            return euroaux;
        }

        public static Euro operator --(Euro euroaux)
        {
            euroaux._Plata = euroaux._Plata - 1;

            return euroaux;
        }

        public static bool operator ==(Euro euroaux, int valor)
        {
            if (euroaux._Plata == valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Euro euroaux, int valor)
        {
            if (euroaux._Plata != valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Euro euroaux, Euro valor)
        {
            if (euroaux._Plata == valor._Plata)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Euro euroaux, Euro valor)
        {
            if (euroaux._Plata != valor._Plata)
            {
                return true;
            }
            else
            {
                return false;
            }
        }public static bool operator ==(Euro euroaux, Dolar valor)
        {
            if (euroaux._Plata == valor._Plata)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Euro euroaux, Dolar valor)
        {
            if (euroaux._Plata != valor._Plata)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
