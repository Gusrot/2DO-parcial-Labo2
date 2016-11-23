using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Laboratorio
    {
        public string nombre;
        public List<PC> misPc;

        public Laboratorio(string nombre)
        {
            this.nombre = nombre;
            this.misPc = new List<PC>();
        }

        public PC this[int indice]
        {
            get
            {
                if (indice > 0 && indice <= this.misPc.Count)
                    return this.misPc[indice];
                else return null;
            }
            set
            {
                if (indice == this.misPc.Count)
                    this.misPc.Add(value);
                else
                    if (indice >= 0 && indice < this.misPc.Count)
                        this.misPc[indice] = value;

            }
        }
    }
}
