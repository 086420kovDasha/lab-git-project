using System;

namespace GitLabProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("    Лабораторна робота по Git");
            Console.WriteLine("         КАЛЬКУЛЯТОР");
            Console.WriteLine("======================================\n");

            Console.Write("Введіть перше число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Обчислення результатів
            double sum = num1 + num2;
            double difference = num1 - num2;
            double product = num1 * num2;

            Console.WriteLine("\n======================================");
            Console.WriteLine("           РЕЗУЛЬТАТИ:");
            Console.WriteLine("======================================");
            Console.WriteLine($"Сума:     {num1} + {num2} = {sum}");
            Console.WriteLine($"Різниця:  {num1} - {num2} = {difference}");
            Console.WriteLine($"Добуток:  {num1} × {num2} = {product}");

            if (num2 != 0)
            {
                double quotient = num1 / num2;
                Console.WriteLine($"Частка:   {num1} ÷ {num2} = {quotient:F2}");
            }
            else
            {
                Console.WriteLine("Частка:   ПОМИЛКА! Ділення на нуль неможливе!");
            }

            Console.WriteLine("======================================");
            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}