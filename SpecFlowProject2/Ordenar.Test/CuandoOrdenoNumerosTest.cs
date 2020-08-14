using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
namespace Ordenar.Test
{
    [TestClass]
    public class CuandoOrdenoNumerosTest
    {
        [TestMethod]
        public void OrdenarBurbuja()
        {
            var numero1 = 10;
            var numero2 = 6;
            var numero3 = 4;

            var esperado1 = 4;
            var esperado2 = 6;
            var esperado3 = 10;

            Ordenamiento ordenamiento = new Ordenamiento();
            int[] actual = ordenamiento.OrdenarBurbuja(numero1, numero2, numero3);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(esperado1, actual[0]);
            Assert.AreEqual(esperado2, actual[1]);
            Assert.AreEqual(esperado3, actual[2]);


        }

        public void EnParaleloEsMasRapidoQueEnSecuencia()
        {
            var numero1 = 10;
            var numero2 = 6;
            var numero3 = 4;

            Ordenamiento ordenamiento = new Ordenamiento();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            ordenamiento.OrdenarBurbuja(numero1, numero2, numero3);

            stopwatch.Stop();
            var secuencial = stopwatch.ElapsedTicks;

            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            ordenamiento.OrdenarBurbujaParalelo(numero1, numero2, numero3);

            stopwatch1.Stop();
            var paralelo = stopwatch1.ElapsedTicks;

            Assert.IsTrue(secuencial > paralelo);
        }
    }
}
