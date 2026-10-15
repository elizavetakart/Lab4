using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №4 — Git";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Программа для работы с Git ===");
                Console.WriteLine();
                Console.WriteLine("1 — Поздороваться");
                Console.WriteLine("2 — Посчитать длину строки");
                Console.WriteLine("3 — Показать текущее время");
                Console.WriteLine("0 — Выход");
                Console.Write("Ваш выбор: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Greet();
                        break;
                    case "2":
                        CountLength();
                        break;
                    case "3":
                        ShowTime();
                        break;
                    case "0":
                        Console.WriteLine("До свидания!");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу...");
                Console.ReadKey();
            }
        }

        static void Greet()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Имя не может быть пустым!");
            }
            else
            {
                Console.WriteLine($"Привет, {name}! Добро пожаловать в Git.");
            }
        }

        static void CountLength()
        {
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();
            Console.WriteLine($"Длина строки: {text.Length} символов");
        }

        // НОВЫЙ МЕТОД — добавлен в ветке Addfunction
        static void ShowTime()
        {
            Console.WriteLine($"Текущее время: {DateTime.Now:HH:mm:ss}");
        }
    }
}