using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RemesasDAO.DAO;
using RemesasDAO.GestionUsuarios;
using RemesasEDM.ModeloApp;
using RemesasEDM.ModeloSeguridad;
using Remesas;

namespace RemesasTest
{
    [TestClass]
    public class UnitTest1
    {
        ClienteEmisorDAO emisorDAO = new ClienteEmisorDAO();
        Pruebas pruebas = new Pruebas();
        [TestMethod]
        public void TestAgregar()
        {
            bool result = emisorDAO.Agregar(pruebas.EnviarEmisor());
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestEliminar()
        {
            bool result = emisorDAO.Eliminar(pruebas.EnviarEmisor());
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestModificar()
        {
            bool ressult = emisorDAO.Modificar(pruebas.EnviarEmisor());
            Assert.AreEqual(true, ressult);
        }

        [TestMethod]
        public void Buscar()
        {
            ClienteEmisor emisor = emisorDAO.Buscar(pruebas.BuscarEmisor());
            Assert.IsNotNull(emisor);
        }
    }
}
