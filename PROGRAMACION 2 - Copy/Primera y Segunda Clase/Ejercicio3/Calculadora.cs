using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Calculadora
    {

        public static int Sumar(int x ,int y)
        {
            return x + y;
        }
        public static int Dividir(int x, int y)
        {
            if (ValidarSiEsCero(y))
                return 0;
            else
                return x / y;
        }
        /// <summary>
        /// Retorna true si el numero es 0.
        /// </summary>
        /// <param name="x"></param> El numero a verificar.
        /// <returns></returns>
        private static bool ValidarSiEsCero(int x)
        {
            if (x == 0)
                return true;
            else 
                return false;
        }
        /// <summary>
        /// Retorno true si el numero es par.
        /// </summary> 
        /// <param name="x"></param> El numero a verificar.
        /// <returns></returns>
        private static bool ValidarSiEsPar(int x)
        {
            if (x % 2 == 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Me devuelve true si el numero inrgresado es mayor al limite.
        /// </summary>
        /// <param name="limite"></param>este es el limte que debe ser superado.
        /// <param name="numero"></param>Esta es el numero que debemos verificar si es mayor.
        /// <returns></returns>
        public static bool EsMayorQue(int limite, int numero)
        {
            if (numero > limite)
                return true;
            else
                return false;
        }

            
    }
            

}

namespace Otro
{
    class Calculadora
    {

        public void Sumar()
        {

        }

    }
}
