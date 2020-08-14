using System;
using System.Dynamic;

namespace CalcularPromedio.Estudiante
{
    public class Estudiante
    {
         public int primeraNota { get; set; }
        public int segundaNota { get; set; }

        public int promedio()
        {
            return (primeraNota + segundaNota) / 2;
        }

        public int promedio(int note1, int note2)
        {
            return (note1 + note2) / 2;
        }
    }

}
