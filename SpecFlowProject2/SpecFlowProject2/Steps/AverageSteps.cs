using CalcularPromedio.Estudiante;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.Steps
{
    [Binding]
    public class AverageSteps
    {
        Estudiante estudiante = new Estudiante();
        int resultado;
        int note1;
        int note2;

        [Given(@"the first note is (.*)")]
        public void GivenTheFirstNoteIs(int note1)
        {
            this.note1 = note1;
        }
        
        [Given(@"the  second note is (.*)")]
        public void GivenTheSecondNoteIs(int note2)
        {
            this.note2 = note2;
        }
        
        [When(@"the two notes are averaged")]
        public void WhenTheTwoNotesAreAveraged()
        {
            resultado = estudiante.promedio(note1, note2);
        }
        
        [Then(@"average should be (.*)")]
        public void ThenAverageShouldBe(int result)
        {
            Assert.AreEqual(resultado, result);
        }
    }
}
