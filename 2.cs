using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[10, 10];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if(i < j)
                    {
                        m[i,j] = 2 * i + 7 * j - 2;
                    }
                    if(i == j)
                    {
                        m[i, j] = 3 * i * i - 1;
                    }
                    if(i > j)
                    {
                        m[i, j] = 4 * i * i * i - 5 * j * j + 1;
                    }
                    Console.Write(m[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
