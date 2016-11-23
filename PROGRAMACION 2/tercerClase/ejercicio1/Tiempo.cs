using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Tiempo
    {
        private int _cantidad;

        private Tiempo()
        {

        }

        public Tiempo(int cantidad)
        {
            this._cantidad = cantidad;
        }

        public static Tiempo operator +(Tiempo tiempoaux, int valor)
        {
            tiempoaux._cantidad = tiempoaux._cantidad + valor;

            return tiempoaux;
        }

        public static Tiempo operator +(Tiempo tiempoaux, Tiempo valor)
        {
            tiempoaux._cantidad = tiempoaux._cantidad + valor._cantidad;

            return tiempoaux;
        }

        public static Tiempo operator -(Tiempo tiempoaux, int valor)
        {
            tiempoaux._cantidad = tiempoaux._cantidad - valor;

            return tiempoaux;
        }

        public static Tiempo operator -(Tiempo tiempoaux, Tiempo valor)
        {
            tiempoaux._cantidad = tiempoaux._cantidad - valor._cantidad;

            return tiempoaux;
        }

        public static bool operator ==(Tiempo tiempoaux, int valor)
        {
            if (tiempoaux._cantidad == valor)
            {
                return true;
            }    
            else
            {
                return false;
            }
        }

        public static bool operator ==(Tiempo tiempoaux, Tiempo valor)
        {
            if (tiempoaux._cantidad == valor._cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Tiempo tiempoaux, int valor)
        {
            if (tiempoaux._cantidad != valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Tiempo tiempoaux, Tiempo valor)
        {
            if (tiempoaux._cantidad != valor._cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Tiempo tiempoaux, int valor)
        {
            if (tiempoaux._cantidad < valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Tiempo tiempoaux, Tiempo valor)
        {
            if (tiempoaux._cantidad < valor._cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(Tiempo tiempoaux, int valor)
        {
            if (tiempoaux._cantidad > valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(Tiempo tiempoaux, Tiempo valor)
        {
            if (tiempoaux._cantidad > valor._cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*public static explicit operator Tiempo(int numero)
        {
            return new Tiempo(numero); // = (int)"33"; <- uso
        }*/

        public static implicit operator Tiempo(int numero)
        {
            return new Tiempo(numero); // = "33"; <- uso
        }
         
        public void mostrar()
        {
            Console.WriteLine("Tiempo: "+this._cantidad);
        }

        public static implicit operator int(Tiempo tiempo)
        {
            return tiempo._cantidad; // = "33"; <- uso
        }
    }
}
