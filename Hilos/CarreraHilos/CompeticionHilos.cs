using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace CarreraHilos
{
    class CompeticionHilos
    {
        public static void ProcesoHilo()
        {
            int i;
            for ( i = 0; i < 10; i++)
            {
                Random c = new Random();
                int avanza = c.Next(0, 3);
                Console.WriteLine(" | * |   |   |   |   |   |   |   |");
                i += avanza;
                Thread.Sleep(500);
            } 
           
        }

        public static void ProcesoHilo2()
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Random c = new Random();
                int avanza = c.Next(0, 3);
                Console.WriteLine(" |   | . |   |   |   |   |   |   |");
                i += avanza;
                Thread.Sleep(500);
            }

        }

        public static void ProcesoHilo3()
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Random c = new Random();
                int avanza = c.Next(0, 3);
                Console.WriteLine(" |   |   | + |   |   |   |   |   |");
                i += avanza;
                Thread.Sleep(500);
            }

        }

        public static void ProcesoHilo4()
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Random c = new Random();
                int avanza = c.Next(0, 3);
                Console.WriteLine(" |   |   |   | * |   |   |   |   |");
                i += avanza;
                Thread.Sleep(500);
            }

        }


        public static void ProcesoHilo5()
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Random c = new Random();
                int avanza = c.Next(0, 3);
                Console.WriteLine(" |   |   |   |   | - |   |   |   |");
                i += avanza;
                Thread.Sleep(500);
            }

        }

        public static void ProcesoHilo6()
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Random c = new Random();
                int avanza = c.Next(0, 3);
                Console.WriteLine(" |   |   |   |   |   | $ |   |   |");
                i += avanza;
                Thread.Sleep(500);
            }

        }

        public static void ProcesoHilo7()
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Random c = new Random();
                int avanza = c.Next(0, 3);
                Console.WriteLine(" |   |   |   |   |   |   | ^ |   |");
                i += avanza;
                Thread.Sleep(500);
            }

        }

        public static void ProcesoHilo8()
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Random c = new Random();
                int avanza = c.Next(0, 3);
                Console.WriteLine(" |   |   |   |   |   |   |   | @ |");
                i += avanza;
                Thread.Sleep(500);
            }

        }


        public static void Main()
        {
            Thread corredor1 = new Thread(new ThreadStart(ProcesoHilo));
            Thread corredor2 = new Thread(new ThreadStart(ProcesoHilo2));
            Thread corredor3 = new Thread(new ThreadStart(ProcesoHilo3));
            Thread corredor4 = new Thread(new ThreadStart(ProcesoHilo4));
            Thread corredor5 = new Thread(new ThreadStart(ProcesoHilo5));
            Thread corredor6 = new Thread(new ThreadStart(ProcesoHilo6));
            Thread corredor7 = new Thread(new ThreadStart(ProcesoHilo7));
            Thread corredor8 = new Thread(new ThreadStart(ProcesoHilo8));

            corredor1.Start();
            corredor2.Start();
            corredor3.Start();
            corredor4.Start();
            corredor5.Start();
            corredor6.Start();
            corredor7.Start();
            corredor8.Start();

            corredor1.Join();
            corredor2.Join();
            corredor3.Join();
            corredor4.Join();
            corredor5.Join();
            corredor6.Join();
            corredor7.Join();
            corredor8.Join();

            Console.WriteLine("--------------Meta----------------");

        }
    }
}
