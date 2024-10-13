using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LINQ.Task4;

namespace LINQ
{
    internal class Menu
    {
        public static void Task1()
        {
            Console.WriteLine("Task1");

            int[] numbers = { 12, 27, 54, 945, 1053, 81, 18, 36, 729, 1500 };

            int product = numbers.Aggregate((a, b) => a * b);
            Console.WriteLine($"Добуток елементів масиву: {product}");

            int count = numbers.Count();
            Console.WriteLine($"Кількість елементів масиву: {count}");

            int count9 = numbers.Count(n => n % 9 == 0);
            Console.WriteLine($"Кількість елементів, кратних 9: {count9}");

            int count945 = numbers.Count(n => n % 7 == 0 && n > 945);
            Console.WriteLine($"Кількість елементів, кратних 7 і більших за 945: {count945}");

            int sum = numbers.Sum();
            Console.WriteLine($"Сума елементів масиву: {sum}");

            int sumEven = numbers.Where(n => n % 2 == 0).Sum();
            Console.WriteLine($"Сума парних елементів масиву: {sumEven}");

            int min = numbers.Min();
            Console.WriteLine($"Мінімум в масиві: {min}");

            int max = numbers.Max();
            Console.WriteLine($"Максимум в масиві: {max}");

            double average = numbers.Average();
            Console.WriteLine($"Середнє значення в масиві: {average}");
        }
        public static void Task2()
        {
            int[] numbers = { 12, 27, 54, 945, 1053, 81, 18, 36, 729, 1500 };

            Console.WriteLine("\n\nTask2");
            var topThree = numbers.OrderByDescending(n => n).Take(3);
            Console.WriteLine("Три перші максимальні елементи: " + string.Join(", ", topThree));

            var topThreeMin = numbers.OrderBy(n => n).Take(3);
            Console.WriteLine("Три перші мінімальні елементи: " + string.Join(", ", topThreeMin));

        }

        public static void Task3()
        {
            int[] numbers = { 12, 27, 54, 945, 1053, 81, 18, 36, 729, 1500 };
            Console.WriteLine("\n\nTask3");
            var num = numbers.GroupBy(n => n)
                .Select(g => new { Number = g.Key, Count = g.Count() });

            Console.WriteLine("Статистика входження кожного числа:");
            foreach (var n in num)
            {
                Console.WriteLine($"{n.Number} = {n.Count} рази");
            }

            var even = numbers.Where(n => n % 2 == 0)
                .GroupBy(n => n)
                .Select(n => new { Number = n.Key, Count = n.Count() });

            Console.WriteLine("\nСтатистика входження парних чисел:");
            foreach (var n in even)
            {
                Console.WriteLine($"{n.Number}= {n.Count} рази");
            }

            int evenCount = numbers.Count(n => n % 2 == 0);
            int oddCount = numbers.Count(n => n % 2 != 0);

            Console.WriteLine($"\nПарні: {evenCount} рази, непарні: {oddCount} рази");

        }
        public static void Task4()
        {

            Console.WriteLine("\n\nTask4");

            Laptop[] laptops = new Laptop[]
            {
                   new Laptop("A", "123", 2.5, 4, 1200m, 2021),
                   new Laptop("B", "2234", 3.0, 8, 1500m, 2020),
                   new Laptop("C", "123", 2.0, 4, 800m, 2022),
                   new Laptop("D", "4567", 3.5, 6, 2000m, 2023),
                   new Laptop("E", "12345678", 1.8, 2, 600m, 2019)
            };

            Laptop.ExecuteLaptopStatistics(laptops);
        }
        public static void Task5()
        {

            Console.WriteLine("\n\nTask5");
            int[] numberss = { 1, 2, 8, -1, 4, 2, 7, 9, 15, 19, 24, 5 };
            int number = numberss.Length;

            int maxLength = 0;
            int currentLength = 1;
            int startIndex = 0;

            for (int i = 1; i < number; i++)
            {
                if (numberss[i] > numberss[i - 1])
                {
                    currentLength++;
                }
                else
                {

                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        startIndex = i - currentLength;
                    }
                    currentLength = 1;
                }
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                startIndex = number - currentLength;
            }

            Console.WriteLine($"Довжина найбільшої зростаючої послідовності: {maxLength}");
            Console.Write("Послідовність: ");
            for (int i = startIndex; i < startIndex + maxLength; i++)
            {
                Console.Write(numberss[i] + " ");
            }

        }
        public static void Task6()
        {
            Console.WriteLine("\nTask6");

            string[] surnames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Orange", "Miller", "Davis", "Wright" };

            bool allLongerThanThree = surnames.All(s => s.Length > 3);
            Console.WriteLine($"більше трьох символів: {allLongerThanThree}");

            bool allBetweenThreeAndTen = surnames.All(s => s.Length > 3 && s.Length < 10);
            Console.WriteLine($"більше трьох і менше десяти символів: {allBetweenThreeAndTen}");

            bool anyStartsWithW = surnames.Any(s => s.StartsWith("W"));
            Console.WriteLine($"Є хоча б одне прізвище, яке починається з літери w: {anyStartsWithW}");

            bool anyEndsWithY = surnames.Any(s => s.EndsWith("y"));
            Console.WriteLine($"Є хоча б одне прізвище, яке закінчується на літеру y: {anyEndsWithY}");

            bool orange = surnames.Contains("Orange");
            Console.WriteLine($"У масиві є прізвище orange: {orange}");

            string lengthSix = surnames.FirstOrDefault(s => s.Length == 6);
            Console.WriteLine($"Перше прізвище з довжиною 6: {lengthSix}");

            string lessFifteen = surnames.LastOrDefault(s => s.Length < 15);
            Console.WriteLine($"Останнє прізвище з довжиною менше 15: {lessFifteen}");
        }

        public static void Task7()
        {

            Console.WriteLine("\nTask7");

            Magazine[] magazines =
            {
            new Magazine("Політика", "Політика", 40, new DateTime(2022, 3, 1)),
            new Magazine("Мода 2022", "Мода", 50, new DateTime(2022, 4, 1)),
            new Magazine("Спорт", "Спорт", 35, new DateTime(2022, 5, 1)),
            new Magazine("Сад і город", "Сад та город", 20, new DateTime(2021, 2, 1)),
            new Magazine("Рибалка", "Рибалка", 25, new DateTime(2021, 6, 1)),
            new Magazine("АвтоСвіт", "Транспорт", 60, new DateTime(2022, 8, 1)),
            new Magazine("Полювання", "Полювання", 30, new DateTime(2021, 10, 1)),
            };

            bool allmore30 = magazines.All(m => m.PageCount > 30);
            Console.WriteLine($"У всіх журналів кількість сторінок більше 30: {allmore30}");

            bool allGenre = magazines.All(m =>
                m.Genre == "Політика" || m.Genre == "Мода" || m.Genre == "Спорт");
            Console.WriteLine($"Всі журнали у жанрі Політика, Мода або Спорт: {allGenre}");

            bool gardenGenre = magazines.Any(m => m.Genre == "Сад та город");
            Console.WriteLine($"Є хоча б один журнал у жанрі Сад та город: {gardenGenre}");

            bool fishingGenre = magazines.Any(m => m.Genre == "Рибалка");
            Console.WriteLine($"Є хоча б один журнал у жанрі Рибалка: {fishingGenre}");

            bool huntingCount = magazines.Any(m => m.Genre.Equals("Полювання", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"Є журнали про Полювання: {huntingCount}");

            Magazine magazine2022 = magazines.FirstOrDefault(m => m.PublicationDate.Year == 2022);
            Console.WriteLine($"Перший журнал з роком випуску 2022: {magazine2022?.Title ?? "Немає журналів 2022 року"}");

            Magazine autoMagazine = magazines.LastOrDefault(m => m.Title.StartsWith("Авто", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"Починається зі слова Авто»: {autoMagazine?.Title ?? "Немає журналів, назва яких починається зі слова «Авто»"}");

        }

        public static void Task8()
        {
            Console.WriteLine("\nTask8");

            int[] numbersd = { 1, 2, 8, -1, 4, 2, 7, 9, -7, 15, 5 };

            List<int> currentSequence = new List<int>();
            List<List<int>> positiveSequences = new List<List<int>>();

            foreach (var numberd in numbersd)
            {
                if (numberd > 0)
                {
                    currentSequence.Add(numberd);
                }
                else
                {
                    if (currentSequence.Count > 0)
                    {
                        positiveSequences.Add(new List<int>(currentSequence));
                        currentSequence.Clear();
                    }
                }
            }

            if (currentSequence.Count > 0)
            {
                positiveSequences.Add(new List<int>(currentSequence));
            }


            var longestSequence = positiveSequences
                .OrderByDescending(seq => seq.Count)
                .FirstOrDefault();

            int maxLengthd = longestSequence?.Count ?? 0;
            Console.WriteLine($"Довжина найбільшої додатної послідовності: {maxLengthd}");
            Console.Write("Послідовність: ");

            if (longestSequence != null)
            {
                Console.WriteLine(string.Join(" ", longestSequence));
            }
            else
            {
                Console.WriteLine("Немає додатних чисел");
            }

            //int[] numb = { 1, 2, 8, -1, 4, 2, 7, 9, 15, 5 };

            //var positiveSequences = numbers
            //    .Select((value, index) => new { Value = value, IsPositive = value > 0 })
            //    .GroupBy(x => x.IsPositive ? 1 : 0)
            //    .Where(g => g.Key == 1 && g.All(n => n.Value > 0))
            //    .Select(g => g.Select(x => x.Value).ToList())
            //    .ToList();


            //var longestSequence = positiveSequences
            //    .OrderByDescending(g => g.Count())
            //    .FirstOrDefault();

            //int maxLengt = longestSequence?.Count() ?? 0;

            //Console.WriteLine($"Довжина найбільшої додатної послідовності: {maxLengt}");
            //Console.Write("Послідовність: ");
            //if (longestSequence != null)
            //{
            //    Console.WriteLine(string.Join(" ", longestSequence));
            //}
            //else
            //{
            //    Console.WriteLine("Немає додатних чисел");
            //}
        }
    }
}
