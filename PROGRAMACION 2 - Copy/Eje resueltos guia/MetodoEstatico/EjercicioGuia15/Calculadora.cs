using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia15
{
    public class Calculadora
    {
        public static double Calcular(double numeroUno, double numeroDos, string operador)
        {
            double resultado = 0;

            switch (operador)
            {
                case "/":
                        if (Validar(numeroDos))                        
                            resultado = numeroUno / numeroDos;                       
                        else
                            Console.WriteLine("No se puede dividir por 0.");
                        break;
                case "*":
                        resultado = numeroUno * numeroDos;                    
                    break;
                case "-":
                        resultado = numeroUno - numeroDos;                    
                    break;
                case "+":                    
                        resultado = numeroUno + numeroDos;                    
                    break;
            }

            return resultado;
        }
        private static bool Validar(double numeroDos)
        {
            if (numeroDos == 0)
                return false;

            return true;
        }
        public static void Mostrar(double resultado)
        {
            Console.WriteLine(resultado);
            Console.ReadKey();

        }
    }
}
