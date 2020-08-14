using Calculos.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        Calculadora calculadora;
        int resultado;
        int number1;
        int number2;
        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            
            calculadora = new Calculadora();
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number1)
        {
            this.number1 = number1;
        }
        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number2)
        {
            this.number2 = number2;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            resultado = calculadora.suma(number1,number2);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(resultado, result);
        }
    }
}
