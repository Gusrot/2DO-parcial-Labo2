using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpecionBasica
{
    public class AutoExcepcion : Miexepcion
    {
        public Auto a;

        public AutoExcepcion(Auto a,DateTime hora,string txthora):base(hora,txthora)
        {
            this.a = a;
        }

        public AutoExcepcion(Auto a, DateTime hora, string txthora,Exception exAnterior)
            : this(a,hora, txthora)
        {
            
        }


    }
}
