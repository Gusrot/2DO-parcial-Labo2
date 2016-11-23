using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpecionBasica
{
    public class PinchaduraExcepcion : Miexepcion
    {

        public string marca;

        public PinchaduraExcepcion(string rueda, DateTime hora, string txthora)
            : base(hora, txthora)
        {
            this.marca = rueda;
        }

        public PinchaduraExcepcion(string rueda, DateTime hora, string txthora,Exception exAnterior)
            : this(rueda,hora, txthora)
        {
            
        }

    }
}
