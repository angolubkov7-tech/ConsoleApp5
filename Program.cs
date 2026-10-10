using System;

namespace Medvedev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввидите число а: ");
            int u = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int d = int.Parse(Console.ReadLine());


            Algoritm(u, d);

            Console.WriteLine($"Наибольший одщий делитель чисел: {u, d} равен: {}")

        }

        static void Algoritm(int a, int b)
        {
            int temp = b;

            if (a > b)
            {
                while (true)
                {
                    a %= b;
                    if (a == 0)
                    {
                        temp = a; break;
                    }
                }
            }

            else
            {
                while (true)
                {
                    b %= a;
                    if (b == 0) { temp = b; break; }
                }


            }
        }
    }
}
