using System;

namespace Medvedev
{
    class Program //exercize2
    {
       static void Main(string[] args)
       {
            Console.Write("Ввидите число а: ");
            int a =int.Parse(Console.ReadLine());
            Console.Write("Ввидите число b: ");
            int b = int.Parse(Console.ReadLine());


            Rarrangement(ref a, ref b);

            Console.WriteLine($"Значение а: {a}, Значение b: {b}");
       }

        static void Rarrangement(ref int aa, ref int bb)
        {
            int temp = aa;

            aa = bb;
            bb = temp;
        }
    }
}