using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informatica.Negocio.Test
{
    [TestClass]
public  class ComparadorTest
    {
        [TestMethod]
   public  void ObtenerMenor()
        {
            //Organizar datos
            var primerElemento = 33;
            var segundoElemento = 15;
            var esperado = 15;
            // ejecute
            Comparador comparador = new Comparador();
            int actual = comparador.Obtenermenor(primerElemento, segundoElemento);

            // Comprobar
            Assert.AreEqual(esperado, actual);
        }
    }
}
