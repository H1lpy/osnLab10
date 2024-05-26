using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[,] P = new int[7, 7];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    P[i, j] = r.Next(-5, 11);
                }
            }

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(P[i,j] + "\t");
                }
                Console.WriteLine();
            }

            //Задание 1
            Console.WriteLine("Задание 1");
            for (int i = 6; i >= 3; i--)
            {
                for (int j = 6 - i; j <= i; j++)
                {
                    if (P[j, i] == 10)
                    {
                        P[j, i] = 0;
                    }
                }
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(P[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //Задание 2
            Console.WriteLine("Задание 2");
            int c = 0;
            for (int i = 6; i >= 3; i--)
            {
                for (int j = 6 - i; j <= i; j++)
                {
                    if (P[j, i] != 0)
                    {
                        c++;
                    }
                }
            }
            int[] E = new int[c];
            int k = 0;
            for (int i = 6; i >= 3; i--)
            {
                for (int j = 6 - i; j <= i; j++)
                {
                    if (P[j, i] != 0)
                    {
                        E[k] = P[j, i];
                        k++;
                    }
                }
            }
            Console.WriteLine(String.Join(",", E));

            //Задание 3
            Console.WriteLine("Задание 3");
            int[] q = new int[4];
            k = 0;
            int max = int.MinValue;

            for (int j = 6; j >= 3; j--)
            {
                for (int i = 6 - j; i <= j; i++)
                {
                    if (P[i, j] > max)
                    {
                        max = P[i, j];
                    }
                }
                q[k] = max;
                k++;
                max = int.MinValue;
            }
            Console.WriteLine(String.Join(",", q));

            //Задание 4
            Console.WriteLine("Задание 4");
            c = 0;
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (P[i, j] < 0)
                    {
                        c++;
                    }
                }
            }
            Console.WriteLine($"C = {c}");
        }
    }
}
