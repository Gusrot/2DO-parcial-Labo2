using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpecionBasica
{
    public class Rueda
    {
        public string marca;
        static Random random;

        static Rueda()
        {
            random = new Random();
        }

        public Rueda(string marca)
        {
            this.marca = marca;
        }

        public void Rodar()
        {
            int rand=random.Next(1, 10);
            if (rand == 5)
                this.Pinchar();
            else
                Console.WriteLine("Random: "+rand);
        }

        public void Pinchar()
        {
            throw new PinchaduraExcepcion(this.marca, DateTime.Now, DateTime.Now.ToString());
        }
    }
}
