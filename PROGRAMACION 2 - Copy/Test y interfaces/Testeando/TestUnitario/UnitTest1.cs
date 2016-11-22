using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testeando;
namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Debe Instanciar el obj estacionamiento
        /// </summary>
        [TestMethod]
        public void InstanciaEstacionamiento()
        {
            Estacionamiento est1 = new Estacionamiento();
            Assert.IsNotNull(est1);
        }
        [TestMethod]
        public void ListadoIstanciado()
        {
            Estacionamiento est1 = new Estacionamiento();
            Assert.IsNotNull(est1.listaDeVehiculos);
        }
    }
}
