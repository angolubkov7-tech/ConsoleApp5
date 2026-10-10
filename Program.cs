using System;

namespace Medvedev
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите число а: ");
            int u = int.Parse(Console.ReadLine());

            Console.Write("Введите число b: ");
            int d = int.Parse(Console.ReadLine());

            Console.Write("Ввидите число c: ");
            int c = int.Parse(Console.ReadLine());

            int result = 0;

            Algoritm(u, d, ref result);

            Algoritm(result, c, ref result);

            Console.WriteLine($"Наибольший общий делитель чисел {u}, {d} и {c} равен: {result}");
        }

        static void Algoritm(int a, int b, ref int temp)
        {
            if (a > b)
            {
                while (a != 0)
                {
                    int remainder = a % b;
                    a = remainder;
                    if (a != 0) b = a; 
                }
                temp = b; 
            }
            else
            {
                while (b != 0)
                {
                    int remainder = b % a;
                    b = remainder;
                    if (b != 0) a = b;
                }
                temp = a; 
            }
        }
    }
}

