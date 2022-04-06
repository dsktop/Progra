using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float promedio, sumaNota = 0;
            int cantidadNota;

            Console.WriteLine("Ingrese la cantidad de notas:");
            cantidadNota = Convert.ToInt32(Console.ReadLine());
            float[] notas = new float[cantidadNota];

            for (int i = 0; i <= notas.Length - 1; i++)
            {
                Console.WriteLine("Ingrese nota {0}:", i + 1);
                notas[i] = float.Parse(Console.ReadLine());
                sumaNota += notas[i];
            }

            promedio = sumaNota / cantidadNota;

            for (int i = 0; i <= notas.Length - 1; i++)
            {
                Console.WriteLine(notas[i]);
            }

            if (promedio >= 4.0)
            {
                Console.WriteLine("Aprobado con nota: {0}", promedio);
            }
            else
            {
                Console.WriteLine("Reprobado con nota: {0}", promedio);
            }

            Console.ReadKey();
        }
    }
}