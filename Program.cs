using System;
using System.Net.Http.Headers;
using System.Threading;

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

        //// Задача 2

        //static void Main(string[] args)
        //{
        //    long product = 1;
        //    double avger;


        //    long sum = CalculateArrayData(ref product, out avger, 1 ,2, 3, 4, 5, 6, 10000, 2);

        //    Console.WriteLine("Операции над числами 1, 2, 3, 4, 5. (Смотреть ниже)");
        //    Console.WriteLine($"Сумма чисел равна: {sum}");
        //    Console.WriteLine($"Произведение чисел равна: {product}");
        //    Console.WriteLine($"Средние арифмитическое чисел равна: {avger}");
        //}

        //public static long CalculateArrayData(ref long prod, out double avg, params int[] numbers)
        //{
        //    long sum = 0;
        //    prod = 1;

        //    for (int i =0; i < numbers.Length; i++)
        //    {
        //        sum += numbers[i];
        //        prod *= numbers[i];
        //    }

        //    avg = (double)sum / numbers.Length;

        //    return sum;
        //}

        // Задача 4

        struct DED //Создаем структуру деда в которой 5 дедов
        {
            //Поля структуры: имя массив фраз синяки по умолчанию 0
            public string name;
            public string[] GrumblingPhrases;
            public int bruise;

            //Внутренний массив содержащий в себе 5 дедов
            public DED[] fiveDEds;
                
            //Конструктор используется для создания каждого деда по отдельности
            public DED(string name, string[] phrases)
            {
                this.name = name;
                this.GrumblingPhrases = phrases;
                this.bruise = 0;
                this.fiveDEds = null; //Для конкретного деда массив не нужен поэтому ставим null
            }

            //Конструктор 2 для создание контейнера с главным дедом для создания дедов
            public DED()
            {
                //Выделяем память под массив дедов
                this.fiveDEds = new DED[5];


                //Используя конструктор 1 создаем дедов
                this.fiveDEds[0] = new DED("Геннадий", new string[] { "Гады", "Проститутки", "Суки" });

                this.fiveDEds[1] = new DED("Петрович", new string[] { "Цены ломят, гады!", "Опять телик врет!", "В наше время такого не было!" });
            
                this.fiveDEds[2] = new DED("Михалыч", new string[] { "Бляха-муха, опять спина!", "Уроды на дорогах!", "Черти полосатые!", "Куда прешь?!" });

                this.fiveDEds[3] = new DED("Савельич", new string[] { "Политики хреновы!", "Разворовали страну, говнюки!", "Тьфу, смотреть тошно!" });

                this.fiveDEds[4] = new DED("Степаныч", new string[] { "Опять намусорили, бляди!", "Где мои очки, сука?", "Ироды проклятые!", "Молодежь совсем от рук отбилась!" });
            }

            //Метод проверки принимает на вход конкретного деда и проверяет на запрещенку
            public int CheckBadWords(DED ded, params string[] badwars)
            {
                int newbruise = 0; //счетчик фингалов

                //Внешний цикл. Проверяем каждую фразу из словаря деда
                foreach (var phrase in ded.GrumblingPhrases)
                {
                    //Переводим фразу в слова с мальнькой буквы для удобства
                    string lowerPhrase = phrase.ToLower();

                    //Внутренний цикл. Проверяем каждое слово с словарем бабки тоесть запрещенкой
                    foreach (var badWord in badwars)
                    {

                        //Если программа находит запрещенку то бабка бьет деда
                        if (lowerPhrase.Contains(badWord.ToLower()))
                        {
                            newbruise++;
                        }
                    }
                }

                //Возращаем общие количество фингалов
                return newbruise;
                
            }
        }

        static void Main(string[] args)
        {
            //Вызываем конструктор без параметров создаем один контейнер где сидят 5 дедов
            DED mainContainer = new DED();

            //Список запрещенки или словарь бабки
            string[] forbiddenWords = { "сука", "суки", "бляха", "бляди", "говнюки" };

            Console.WriteLine("Бабка начинает проверку!!!!!");

            //По очереди проверяем каждого деда
            for (int i = 0; i < mainContainer.fiveDEds.Length; i++) 
            {
                // Так как DED — это структура, мы не можем менять её поля прямо внутри массива.
                // Поэтому мы копируем текущего деда во временную переменную currentDed.
                DED currentDed = mainContainer.fiveDEds[i];

                // Вызываем метод проверки, передавая туда скопированного деда и массив запрещенных слов
                int freshBruises = mainContainer.CheckBadWords(currentDed, forbiddenWords);

                // Добавляем новые полученные фингалы к общему счетчику синяков временного деда
                currentDed.bruise += freshBruises;

                // Записываем обновленного деда (уже с синяками) обратно в массив
                mainContainer.fiveDEds[i] = currentDed;

                // 4. Выводим результаты на экран
                Console.WriteLine($" Дед: {mainContainer.fiveDEds[i].name}");
                Console.WriteLine($" Фраз в лексиконе: {mainContainer.fiveDEds[i].GrumblingPhrases.Length}");
                Console.WriteLine($" Получено фингалов сейчас: {freshBruises}");
                Console.WriteLine($" Всего синяков у деда: {mainContainer.fiveDEds[i].bruise}");
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}
