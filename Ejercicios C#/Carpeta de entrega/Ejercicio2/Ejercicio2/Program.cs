using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Solicitar al usuario que ingrese un inicio y un fin. 
//Mostrar los número de forma decreciente utilizando el bucle for. (en caso de que la variable fin sea mayor a la variable inicio se deberán intercambiar sus valores).

namespace GuiaEjercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero1, numero2, numero3;

            Console.WriteLine("ingrese numero 1");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese numero 2");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese numero 3");
            numero3 = Convert.ToInt32(Console.ReadLine());

            ArrayList arlist = new ArrayList();

            arlist.Add(numero1);
            arlist.Add(numero2);
            arlist.Add(numero3);

            Console.WriteLine("+----------+");
            for (int i = 0; i < arlist.Count; i++)
            {

                Console.WriteLine(arlist[i]);

            }

            float promedio, suma;


            if (numero1 == 0 || numero2 == 0 || numero3 == 0)
            {
                if (numero1 > numero2)
                    if (numero2 > numero3)
                        Console.WriteLine("El orden de mayor a menor es: " + numero1 + " " + numero2 + " " + numero3);
                    else
                    if (numero1 > numero3)
                        Console.WriteLine("El orden de mayor a menor es: " + numero1 + " " + numero3 + " " + numero2);
                    else
                        Console.WriteLine("El orden de mayor a menor es: " + numero3 + " " + numero1 + " " + numero2);
                else
                if (numero1 > numero3)
                    Console.WriteLine("El orden de mayor a menor es: " + numero2 + " " + numero1 + " " + numero3);
                else
                if (numero2 > numero3)
                    Console.WriteLine("El orden de mayor a menor es: " + numero2 + " " + numero3 + " " + numero1);
                else
                    Console.WriteLine("El orden de mayor a menor es: " + numero3 + " " + numero2 + " " + numero1);

                suma = numero1 + numero2 + numero3;

                promedio = suma / 3;

                Console.WriteLine("El promedio es: " + promedio);
            }






            Console.ReadKey();
        }
    }
}