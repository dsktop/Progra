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

            int numero1;

            Console.WriteLine("Indique cuantos datos quiere ingresar");
            numero1 = Convert.ToInt32(Console.ReadLine());

            ArrayList arlist = new ArrayList();

            while (numero1 == 9)
            {
                Console.WriteLine("Indique cuantos datos quiere ingresar");
                numero1 = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 1; i <= numero1; i++)
            {
                Console.WriteLine("ingrese numero:" + i);
                arlist.Add(Console.ReadLine());

            }

            for (int i = arlist.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(arlist[i]);
            }







            Console.ReadKey();
        }
    }
}