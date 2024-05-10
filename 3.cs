using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ma;
            int[,] mb;
            int[,] mn;
            int[,] mmt;
            double mt;
            Random rnd = new Random();
            Console.WriteLine("Escolha algumas das seguintes opções:\n\n1. Soma matricial \n2. Subtração matricial \n3. Multiplicar uma matriz por um número real \n4. Sair");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("Dê as dimenosões da matriz: ");
                    int m = int.Parse(Console.ReadLine());
                    ma = new int[m, m];
                    Console.WriteLine("Matriz A");
                    for (int i = 0; i < ma.GetLength(0); i++)
                    {
                        for (int j = 0; j < ma.GetLength(1); j++)
                        {
                            ma[i, j] = rnd.Next(0, 10);
                            Console.Write(ma[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    mb = new int[m, m];
                    Console.WriteLine("Matriz B");
                    for (int i = 0; i < mb.GetLength(0); i++)
                    {
                        for (int j = 0; j < mb.GetLength(1); j++)
                        {
                            mb[i, j] = rnd.Next(0, 10);
                            Console.Write(mb[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    mn = new int[m, m];
                    for (int i = 0; i < ma.GetLength(0); i++)
                    {
                        for (int j = 0; j < ma.GetLength(0); j++)
                        {
                            mn[i, j] = ma[i, j] + mb[i, j];
                        }
                    }
                    Console.WriteLine("Adição Matricial: ");
                    for (int i = 0; i < ma.GetLength(0); i++)
                    {
                        for (int j = 0; j < ma.GetLength(0); j++)
                        {
                            Console.Write(mn[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("Dê as dimenosões da matriz: ");
                    int ms = int.Parse(Console.ReadLine());
                    ma = new int[ms, ms];
                    Console.WriteLine("Matriz A");
                    for (int i = 0; i < ma.GetLength(0); i++)
                    {
                        for (int j = 0; j < ma.GetLength(1); j++)
                        {
                            ma[i, j] = rnd.Next(0, 10);
                            Console.Write(ma[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    mb = new int[ms, ms];
                    Console.WriteLine("Matriz B");
                    for (int i = 0; i < mb.GetLength(0); i++)
                    {
                        for (int j = 0; j < mb.GetLength(1); j++)
                        {
                            mb[i, j] = rnd.Next(0, 10);
                            Console.Write(mb[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    mn = new int[ms, ms];
                    for (int i = 0; i < ma.GetLength(0); i++)
                    {
                        for (int j = 0; j < ma.GetLength(0); j++)
                        {
                            mn[i, j] = ma[i, j] - mb[i, j];
                        }
                    }
                    Console.WriteLine("Subtração Matricial: ");
                    for (int i = 0; i < ma.GetLength(0); i++)
                    {
                        for (int j = 0; j < ma.GetLength(0); j++)
                        {
                            Console.Write(ma[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    Console.WriteLine("Dê as dimenosões da matriz: ");
                    int mm = int.Parse(Console.ReadLine());
                    mmt = new int[mm, mm];
                    Console.WriteLine("Matriz A");
                    for (int i = 0; i < mmt.GetLength(0); i++)
                    {
                        for (int j = 0; j < mmt.GetLength(1); j++)
                        {
                            mmt[i, j] = rnd.Next(0, 10);
                            Console.Write(mmt[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.Write("Por favor, informe o número real para multiplicar a matriz: ");
                    double mp = double.Parse(Console.ReadLine());
                    for (int i = 0; i < mmt.GetLength(0); i++)
                    {
                        for (int j = 0; j < mmt.GetLength(1); j++)
                        {
                            mt = mmt[i, j] * mp;
                            Console.Write(mmt[i,j] + " ");
                        }
                        Console.WriteLine();
                    }
                break;
                    case 4:
                    Console.WriteLine("Saindo");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
