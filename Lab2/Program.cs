using System;
class Program
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("Виберіть задачу:");
            Console.WriteLine("1 — Block 6: Мінімальний елемент");
            Console.WriteLine("2 — Block 33: Кількість кратних K1 і не кратних K2");
            Console.WriteLine("3 — Block 53: P = a * (a+1) * ... * (a+n-1)");
            Console.WriteLine("0 — Вихід");
            Console.Write("Ваш вибір: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (choice)
            {
                case 1:
                    DoBlock_6();
                    break;
                case 2:
                    DoBlock_33();
                    break;
                case 3:
                    DoBlock_53();
                    break;
                case 0:
                    Console.WriteLine("Вихід з програми...");
                    break;
                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }
            Console.WriteLine();
        }
        while (choice != 0);
    }

    static void DoBlock_6()
    {
        Console.WriteLine("Block 6: Мінімальний елемент послідовності");
        Console.Write("Введіть кількість елементів n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введіть число: ");
        int min = int.Parse(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            Console.Write("Введіть число: ");
            int x = int.Parse(Console.ReadLine());
            if (x < min)
                min = x;
        }
        Console.WriteLine("Мінімальний елемент = " + min);
    }

    static void DoBlock_33()
    {
        Console.WriteLine("Block 33: Кількість елементів кратних K1 і не кратних K2");
        Console.Write("Введіть K1: ");
        int K1 = int.Parse(Console.ReadLine());
        Console.Write("Введіть K2: ");
        int K2 = int.Parse(Console.ReadLine());
        int count = 0;
        Console.Write("Введіть число (0 — кінець послідовності): ");
        int x = int.Parse(Console.ReadLine());
        while (x != 0)
        {
            if (x % K1 == 0 && x % K2 != 0)
                count++;
            Console.Write("Введіть число (0 — кінець послідовності): ");
            x = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Кількість елементів = " + count);
    }

    static void DoBlock_53()
    {
        Console.WriteLine("Block 53: P = a * (a+1) * ... * (a+n-1)");
        Console.Write("Введіть a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введіть n: ");
        int n = int.Parse(Console.ReadLine());
        long P = 1;
        int i = 0;
        do
        {
            P *= (a + i);
            i++;
        } while (i < n);
        Console.WriteLine("P = " + P);
    }
}