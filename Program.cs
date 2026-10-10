using System;

namespace Medvedev
{
    class Program
    {
        
        public static int Maximum(int a, int b)
        {
            if (a > b)
            {
                return a; 
            }
            return b;     
        }

        
        public static int Minimum(int a, int b)
        {
            if (a < b)
            {
                return a; 
            }
            return b;     
        }

        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int num2 = int.Parse(Console.ReadLine());

           
            int max = Maximum(num1, num2);
            int min = Minimum(num1, num2);

            
            Console.WriteLine($"Наибольшее число: {max}, Наименьшее число: {min}");
        }
    }
}
