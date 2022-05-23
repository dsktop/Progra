using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Program
    {
        public int mate(int numero1, int numero2, int operador)
        {
            int resultado = 0;
            switch (operador)
            {
                case 1:
                    resultado = numero1 + numero2;
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    break;
                case 4:
                    resultado = numero1 / numero2;
                    break;
            }
            return resultado;
        }
        static void Main(string[] args)
        {
            Program m = new Program();
            int opcion;
            int num1, num2;
            Console.WriteLine("Ingrese la opcion: ");
            Console.WriteLine("1:Sumar");
            Console.WriteLine("2:Restar");
            Console.WriteLine("3:Multiplicar");
            Console.WriteLine("4:Dividir");

            opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el primer valor: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El resultado es: {0}", m.mate(num1, num2, opcion));


            Console.ReadKey();
        }
    }
}

