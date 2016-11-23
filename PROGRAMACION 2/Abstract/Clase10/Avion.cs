using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    public class Avion : Vehiculo,iAFIP
    {
        public Avion(string patente):base(patente)
        {
 
        }

        public override float CalcularCosto()
        {
            return 1500f;
        }

        public float RetornarImpuesto()
        {
            return 20f;
        }
    }
}
