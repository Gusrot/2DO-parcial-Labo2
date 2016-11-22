using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Tiempo
    {
        private int _cantidad;

        private Tiempo(int cantidad)
        {
            this._cantidad = cantidad; 
        }
        public static Tiempo operator + (Tiempo tiempoaux , int valor)
        {        
        
            tiempoaux._cantidad = tiempoaux._cantidad+valor;
            
                return tiempoaux;

        }
        public static Tiempo operator +(Tiempo time1, Tiempo time2)
        {
            time1._cantidad = time1._cantidad + time2._cantidad;

            return time1;
 
        }

        public static Tiempo operator -(Tiempo time, int valor)
        {
            time._cantidad = time._cantidad - valor;

            return time;
        }
        public static Tiempo operator -(Tiempo time1, Tiempo time2)
        {
            time1._cantidad = time1._cantidad - time2._cantidad;

            return time1;
        }
        public static bool operator ==(Tiempo time, int valor)
        {
            if (time._cantidad == valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Tiempo time1, Tiempo time2)
        {
            if(time1 == time2)
                return true;
            return false;
        }
        public static bool operator !=(Tiempo time, int valor)
        {
            if (time._cantidad != valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Tiempo time1, Tiempo time2)
        {
            if (time1 != time2)
                return true;
            return false;
        }

        public static implicit operator Tiempo(int numero)
        {

            return new Tiempo(numero);
        }
        public void MostrarTiempo()
        {
            Console.WriteLine(this._cantidad);
        }
        public static bool operator <(Tiempo time, int valor)
        {
            if (time._cantidad < valor)
                return true;
            return false;

             
        }
        public static bool operator <(Tiempo time1, Tiempo time2)
        {
            if (time1._cantidad < time2._cantidad)
                return true;
            return false;


        }
        public static bool operator >(Tiempo time, int valor)
        {
            if (time._cantidad > valor)
                return true;
            return false;


        }
        public static bool operator >(Tiempo time1, Tiempo time2)
        {
            if (time1._cantidad > time2._cantidad)
                return true;
            return false;


        }


                                                 
    }
}
