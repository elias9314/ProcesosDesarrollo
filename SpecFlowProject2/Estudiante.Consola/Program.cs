using CalcularPromedio.Estudiante;
using System;

namespace Promedio.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante();

            estudiante.primeraNota = 60;
            estudiante.segundaNota = 80;

            int resultado = estudiante.promedio();

            Console.WriteLine($"El promedio de {estudiante.primeraNota} y {estudiante.segundaNota} es : {resultado}");
            Console.WriteLine("Hello World!");
        }
    }
}
