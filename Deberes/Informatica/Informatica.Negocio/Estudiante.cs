using System;
using System.Diagnostics.CodeAnalysis;

namespace Informatica.Negocio
{
    public class Estudiante : IComparable<Estudiante>
    {
        public Estudiante()
        {
        }

        public string Nombre { get;  set; }
        public string Apellido { get;  set; }
        public DateTime Nacimiento { get;  set; }

        public int CompareTo([AllowNull] Estudiante other)
        {
            return this.Nombre.CompareTo(other.Nombre);
        }
    }
}