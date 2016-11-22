using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpecionBasica
{
    public class Auto
    {
        public string marca;
        public int numero;
        public List<Rueda> misRueda;

        public Auto(string marca,int numero)
        {
            this.misRueda = new List<Rueda>();
            this.marca = marca;
            this.numero = numero;
        }

        public void Andar()
        {
            if (this.misRueda.Count < 4)
                throw new Miexepcion(DateTime.Now, DateTime.Now.ToString());
            else
            {
                try
                {
                    foreach (Rueda item in this.misRueda)
                    {
                        item.Rodar();
                    }
                }
                catch (PinchaduraExcepcion x)
                {
                    throw new AutoExcepcion(this, x.horaDeLaExcep, x.txtHoraDeLaExcep);
                }
                
            }
        }
    }
}
