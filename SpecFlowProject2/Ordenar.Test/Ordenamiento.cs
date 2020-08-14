using System;
using System.Threading.Tasks;

namespace Ordenar.Test
{
    internal class Ordenamiento
    {
        internal int[] OrdenarBurbuja(int numero1, int numero2, int numero3)
        {
            int[] resultado = new int[3];
            resultado[0] = numero1;
            resultado[1] = numero2;
            resultado[2] = numero3;
            for (int i = 0; i < resultado.Length; i++)
            {
                for (int j = 0; j < resultado.Length - i - 1; j++)
                {
                    if (resultado[j] > resultado[j + 1])
                    {
                        int aux;
                        aux = resultado[j];
                        resultado[j] = resultado[j + 1];
                        resultado[j + 1] = aux;
                    }
                }
            }
            return resultado;
        }

        internal int[] OrdenarBurbujaParalelo(int numero1, int numero2, int numero3)
        {
            int[] resultado = new int[3];
            resultado[0] = numero1;
            resultado[1] = numero2;
            resultado[2] = numero3;
            Parallel.For(0, resultado.Length, i =>
            //  for (int i = 0; i < resultado.Length; i++)
            {
                for (int j = 0; j < resultado.Length - i - 1; j++)
                {
                    if (resultado[j] > resultado[j + 1])
                    {
                        int aux;
                        aux = resultado[j];
                        resultado[j] = resultado[j + 1];
                        resultado[j + 1] = aux;
                    }
                }
            });
            return resultado;
        }
    }
}