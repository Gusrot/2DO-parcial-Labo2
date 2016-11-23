using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia13
{
    public static class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            string binario = "";

            if (numero > 0)
            {
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        binario = "0" + binario;
                    }
                    else
                    {
                        binario = "1" + binario;
                    }
                    numero = (int)numero / 2;
                }
            }
            else
            {
                binario = "0";
            }
            return binario;
        }
        public static double BinarioDecimal(string binario)
        {
            int exponente = binario.Length - 1;
            double num_decimal = 0;

            for (int i = 0; i < binario.Length; i++)
            {
                if (double.Parse(binario.Substring(i, 1)) == 1)
                {
                    num_decimal = num_decimal + double.Parse(System.Math.Pow(2, double.Parse(exponente.ToString())).ToString());
                }
                exponente--;
            }
            return num_decimal;
        }
    }
    
}
