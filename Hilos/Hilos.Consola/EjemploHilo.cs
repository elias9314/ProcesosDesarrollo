using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Hilos.Consola
{
    class EjemploHilo
    {
        public static void ProcesoHilo(object id)
        {
            int identificador = (int)id;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($" Hilo secundario {identificador}: Iteración {i}");
                Thread.Sleep(0);
            }
        }

        public static void Main()
        {
            Console.WriteLine("Hilo principal: Este hilo inicia un 2do hilo");

            Thread[] hilos = new Thread[1000];
            for(int i = 0; i<1000; i++)
            {
                hilos[0] = new Thread(ProcesoHilo);
                //hilos[0].Start(i);
            }
            //Thread t = new Thread(new ThreadStart(ProcesoHilo));
            // t.Start();
            Console.WriteLine("Cuantos hilos hay");
            Console.ReadLine();
            for (int i = 0; i < 1000; i++)
            {
                hilos[0].Start();
            }
            
            Thread.Sleep(0);

            for(int i =0; i<4; i++)
            {
                Console.WriteLine("Hilo principal : Me estoy ejecutando");
                Thread.Sleep(0);
            }
            Console.WriteLine("Yo como hilo principal: Llamo a la funcion de union 'Join()', para esperar al hilo secundario");
            Console.WriteLine("El hilo secundario ha regresado. Presione cualquier tecla para continuar");
            Console.ReadLine();
        }
    }
}
