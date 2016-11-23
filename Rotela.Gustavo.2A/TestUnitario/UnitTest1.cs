using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Formulario;
using Clases;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NoGuardar()
        {
            Tienda tienda = new Tienda("Bv. Italianos 948", 2, 103525);

            try
            {
                //trato de guardarlo en cualquier lado
                tienda.guardar("C:\\data\\dc\\archivo.xml", tienda);

                Assert.Fail("Error al capturar al excepcion.");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NoGuardaException));
            }
        }

        [TestMethod]
        public void GuardarCorrectamente()
        {
            Tienda tienda = new Tienda("Bv. Italianos 948", 2, 103525);

            try
            {
                Tienda aux;

                tienda.guardar("Local.xml", tienda);

                tienda.leer("Local.xml", out aux);

                Assert.AreEqual(tienda.Direccion,aux.Direccion);
                Assert.AreEqual(tienda.AnchoDeFrente, aux.AnchoDeFrente);

            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}
