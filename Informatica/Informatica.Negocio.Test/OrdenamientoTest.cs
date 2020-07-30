using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace Informatica.Negocio.Test
{
    [TestClass]
     public class OrdenamientoTest
    {
        [TestMethod]
        public void TresElementos()
        {
            // Arange-- Organizar datos
            var primero = 45;
            var segundo = 20;
            var tercero = 15;

            var esperado = 15; // primer valor
            var esperado2 = 20; //segundo valor

            //Act--Ejecutar
            Ordenamiento ordenamiento = new Ordenamiento();
            List<int> esperados = ordenamiento.Ordenar(primero, segundo, tercero);

            //Assert

            Assert.AreEqual(esperado, esperados[0]);
            Assert.AreEqual(esperado2, esperados[1]);

        }
    }
}