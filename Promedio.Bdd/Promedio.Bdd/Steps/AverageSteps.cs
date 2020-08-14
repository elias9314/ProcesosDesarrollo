using Estudiante;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace Promedio.Bdd.Steps
{
    [Binding]
    public class AverageSteps
    {
        Estudiante1 estudiante = new Estudiante1();
        double resultado;
        double note1;
        double note2;

        [Given(@"first notes is (.*)")]
        public void GivenFirstNotesIs(double number1)
        {
            this.note1 = number1;
        }
        
        [Given(@"second notes is (.*)")]
        public void GivenSecondNotesIs(double number2)
        {
            this.note2 = number2;
        }
        
        [When(@"the two note are averaged")]
        public void WhenTheTwoNoteAreAveraged()
        {
            resultado = estudiante.promedio(note1, note2);
        }
        
        [Then(@"average total (.*)")]
        public void ThenAverageTotal(double result)
        {
            Assert.AreEqual(resultado, result);
        }
    }
}
