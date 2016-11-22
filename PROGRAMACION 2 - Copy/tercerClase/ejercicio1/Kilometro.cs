using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Kilometro
    {
        private int _cantidad;

        private Kilometro()
        { 
            
        }

        public Kilometro(int cantidad)
        {
            this._cantidad = cantidad;
        }

        public static Kilometro operator +(Kilometro kmaux, int valor)
        {
            kmaux._cantidad = kmaux._cantidad + valor;

            return kmaux;
        }

        public static Kilometro operator +(Kilometro kmaux, Kilometro valor)
        {
            kmaux._cantidad = kmaux._cantidad + valor._cantidad;

            return kmaux;
        }

        public static Kilometro operator -(Kilometro kmaux, int valor)
        {
            kmaux._cantidad = kmaux._cantidad - valor;

            return kmaux;
        }

        public static Kilometro operator -(Kilometro kmaux, Kilometro valor)
        {
            kmaux._cantidad = kmaux._cantidad - valor._cantidad;

            return kmaux;
        }

        public static bool operator ==(Kilometro kmaux, int valor)
        {
            if (kmaux._cantidad == valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Kilometro kmaux, Kilometro valor)
        {
            if (kmaux._cantidad == valor._cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Kilometro kmaux, int valor)
        {
            if (kmaux._cantidad != valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Kilometro kmaux, Kilometro valor)
        {
            if (kmaux._cantidad != valor._cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Kilometro kmaux, int valor)
        {
            if (kmaux._cantidad < valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Kilometro kmaux, Kilometro valor)
        {
            if (kmaux._cantidad < valor._cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(Kilometro kmaux, int valor)
        {
            if (kmaux._cantidad > valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(Kilometro kmaux, Kilometro valor)
        {
            if (kmaux._cantidad > valor._cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*public static explicit operator Kilometro(int numero)
        {
            return new Kilometro(numero); // = (int)"33"; <- uso
        }*/

        public static implicit operator Kilometro(int numero)
        {
            return new Kilometro(numero); // = "33"; <- uso
        }

        public static implicit operator int(Kilometro kilometro)
        {
            return kilometro._cantidad; // = "33"; <- uso
        }
    }
}
