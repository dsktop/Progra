using System;
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

            int numero1, numero2, numerofin;

            Console.WriteLine("ingrese numero de inicio");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese numero fin");
            numero2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 0; i++)
            {
                if(numero1 > numero2)
                {
                    Console.WriteLine("+------------+");
                    Console.WriteLine("{0}", numero1);
                    Console.WriteLine("{0}", numero2);
                }if(numero2 > numero1)
                {
                    Console.WriteLine("+------------+");
                    Console.WriteLine("{0}", numero2);
                    Console.WriteLine("{0}", numero1);
                }
            }



            Console.ReadKey();
        }
    }
}
