
using Informatica.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informatica.NegocioTest
{
    [TestClass]
    public class ComparadorTest
    {
        [TestMethod]
       public void ObtenerMenor()
        {
            ///Arange--Organizar datos
            var primerElemento = 50;
            var segundoElemento = 25;
            var esperado = 25;

            /// Act--Ejecutar
            Comparador comparador = new Comparador();

            int actual = comparador.Obtenermenor(primerElemento, segundoElemento);

            /// Assert Comprobar
            Assert.AreEqual(esperado, actual);
        }
    }
}
