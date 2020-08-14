using System;

namespace Calculadora2.Negocio
{
    public class Calculadora
    {
        public int primerNumero { get; set;}
        public int segundoNumero { get; set; }

        public int suma()
        {
            return primerNumero + segundoNumero;
        }

        public int suma(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
