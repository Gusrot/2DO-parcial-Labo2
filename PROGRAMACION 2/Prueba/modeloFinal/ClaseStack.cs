using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modeloFinal
{
    public class ClaseStack
    {
        public static Stack<Double> OrdenInverso(Stack<Double> stackAOrdenar)
        {
            Stack<Double> stackNuevo = new Stack<double>();

            while (stackAOrdenar.Count >= 1)
            {
                stackNuevo.Push(stackAOrdenar.Pop());
            }

            return stackNuevo;
        }
    }
}
