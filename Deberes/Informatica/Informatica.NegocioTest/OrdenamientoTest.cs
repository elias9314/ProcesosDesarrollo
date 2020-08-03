

using Informatica.Negocio;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Informatica.NegocioTest
{
    [TestClass]
     public class OrdenamientoTest
    {
        [TestMethod]
         public void OrdenamientoMenor()
        {
            //// Arange--Organizar datos

            var primero = 20;
            var segundo = 15;
            var tercero = 23;
            var esperado = 15; //primer valor
            var esperado2 = 20; // segundo valor

            // Act-- Ejecutar

            Ordenamiento ordenamiento = new Ordenamiento();

            List<int> esperados = ordenamiento.Ordenar(primero, segundo, tercero);
            /// Assert--Comprobacion
            Assert.AreEqual(esperado, esperados[0]);
            Assert.AreEqual(esperado2, esperados[1]);
        }

        [TestMethod]

        public void OrdenarPersonas()
        {
            ///Arange--Organizar datos
            var persona1 = new Estudiante();
            persona1.Nombre = "Carlos";
            persona1.Apellido = "Jaramillo";
            persona1.Nacimiento = new DateTime(2000, 5, 12);

            var persona2 = new Estudiante();
            persona2.Nombre = "Andres";
            persona2.Apellido = "Ortiz";
            persona2.Nacimiento = new DateTime(2010, 8, 26);

            var persona3 = new Estudiante();
            persona3.Nombre = "Mateo";
            persona3.Apellido = "Chauca";
            persona3.Nacimiento = new DateTime(2006, 8, 26);

            var esperado1 = "Andres";
            var esperado2 = "Carlos";
            var esperado3 = "Mateo";

            //// Act-Ejecutar
            Ordenamiento ordenamiento = new Ordenamiento();
            List<Estudiante> actual = ordenamiento.Ordenar(persona1, persona2, persona3);

            ///Assert
            Assert.AreEqual(esperado1, actual[0].Nombre);
            Assert.AreEqual(esperado2, actual[1].Nombre);
            Assert.AreEqual(esperado3, actual[2].Nombre);

        }
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
            int [] actual = ordenamiento.OrdenarBurbuja(numero1, numero2, numero3);

            Assert.AreEqual(esperado1, actual[0]);
            Assert.AreEqual(esperado2, actual[1]);
            Assert.AreEqual(esperado3, actual[2]);


        }
        [TestMethod]
         public void OrdenarShell()
        {
            var numero1 = 5;
            var numero2 = 4;
            var numero3 = 12;
            var numero4 = 3;
            var numero5 = 6;
            var numero6 = 2;


            var esperado1 = 2;
            var esperado2 = 3;
            var esperado3 = 4;
            var esperado4 = 5;
            var esperado5 = 6;
            var esperado6 = 12;
   
            Ordenamiento ordenamiento = new Ordenamiento();
            int[] actual = ordenamiento.OrdenarShell(numero1, numero2, numero3, numero4, numero5, numero6);

            Assert.AreEqual(esperado1, actual[0]);
            Assert.AreEqual(esperado2, actual[1]);
            Assert.AreEqual(esperado3, actual[2]);
            Assert.AreEqual(esperado4, actual[3]);
            Assert.AreEqual(esperado5, actual[4]);
            Assert.AreEqual(esperado6, actual[5]);
        }

        [TestMethod]
        public void OrdenarQuick()
        {
            var numero1 = 3;
            var numero2 = 6;
            var numero3 = 4;
            var numero4 = 1;
            var numero5 = 11;

            var esperado1 = 1;
            var esperado2 = 3;
            var esperado3 = 4;
            var esperado4 = 6;
            var esperado5 = 11;

            Ordenamiento ordenamiento = new Ordenamiento();
            int[] actual = ordenamiento.Ordenarquick(numero1, numero2, numero3, numero4, numero5);

            Assert.AreEqual(esperado3, actual[2]);
            Assert.AreEqual(esperado4, actual[3]);
            Assert.AreEqual(esperado5, actual[4]);


        }

        [TestMethod]
        public void OrdenarRapido()
        {
            int[] orden = { 3, 4, 2, 1 };
            int inicio = 0;
            int fin = 3;

            var esperado1 = 1;
            var esperado2 = 2;
            var esperado3 = 3;
            var esperado4 = 4;

            Ordenamiento ordenamiento = new Ordenamiento();
            int[] actual = ordenamiento.Ordenrapido(orden, inicio, fin);

            Assert.AreEqual(esperado1, actual[0]);
            Assert.AreEqual(esperado2, actual[1]);
            Assert.AreEqual(esperado3, actual[2]);
            Assert.AreEqual(esperado4, actual[3]);




        }

    }


}
