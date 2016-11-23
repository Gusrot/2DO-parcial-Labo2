using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpecionBasica
{
    public class Miexepcion : Exception
    {
        public DateTime horaDeLaExcep;
        public string txtHoraDeLaExcep;
        public Exception exAnterior;

        public Miexepcion(DateTime hora, string txthora)
            : base(txthora)
        {
            this.horaDeLaExcep = hora;
            this.txtHoraDeLaExcep = txthora;
        }

        public Miexepcion(DateTime hora, string txthora,Exception exAnterior)
            : this(hora,txthora)
        {
            this.exAnterior = exAnterior;
        }

    }
}
