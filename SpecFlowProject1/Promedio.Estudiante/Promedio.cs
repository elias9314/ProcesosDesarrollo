using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo.Estudiante
{
   public class Promedio
    {
        public int primeraNota { get; set; }
        public int segundaNota { get; set; }

        public int promedio(int nota1, int nota2)
        {
            return (primeraNota + segundaNota) / 2;
        }
    }
}
