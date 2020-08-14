using Calculos.Negocio;
using System;

namespace Financiera.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            calculadora.primerNumero = 50;
            calculadora.segundoNumero = 70;

            int resultado = calculadora.suma();
            int resultado1 = calculadora.suma(50,70);
            Console.WriteLine($"La suma entre {calculadora.primerNumero}  y {calculadora.segundoNumero} es : {resultado}");
            Console.WriteLine($"La suma entre 50  y 70 es : {resultado1}");
        }
    }
}
