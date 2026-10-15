using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №4 — Git";
            Console.WriteLine("=== Программа для работы с Git ===");
            Console.WriteLine();

            Greet();

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
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
    }
}