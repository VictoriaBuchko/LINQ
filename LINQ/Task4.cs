using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Task4
    {
        public class Laptop
        {
            public string Model { get; set; }
            public string Manufacturer { get; set; }
            public double ProcessorFrequency { get; set; } 
            public int CoreCount { get; set; }
            public decimal Price { get; set; }
            public int Year { get; set; } 

            public Laptop(string model, string manufacturer, double processorFrequency, int coreCount, decimal price, int year)
            {
                Model = model;
                Manufacturer = manufacturer;
                ProcessorFrequency = processorFrequency;
                CoreCount = coreCount;
                Price = price;
                Year = year;
            }

            public override string ToString()
            {
                return $"Модель: {Model}, Виробник: {Manufacturer}, Частота процесора: {ProcessorFrequency} ГГц, Кількість ядер: {CoreCount}, Ціна: {Price}, Рік випуску: {Year}";
            }

            public static void CountLaptops(Laptop[] laptops)
            {
                Console.WriteLine($"Кількість ноутбуків: {laptops.Count()}");
            }


            //в якості вхідної ціни я поставила 1000
            public static void CountLaptopsAbovePrice(Laptop[] laptops, decimal inputPrice)
            {
                int countAbovePrice = laptops.Count(l => l.Price > inputPrice);
                Console.WriteLine($"Кількість ноутбуків з вартістю більше {inputPrice}: {countAbovePrice}");
            }

            public static void CountLaptopsInRange(Laptop[] laptops, decimal minPrice, decimal maxPrice)
            {
                int countInRange = laptops.Count(l => l.Price >= minPrice && l.Price <= maxPrice);
                Console.WriteLine($"Кількість ноутбуків в діапазоні цін {minPrice} \\{maxPrice}: {countInRange}");
            }

            public static void CountLaptopsByManufacturer(Laptop[] laptops, string manufacturer)
            {
                int countByManufacturer = laptops.Count(l => l.Manufacturer == manufacturer);
                Console.WriteLine($"Кількість ноутбуків виробника {manufacturer}: {countByManufacturer}");
            }

            public static void LaptopMinPrice(Laptop[] laptops)
            {
                var minPriceLaptop = laptops.OrderBy(l => l.Price).First();
                Console.WriteLine($"Ноутбук з мінімальною вартістю: {minPriceLaptop}");
            }

            public static void LaptopMaxPrice(Laptop[] laptops)
            {
                var maxPriceLaptop = laptops.OrderByDescending(l => l.Price).First();
                Console.WriteLine($"Ноутбук з максимальною вартістю: {maxPriceLaptop}");
            }

            public static void LaptopMinProcessor(Laptop[] laptops)
            {
                var minFreqLaptop = laptops.OrderBy(l => l.ProcessorFrequency).First();
                Console.WriteLine($"Ноутбук з найменшою частотою процесора: {minFreqLaptop}");
            }

            public static void LatestLaptop(Laptop[] laptops)
            {
                var latestLaptop = laptops.OrderByDescending(l => l.Year).First();
                Console.WriteLine($"Найновіша модель ноутбука: {latestLaptop}");
            }

            public static void AveragePrice(Laptop[] laptops)
            {
                decimal averagePrice = laptops.Average(l => l.Price);
                Console.WriteLine($"Середня вартість ноутбука: {averagePrice}");
            }

            public static void ManufacturerStatistics(Laptop[] laptops)
            {
                var manufacturerStats = laptops.GroupBy(l => l.Manufacturer)
                    .Select(g => new { Manufacturer = g.Key, Count = g.Count() });

                Console.WriteLine("Статистика за кількістю ноутбуків кожного виробника:");
                foreach (var stat in manufacturerStats)
                {
                    Console.WriteLine($"{stat.Manufacturer}: {stat.Count}");
                }
            }

            public static void ModelStatistics(Laptop[] laptops)
            {
                var modelStats = laptops.GroupBy(l => l.Model)
                    .Select(g => new { Model = g.Key, Count = g.Count() });

                Console.WriteLine("Статистика за кількістю моделей ноутбуків:");
                foreach (var stat in modelStats)
                {
                    Console.WriteLine($"{stat.Model}: {stat.Count}");
                }
            }

            public static void YearStatistics(Laptop[] laptops)
            {
                var yearStats = laptops.GroupBy(l => l.Year)
                    .Select(g => new { Year = g.Key, Count = g.Count() });

                Console.WriteLine("Статистика ноутбуків за роками:");
                foreach (var stat in yearStats)
                {
                    Console.WriteLine($"{stat.Year}: {stat.Count}");
                }
            }

            public static void TopFiveExpensive(Laptop[] laptops)
            {
                var topFiveExpensive = laptops.OrderByDescending(l => l.Price).Take(5);
                Console.WriteLine("П’ять найдорожчих ноутбуків:");
                foreach (var laptop in topFiveExpensive)
                {
                    Console.WriteLine(laptop);
                }
            }

            public static void TopFiveCheapLaptops(Laptop[] laptops)
            {
                var topFiveCheap = laptops.OrderBy(l => l.Price).Take(5);
                Console.WriteLine("П’ять найдешевших ноутбуків:");
                foreach (var laptop in topFiveCheap)
                {
                    Console.WriteLine(laptop);
                }
            }

            public static void ThreeOldest(Laptop[] laptops)
            {
                var threeOldest = laptops.OrderBy(l => l.Year).Take(3);
                Console.WriteLine("Три найстаріші моделі ноутбуків:");
                foreach (var laptop in threeOldest)
                {
                    Console.WriteLine(laptop);
                }
            }

            public static void ThreeNew(Laptop[] laptops)
            {
                var threeNewest = laptops.OrderByDescending(l => l.Year).Take(3);
                Console.WriteLine("Три найновіші моделі ноутбуків:");
                foreach (var laptop in threeNewest)
                {
                    Console.WriteLine(laptop);
                }
            }

            public static void ExecuteLaptopStatistics(Laptop[] laptops)
            {
                CountLaptops(laptops);
                CountLaptopsAbovePrice(laptops, 1000m);
                CountLaptopsInRange(laptops, 600m, 1300m);
                CountLaptopsByManufacturer(laptops, "123");
                LaptopMinPrice(laptops);
                LaptopMaxPrice(laptops);
                LaptopMinProcessor(laptops);
                LatestLaptop(laptops);
                AveragePrice(laptops);
                ManufacturerStatistics(laptops);
                ModelStatistics(laptops);
                YearStatistics(laptops);
                TopFiveExpensive(laptops);
                TopFiveCheapLaptops(laptops);
                ThreeOldest(laptops);
                ThreeNew(laptops);
            }
        }
    }
}
