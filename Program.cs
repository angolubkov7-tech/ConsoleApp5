using System;

namespace Medvedev
{
    class Program
    {
        // Метод возвращает НАИБОЛЬШЕЕ число
        public static int Maximum(int a, int b)
        {
            if (a > b)
            {
                return a; // Если a больше, возвращаем a
            }
            return b;     // Иначе возвращаем bllflf
        }

        // Метод возвращает НАИМЕНЬШЕЕ число
        public static int Minimum(int a, int b)
        {
            if (a < b)
            {
                return a; // Если a меньше, возвращаем a
            }
            return b;     // Иначе возвращаем b
        }

        static void Main(string[] args)



            Console.Write("Введите первое число: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int num2 = int.Parse(Console.ReadLine());

            // Вызываем правильные методы для каждой задачи
            int max = Maximum(num1, num2);
            int min = Minimum(num1, num2);

            // Выводим переменные на свои места (max к наибольшему, min к наименьшему)
            Console.WriteLine($"Наибольшее число: {max}, Наименьшее число: {min}");
        }
    }
}
