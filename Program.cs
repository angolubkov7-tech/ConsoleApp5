using System;

namespace Medvedev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для вычисления факториала: ");
            ulong number = Convert.ToUInt64(Console.ReadLine());

            if (Factorial(number, out ulong result))
            {
                Console.WriteLine($"Число: {number} факториал: {result}");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }  

        static bool Factorial(ulong n, out ulong fac)
        {
            ulong temp = 1;

            try
            {
                checked
                {
                    for (ulong i = 2; i <= n; i++)
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
