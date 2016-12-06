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
            throw new Exception("Instancia");
        }
        public static void burbujearStatic()
        {
           Burbujeo aux = new Burbujeo();
           try
           {
               aux.burbujear();
           }
           catch (Exception e)
           {

               throw new Exception(e.Message + " y Estatico");
           }
            
        }
    }
}
