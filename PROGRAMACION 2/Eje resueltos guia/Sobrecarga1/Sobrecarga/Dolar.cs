using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    public class Dolar
    {

        public double _Plata;

        public Dolar(double dolar)
        {
            this._Plata = dolar;
        }
        public static implicit operator Dolar(double cantidad)
        {
            return new Dolar(cantidad);
        }
        public static implicit operator double(Dolar moneda)
        {
            return moneda._Plata;
        }        
        /*
        //Suma
        public static Dolar operator +(Dolar dolar1, Dolar dolar2)
        {
            dolar1._Plata += dolar2._Plata;
            return dolar1;
        }

        public static Dolar operator +(Dolar dolar1, double valor)
        {
            dolar1._Plata += valor;
            return dolar1._Plata;
        }

        public static Dolar operator +(Dolar dolar, Euro euro)
        {
            dolar._Plata += euro._Plata;
            return dolar;
        }
        //Resta
        public static Dolar operator -(Dolar dolar1, Dolar dolar2)
        {
            dolar1._Plata -= dolar2._Plata;
            return dolar1;
        }

        public static Dolar operator -(Dolar dolar1, double dolar2)
        {
            dolar1._Plata -= dolar2;
            return dolar1;
        }

        public static Dolar operator -(Dolar dolar, Euro euro)
        {
            dolar._Plata -= euro._Plata;
            return dolar;
        }
        //Comparar

        public static bool operator ==(Dolar dolar, double valor)
        {
            if (dolar._Plata == valor)
                return true;
            else return false;
        }

        public static bool operator ==(Dolar dolar, Euro euro)
        {
            if (dolar._Plata == euro._Plata)
                return true;
            else return false;
        }

        public static bool operator ==(Dolar dolar1, Dolar dolar2)
        {
            if (dolar1._Plata == dolar2._Plata)
                return true;
            else return false;
        }
                   //distinto
        public static bool operator !=(Dolar dolar, double valor)
        {
            if (dolar._Plata != valor)
                return true;
            else return false;
        }

        public static bool operator !=(Dolar dolar, Euro euro)
        {
            if (dolar._Plata != euro._Plata)
                return true;
            else return false;
        }

        public static bool operator !=(Dolar dolar1, Dolar dolar2)
        {
            if (dolar1._Plata != dolar2._Plata)
                return true;
            else return false;
        }
        //Incrementar

        public static Dolar operator ++(Dolar dolar)
        {
            dolar._Plata ++;
            return dolar;
        }
        public static Dolar operator --(Dolar dolar)
        {
            dolar._Plata--;
            return dolar;
        }

        public static implicit operator Dolar(Euro valor)
        {
            return new Dolar(valor._Plata * 1.3642);
        }*/
        public static Dolar operator ++(Dolar dolaraux)
        {
            dolaraux._Plata = dolaraux._Plata + 1;

            return dolaraux;
        }

        public static Dolar operator --(Dolar dolaraux)
        {
            dolaraux._Plata = dolaraux._Plata - 1;

            return dolaraux;
        }

        public static bool operator ==(Dolar dolaraux, int valor)
        {
            if (dolaraux._Plata == valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Dolar dolaraux, int valor)
        {
            if (dolaraux._Plata != valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Dolar dolaraux, Dolar valor)
        {
            if (dolaraux._Plata == valor._Plata)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Dolar dolaraux, Dolar valor)
        {
            if (dolaraux._Plata != valor._Plata)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Dolar dolaraux, Euro valor)
        {
            if (dolaraux._Plata == valor._Plata)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Dolar dolaraux, Euro valor)
        {
            if (dolaraux._Plata != valor._Plata)
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
