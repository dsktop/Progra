using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
   {
        static void Main(string[] args)
        {
            int[,] numero = new int[3, 5];
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        numero[i, j] = 1;
                    }
                    else
                    {
                        numero[i, j] = 0;
                    }
                    Console.WriteLine("[{0},{1}] = {2}", i, j, numero[i, j]);
                }
            }
            Console.ReadKey();
        }   
    }
 }
