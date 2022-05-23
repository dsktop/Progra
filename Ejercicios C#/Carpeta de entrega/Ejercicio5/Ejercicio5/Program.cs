using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void hilo1()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Fin de hilo 1");
        }
        static void hilo2()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Fin de hilo 2");
        }
        static void hilo3()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Fin de hilo 3");
        }
        static void hilo4()
        {
            Thread.Sleep(4000);
            Console.WriteLine("Fin de hilo 4");
        }
        static void hilo5()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Fin de hilo 5");
        }
        static void hilo6()
        {
            Thread.Sleep(6000);
            Console.WriteLine("Fin de hilo 6");
        }
        static void hilo7()
        {
            Thread.Sleep(7000);
            Console.WriteLine("Fin de hilo 7");
        }
        static void hilo8()
        {
            Thread.Sleep(8000);
            Console.WriteLine("Fin de hilo 8");

        }
        static void hilo9()
        {
            Thread.Sleep(9000);
            Console.WriteLine("Fin de hilo 9");

        }
        static void hilo10()
        {
            Thread.Sleep(10000);
            Console.WriteLine("Fin de hilo 10");

        }
        static void Main(string[] args)
        {
            Thread p1 = new Thread(new ThreadStart(hilo1));
            Thread p2 = new Thread(new ThreadStart(hilo2));
            Thread p3 = new Thread(new ThreadStart(hilo3));
            Thread p4 = new Thread(new ThreadStart(hilo4));
            Thread p5 = new Thread(new ThreadStart(hilo5));
            Thread p6 = new Thread(new ThreadStart(hilo6));
            Thread p7 = new Thread(new ThreadStart(hilo7));
            Thread p8 = new Thread(new ThreadStart(hilo8));
            Thread p9 = new Thread(new ThreadStart(hilo9));
            Thread p10 = new Thread(new ThreadStart(hilo10));

            p1.Start();
            p2.Start();
            p3.Start();
            p4.Start();
            p5.Start();
            p6.Start();
            p7.Start();
            p8.Start();
            p9.Start();
            p10.Start();


            Console.ReadKey();
        }
    }
}
