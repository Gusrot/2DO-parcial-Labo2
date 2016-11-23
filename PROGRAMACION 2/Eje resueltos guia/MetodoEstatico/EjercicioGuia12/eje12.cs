using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia12
{
    public static class eje12
    {
        public static bool ValidaS_N()
        {
            char rta;

            Console.Write("Continua?(S/N)");
            rta = char.Parse(Console.ReadLine());//Se parsea a char
            rta = char.ToUpper(rta);//Lo pasa a mayuscula
            while (!char.IsLetter(rta))//verifica si es una letra
            {
                Console.WriteLine("Reingrese");
                rta = char.Parse(Console.ReadLine());
            }
            while (rta != 'S' && rta != 'N')
            {
                Console.WriteLine("Reingrese");
                rta = char.Parse(Console.ReadLine());
            }
            if (rta == 'S')
                return true;
            else
                return false;
        }
    }
}
