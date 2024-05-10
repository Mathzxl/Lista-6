using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] m;
            int n;
            double soma1, soma2;
            Console.WriteLine("Dê o tamanho da matriz");
            n = int.Parse(Console.ReadLine());
            m = new int[n, n];
            for(int i = 0 ; i < m.GetLength(0); i++)
            {
                soma1 = 0;
                for (int j=0; j < m.GetLength(1); j++)
                {
                    m[i,j] = rnd.Next(0, 10);
                    Console.Write(m[i,j] + " ");
                    soma1 += m[i, j];
                }
                Console.WriteLine($"Soma Linha: " + soma1);
                Console.WriteLine();
            }
            for (int i = 0; i < m.GetLength(0); i++)
            {
                soma2 = 0;
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    soma2 += m[j, i];
                }
                Console.WriteLine($"Soma Coluna: " + soma2);
            }
            double somadp=0, somads=0;
            for (int i = 0, j = 0, k = n - 1; i < m.GetLength(0); i++, j++, k--)
            {
                somadp += m[i, j];
                somads += m[i, k];
            }
            Console.WriteLine($"Soma Diagonal Principal: " + somadp);
            Console.WriteLine($"Soma Diagonal Secundaaria:" + somads);
            Console.ReadLine();
        }
    }
}
