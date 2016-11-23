using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
     public class Kilometro
    {
        private int _Cantidad;

        public Kilometro(int cantidad)
        {
            this._Cantidad = cantidad;
        }

        public static Kilometro operator +(Kilometro km, int num)
        {
            km._Cantidad = km._Cantidad + num;

            return km;
        }

        public static Kilometro operator +(Kilometro km1, Kilometro km2)
        {
            km1._Cantidad += km2._Cantidad;
            return km1;
        }


        public static Kilometro operator -(Kilometro km, int num)
        {
            km._Cantidad = km._Cantidad - num;

            return km;
        }

        public static Kilometro operator -(Kilometro km1, Kilometro km2)
        {
            km1._Cantidad -= km2._Cantidad;
            return km1;
        }

        public static bool operator ==(Kilometro km, int num)
        {
            if (km._Cantidad == num)
                return true;
            else return false;
        }

        public static bool operator ==(Kilometro km1, Kilometro km2)
        {
            if (km1._Cantidad == km2._Cantidad)
                return true;
            else
                return false;
        }

        //distinto
        public static bool operator !=(Kilometro km, int num)
        {
            if (km._Cantidad != num)
                return true;
            else return false;
        }

        public static bool operator !=(Kilometro km1, Kilometro km2)
        {
            if (km1 != km2)
                return true;
            else
                return false;
        }

        // si es explicito solo funciona de esta manera - =(int)"33"; -
        /*public static explicit operator Kilometro(int numero)
        {
            return new Kilometro(numero);
        }*/

        public static implicit operator Kilometro(int numero)
        {
            return new Kilometro(numero);
        }

        //>

        public static bool operator >(Kilometro k1, Kilometro k2)
        {
            if (k1._Cantidad > k2._Cantidad)
                return true;
            else return false;

        }

        public static bool operator <(Kilometro k1, Kilometro k2)
        {
            if (k1._Cantidad < k2._Cantidad)
                return true;
            else return false;

        }
        //<
        public static bool operator >(Kilometro k1, int num)
        {
            if (k1._Cantidad > num)
                return true;
            else return false;
        }
        public static bool operator <(Kilometro k1, int num)
        {
            if (k1._Cantidad < num)
                return true;
            else return false;

        }
         public int MostrarKm()
         {
             return this._Cantidad;
         }
    }
}
