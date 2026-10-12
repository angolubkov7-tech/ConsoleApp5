using System;
using System.Net.Http.Headers;

namespace Medvedev
{
    class Program
    {
        // //Задача 1
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        int[] num;
        //        Massiv(out num);

        //        Console.WriteLine("Выводим на экран 20 чисел из массива:");
        //        PrintArray(num);


        //        Console.WriteLine("\nВведите индекс первого элемента, который хотите поменять (от 0 до 19):");
        //        int index1 = int.Parse(Console.ReadLine());

        //        Console.WriteLine("Введите индекс второго элемента, который хотите поменять (от 0 до 19):");
        //        int index2 = int.Parse(Console.ReadLine());

        //        if ((index1 < 0 || index1 > 19) || (index2 < 0 || index2 > 19))
        //        {
        //            throw new ArgumentException("Неправильный диапазон");
        //        }

        //        Console.WriteLine($"\nВыводим на экран выбранные числа: {num[index1]}, {num[index2]}");

        //        Console.WriteLine("Заменяем эти числа друг на друга...");
        //        int temp = num[index1];
        //        num[index1] = num[index2];
        //        num[index2] = temp;

        //        Console.WriteLine("\nВыводим на экран измененный массив:");
        //        PrintArray(num);
        //    }

        //    catch (ArgumentException)
        //    {
        //        Console.WriteLine("Ошибка");
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Ввели не число");
        //    }
        //}

        //public static void Massiv(out int[] numbers)
        //{
        //    numbers = new int[20];
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        numbers[i] = i + 1;
        //    }
        //}

        //public static void PrintArray(int[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.Write(array[i] + " "); 
        //    }
        //    Console.WriteLine();
        //}

        // Задача 2

        static void Main(string[] args)
        {
            long product = 1;
            double avger;


            long sum = CalculateArrayData(ref product, out avger, 1 ,2, 3, 4, 5);

            Console.WriteLine("Операции над числами 1, 2, 3, 4, 5. (Смотреть ниже)");
            Console.WriteLine($"Сумма чисел равна: {sum}");
            Console.WriteLine($"Произведение чисел равна: {product}");
            Console.WriteLine($"Средние арифмитическое чисел равна: {avger}");
        }

        public static long CalculateArrayData(ref long prod, out double avg, params int[] numbers)
        {
            long sum = 0;
            prod = 1;

            for (int i =0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                prod *= numbers[i];
            }

            avg = (double)sum / numbers.Length;

            return sum;
        }
    }
}
