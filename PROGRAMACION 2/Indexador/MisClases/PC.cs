using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MisClases
{
    public class PC
    {
        public string marca;
        public  string SO;
        public static int contadorPc;
        public int numero;

        static PC()
        {
            contadorPc = 1;
        }       

        public PC(string marca)
        {
            this.marca = marca;
            this.SO = "Windows";
            this.numero = contadorPc;
            contadorPc++;
        }

        public static implicit operator PC(string marca)
        {
            return new PC(marca);
        }

        
    }
}
