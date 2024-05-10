using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma1 = 0;
            int[,] m = new int[500, 500];
            Random rnd = new Random();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                soma1 = 0;
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = rnd.Next(0, 10);
                    Console.Write(m[i, j] + " ");
                    soma1 += m[i, j];
                }
                Console.WriteLine();
            }
            double soma2 = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                soma2 = 0;
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    soma2 += m[j, i];
                }
            }
            double somadp = 0, somads = 0;
            for (int i = 0, j = 0, k = 500 - 1; i < m.GetLength(0); i++, j++, k--)
            {
                somadp += m[i, j];
                somads += m[i, k];
            }
            if(soma1 == soma2 && somadp == somads)
            {
                Console.WriteLine("A matriz é um quadrado mágico");
            }
            else
            {
                Console.WriteLine("A matriz não é um quadrado mágico");
            }
            Console.ReadLine();
        }
    }   
}
