using System;

namespace Medvedev
{
    class Program 
    {
       static void Main(string[] args)
       {
            int[] num;
            Massiv(out num);

            Console.WriteLine("Ввыводим на экран 20 чисел из массива");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

            Console.WriteLine("Выводим на экран два любых числа");
            Console.WriteLine($"{num[7]}, {num[10]}");

            Console.WriteLine("Заменяем эти числа друг на друга");
            int temp = num[7];
            num[7] = num[10];
            num[10] = temp;

            Console.WriteLine("Ввыводим на экран 20 чисел из массива");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
        }

        public static void Massiv( out int[] numbers)
        {
            numbers = new int[20];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }


        }
    }

}