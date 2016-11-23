using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpecionBasica
{
    public class Carrera
    {
        public List<Auto> listaAutos;
        public string autodromo;

        public Carrera(string autodromo)
        {
            this.listaAutos = new List<Auto>();
            this.autodromo = autodromo;
        }

        public void CorrerCarrera()
        {
            if (this.listaAutos.Count <= 0)
            {
                throw new Miexepcion(DateTime.Now, DateTime.Now.ToString());
            }
            else
            {
                foreach (Auto item in this.listaAutos)
                {
                    item.Andar();
                }
            }
        }
    }
}
