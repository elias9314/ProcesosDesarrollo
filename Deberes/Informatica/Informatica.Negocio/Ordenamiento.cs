using System;
using System.Collections.Generic;
using System.Globalization;

namespace Informatica.Negocio
{
    public class Ordenamiento
    {
        public List<int> Ordenar(int primero, int segundo, int tercero)
        {

            var resultado = new List<int>();

            if (primero <= segundo)
            {
                if (primero <= tercero)

                    resultado.Add(primero);
                if (segundo <= tercero)

                    resultado.Add(segundo);
                resultado.Add(tercero);

                resultado.Add(tercero);
                resultado.Add(segundo);

                resultado.Add(tercero);
                if (segundo <= primero)

                    resultado.Add(segundo);
                resultado.Add(primero);

                resultado.Add(primero);
                resultado.Add(segundo);

            }
            else
            {
                if (segundo <= tercero)
                {
                    resultado.Add(segundo);
                    if (primero <= tercero)

                        resultado.Add(primero);
                    resultado.Add(tercero);

                    resultado.Add(tercero);
                    resultado.Add(primero);

                }
                else
                {
                    resultado.Add(tercero);
                    if (primero <= segundo)

                        resultado.Add(primero);
                    resultado.Add(segundo);

                    resultado.Add(segundo);
                    resultado.Add(primero);
                }
            }
            return resultado;

        }

        public List<Estudiante> Ordenar(Estudiante persona1, Estudiante persona2, Estudiante persona3)
        {
            var resultado = new List<Estudiante>();
            resultado.Add(persona1);
            resultado.Add(persona2);
            resultado.Add(persona3);
            resultado.Sort();
            return resultado;
        }

        public int[] OrdenarBurbuja(int numero1, int numero2, int numero3)
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

        public int[] OrdenarShell(int numero1, int numero2, int numero3, int numero4, int numero5, int numero6)
        {
            int[] resultado = new int[6];
            resultado[0] = numero1;
            resultado[1] = numero2;
            resultado[2] = numero3;
            resultado[3] = numero4;
            resultado[4] = numero5;
            resultado[5] = numero6;

            for (int intervalo = resultado.Length / 2; intervalo > 0; intervalo /= 2)
            {
                for (int i = intervalo; i < resultado.Length; i += 1)
                {
                    int j, aux = resultado[i];
                    for (j = i; j >= intervalo && resultado[j - intervalo] > aux; j -= intervalo)
                    {
                        resultado[j] = resultado[j - intervalo];
                    }
                    resultado[j] = aux;
                }
            }
            return resultado;
        }

        public int[] Ordenarquick(int numero1, int numero2, int numero3, int numero4, int numero5)
        {
            int[] resultado = new int[5];
            resultado[0] = numero1;
            resultado[1] = numero2;
            resultado[2] = numero3;
            resultado[3] = numero4;
            resultado[4] = numero5;
            int ultimo = 4;
            int primero = 0;
            int pivote = resultado[primero + ultimo / 2];
            int aux;
            do {
                while (resultado[primero] < pivote) primero++;
                while (resultado[ultimo] > pivote) ultimo--;
                if (primero <= ultimo)
                {
                    aux = resultado[ultimo];
                    resultado[ultimo] = resultado[primero];
                    resultado[primero] = aux;
                    primero++;
                    ultimo--;
                }
            } while (primero <= ultimo);
            return resultado;
        }

        public int[] Ordenrapido(int[] orden, int inicio, int fin)
        {

            int i = inicio, j = fin, aux;
            int pivote = orden[(inicio + fin) / 2];
            while (i <= j)
            {
                while (orden[i] < pivote) i++;
                while (orden[j] > pivote) j--;
                if (i <= j)
                {
                    aux = orden[j];
                    orden[j] = orden[i];
                    orden[i] = aux;
                    i++;
                    j--;
                }
            }
            if (inicio < j)
                Ordenrapido(orden, inicio, j);
            if (i < fin)
                Ordenrapido(orden, i, fin);
            return orden;



        }


        public int[] Ordenar(int[] arreglo)
        {
            int Incrementos = arreglo.Length;
            
            for (int p = (Incrementos - 1) / 2; p >= 0; --p)
                incrementable(ref arreglo, Incrementos, p);

            for (int i = arreglo.Length - 1; i > 0; --i)
            {
                int aux = arreglo[i];
                arreglo[i] = arreglo[0];
                arreglo[0] = aux;

                --Incrementos;
                incrementable(ref arreglo, Incrementos, 0);
            }
            return arreglo;
        }

        public static void incrementable(ref int[] datos, int Incrementos, int indice)
        {
            int izquierda = (indice + 1) * 2 - 1;
            int derecha = (indice + 1) * 2;
            int distancia = 0;

            if (izquierda < Incrementos && datos[izquierda] > datos[indice])
                distancia = izquierda;
            else
                distancia = indice;

            if (derecha < Incrementos && datos[derecha] > datos[distancia])
                distancia = derecha;
            if (distancia != indice)
            {
                int temp = datos[indice];
                datos[indice] = datos[distancia];
                datos[distancia] = temp;

                incrementable(ref datos, Incrementos, distancia);
            }
        }
    }
}