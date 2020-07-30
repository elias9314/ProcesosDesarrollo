using System;

namespace Informatica.Negocio
{
    public class Comparador
    {
        public int Obtenermenor(int primerElemento, int segundoElemento)
        {
           return primerElemento < segundoElemento ? primerElemento : segundoElemento;
        }
    }
}