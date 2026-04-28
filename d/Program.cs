using System;

class Block1
{
    static int[] Input()
    {
        Console.Write("Кількість елементів: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"a[{i}] = ");
            a[i] = int.Parse(Console.ReadLine());
        }
        return a;
    }

    static int[] RandomFill(int n)
    {
        Random r = new Random();
        int[] a = new int[n];

        for (int i = 0; i < n; i++)
            a[i] = r.Next(-20, 21);

        return a;
    }

    static void Show(int[] a)
    {
        if (a.Length == 0)
        {
            Console.WriteLine("Масив порожній");
            return;
        }

        Console.Write("[ ");
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i]);
            if (i < a.Length - 1) Console.Write(", ");
        }
        Console.WriteLine(" ]");
    }

    static void RemoveByValue(ref int[] a, int key)
    {
        if (a.Length == 0)
        {
            Console.WriteLine("Масив порожній");
            return;
        }

        int pos = -1;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == key)
            {
                pos = i;
                break;
            }
        }

        if (pos == -1)
        {
            Console.WriteLine("Такого елемента нема");
            return;
        }

        int[] b = new int[a.Length - 1];

        for (int i = 0; i < pos; i++)
            b[i] = a[i];

        for (int i = pos + 1; i < a.Length; i++)
            b[i - 1] = a[i];

        a = b;
    }

    static void Main()
    {
        Console.WriteLine("1 - вручну, 2 - випадково");
        string ch = Console.ReadLine();

        int[] arr;

        if (ch == "1")
            arr = Input();
        else
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            arr = RandomFill(n);
        }

        Console.Write("Було: ");
        Show(arr);

        Console.Write("Що видалити: ");
        int key = int.Parse(Console.ReadLine());

        RemoveByValue(ref arr, key);

        Console.Write("Стало: ");
        Show(arr);
    }
}