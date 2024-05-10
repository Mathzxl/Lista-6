using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[4, 4];
            Console.WriteLine("Digite os elementos da matriz 4x4:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
            bool trl = true;
            for (int i = 1; i < 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (m[i, j] != 0)
                    {
                        trl = false;
                    }
                }
                if (trl)
                {
                    Console.WriteLine();
                }
            }

            if (trl)
            {
                Console.WriteLine("A matriz é triangular superior.");
            }
            else
            {
                Console.WriteLine("A matriz não é triangular superior.");
            }
            Console.ReadLine();
        }
    }
}
