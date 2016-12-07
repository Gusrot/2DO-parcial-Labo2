using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modeloFinal
{
    public class Burbujeo
    {
        private void burbujear()
        {
            throw new ExcepcionPropia("Instancia");
        }

        public static void burbujearStatic()
        {
            Burbujeo aux = new Burbujeo();
            try
            {
                aux.burbujear();
            }
            catch (ExcepcionPropia e)
            {

                throw new ExcepcionPropia(e.Message + " y Estatico");
            }

        }
    }
}
