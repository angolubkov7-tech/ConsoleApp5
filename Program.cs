using System;

namespace Medvedev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int nuber = int.Parse(Console.ReadLine());

            try
            {
                long result = factorial(nuber);
                Console.WriteLine($"Число:{nuber} его факториал: {result}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Данное число не поддерживается");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }


        }

        static long factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Число должно быть неотрицательным.");
            }

            if (n == 0 || n == 1)
            {
                return 1;
            }
            checked
            { 
            return n * factorial(n - 1);
            }
        }
    }
}
