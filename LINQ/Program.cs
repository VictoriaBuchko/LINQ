using static LINQ.Task4;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("\nВиберіть завдання (1-8) або 0 для виходу:");
                Console.WriteLine("1. Завдання 1");
                Console.WriteLine("2. Завдання 2");
                Console.WriteLine("3. Завдання 3");
                Console.WriteLine("4. Завдання 4");
                Console.WriteLine("5. Завдання 5");
                Console.WriteLine("6. Завдання 6");
                Console.WriteLine("7. Завдання 7");
                Console.WriteLine("8. Завдання 8");
                Console.WriteLine("0. Вихід");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Menu.Task1();
                        break;
                    case "2":
                        Menu.Task2();
                        break;
                    case "3":
                        Menu.Task3();
                        break;
                    case "4":
                        Menu.Task4();
                        break;
                    case "5":
                        Menu.Task5();
                        break;
                    case "6":
                        Menu.Task6();
                        break;
                    case "7":
                        Menu.Task7();
                        break;
                    case "8":
                        Menu.Task8();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неправильний вибір. Спробуйте ще раз");
                        break;
                }
              
            }

        }
    }
}
