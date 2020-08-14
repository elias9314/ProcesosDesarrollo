using System;

namespace Estudiante
{
    
        public class Estudiante1
        {
            public double primeraNota { get; set; }
            public double segundaNota { get; set; }

            public double promedio()
            {
                return (primeraNota + segundaNota) / 2;
            }

            public double promedio(double note1, double note2)
            {
                return (note1 + note2) / 2;
            }
        }
  
}
