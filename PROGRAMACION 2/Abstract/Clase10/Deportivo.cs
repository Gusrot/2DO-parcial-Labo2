using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    public class Deportivo : Auto,iAFIP
    {
        
        public Deportivo(string patente):base(patente)
        {

        }

        public override float CalcularCosto()
        {
            return 150f;
        }


        public float RetornarImpuesto()
        {
            return 22f;
        }
    }
}
