using System;

namespace Medvedev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для вычисления факториала: ");
            int number = int.Parse(Console.ReadLine());

            if (Factorial(number, out long result))
            {
                Console.WriteLine($"Число: {number} факториал: {result}");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }  

        static bool Factorial(int n, out long fac)
        {
            long temp = 1;

            try
            {
                checked
                {
                    for (int i = 2; i <= n; i++)
                    {
                        temp *= i;
                    }

                    fac = temp;

                    return true;
                }
            }

            catch (OverflowException)
            {
                fac = 0;
                return false;
            }

        }
    }
}
