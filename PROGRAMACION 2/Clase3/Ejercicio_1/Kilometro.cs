using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Kilometro
    {
        private int _cantidad;

        private Kilometro(int cantidad)
        {
            this._cantidad = cantidad; 
        }
        public static Kilometro operator+ (Kilometro kilo, int numero)
        {

            kilo._cantidad = kilo._cantidad + numero;

            return kilo;
        }
        public static Kilometro operator +(Kilometro kilo1, Kilometro kilo2)
        {
            kilo1._cantidad = kilo1._cantidad + kilo2._cantidad;

            return kilo1;

        }

        public static Kilometro operator -(Kilometro kilo, int valor)
        {
            kilo._cantidad = kilo._cantidad + valor;

            return kilo;
        }
        public static Kilometro operator -(Kilometro kilo1, Kilometro kilo2)
        {
            kilo1._cantidad = kilo1._cantidad - kilo2._cantidad;

            return kilo1;
        }
        public static bool operator ==(Kilometro kilo, int valor)
        {
            if (kilo._cantidad == valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Kilometro kilo1, Kilometro kilo2)
        {
            if (kilo1 == kilo2)
                return true;
            return false;
        }
        public static bool operator !=(Kilometro kilo, int valor)
        {
            if (kilo._cantidad != valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Kilometro kilo1, Kilometro kilo2)
        {
            if (kilo1 != kilo2)
                return true;
            return false;
        }
        public static implicit operator Kilometro(int numero)
        {
            return new Kilometro(numero);
        }
        public  void MostrarKilometro()
        {
            Console.WriteLine(this._cantidad);

        }
        public static bool operator <(Kilometro kilo, int valor)
        {
            if (kilo._cantidad < valor)
                return true;
            return false;


        }
        public static bool operator <(Kilometro kilo1, Kilometro kilo2)
        {
            if (kilo1._cantidad < kilo2._cantidad)
                return true;
            return false;


        }
        public static bool operator >(Kilometro kilo, int valor)
        {
            if (kilo._cantidad < valor)
                return true;
            return false;


        }
        public static bool operator >(Kilometro kilo1, Kilometro kilo2)
        {
            if (kilo1._cantidad > kilo2._cantidad)
                return true;
            return false;


        }

    }
}
