using System;

namespace Medvedev
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Введите n номер из ряда фибоначи: ");
                int fib = int.Parse(Console.ReadLine());

                long result = Row(fib);
                Console.WriteLine($"{fib} число в ряду фибоначи равно: {result}");
            }

            catch (FormatException)
            {
                Console.WriteLine("Введите число !");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Число слишком большое произошло переполниние!");
            }
            
        }

        static int Row(int n)
        {
            if (n == 1 || n == 2) return 1;

            checked
            {
                return Row(n - 1) + Row(n - 2);
            }
        }
    }
}

