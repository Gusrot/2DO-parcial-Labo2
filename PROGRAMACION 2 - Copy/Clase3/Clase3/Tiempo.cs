using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    public class Tiempo
    {
        private int _Cantidad;

        private Tiempo(int cantidad)
        {
            this._Cantidad = cantidad;
        }

        //public static Tiempo Sumar(Tiempo tiempoaux, int valor) NO
        /*public static Tiempo operator +(Tiempo tiempoaux,int valor)
        {

            tiempoaux._Cantidad = tiempoaux._Cantidad + valor;   
            
            return tiempoaux;
        }*/

        //suma
        public static Tiempo operator +(Tiempo tiempo, int num)
        {
            tiempo._Cantidad = tiempo._Cantidad + num;

            return tiempo;
        }


        public static Tiempo operator +(Tiempo tiempo1, Tiempo tiempo2)
        {
            tiempo1._Cantidad += tiempo2._Cantidad;
            return tiempo1;
        }

        //resta
        public static Tiempo operator -(Tiempo tiempo, int num)
        {
            tiempo._Cantidad = tiempo._Cantidad - num;

            return tiempo;
        }

        public static Tiempo operator -(Tiempo tiempo1, Tiempo tiempo2)
        {
            tiempo1._Cantidad -= tiempo2._Cantidad;
            return tiempo1;
        }
        //igual igual
        public static bool operator ==(Tiempo tiempo, int num)
        {
            if (tiempo._Cantidad == num)
                return true;
            else return false;
        }

        public static bool operator ==(Tiempo tiempo1, Tiempo tiempo2)
        {
            if (tiempo1._Cantidad == tiempo2._Cantidad)
                return true;
            else
                return false;
        }

        //distinto
        public static bool operator !=(Tiempo tiempo, int num)
        {
            if (tiempo._Cantidad != num)
                return true;
            else return false;
        }

        public static bool operator !=(Tiempo tiempo1, Tiempo tiempo2)
        {
            if (tiempo1 != tiempo2)
                return true;
            else
                return false;
        }

        // si es explicito solo funciona de esta manera - =(int)"33"; -
        /*public static explicit operator Tiempo(int numero)
        {
            return new Tiempo(numero);
        }*/

        public static implicit operator Tiempo(int numero)
        {
            return new Tiempo(numero);
        }

        /*public void MostrarTiempo()
        {
            Console.WriteLine("Tiempo: " + this._Cantidad);
        }*/

        //>

        public static bool operator >(Tiempo t1, Tiempo t2)
        {
            if (t1._Cantidad>t2._Cantidad)
                return true;
            else  return false;
            
        }

        public static bool operator <(Tiempo t1, Tiempo t2)
        {
            if (t1._Cantidad < t2._Cantidad)
                return true;
            else return false;

        }
        //<
        public static bool operator >(Tiempo t1, int num)
        {
            if (t1._Cantidad > num)
                return true;
            else return false;
        }
        public static bool operator <(Tiempo t1, int num)
        {
            if (t1._Cantidad < num)
                return true;
            else return false;

        }
        public int MostrarTiempo()
        {
            return this._Cantidad;
        }
        

        
    }
}
