using System;

class Block2
{
    static int[][] Input()
    {
        Console.Write("Кількість рядків: ");
        int n = int.Parse(Console.ReadLine());

        int[][] a = new int[n][];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Довжина рядка {i}: ");
            int len = int.Parse(Console.ReadLine());

            a[i] = new int[len];

            for (int j = 0; j < len; j++)
            {
                Console.Write($"a[{i}][{j}] = ");
                a[i][j] = int.Parse(Console.ReadLine());
            }
        }

        return a;
    }

    static int[][] RandomFill(int n)
    {
        Random r = new Random();
        int[][] a = new int[n][];

        for (int i = 0; i < n; i++)
        {
            int len = r.Next(1, 6);
            a[i] = new int[len];

            for (int j = 0; j < len; j++)
                a[i][j] = r.Next(-10, 11);
        }

        return a;
    }

    static void Show(int[][] a)
    {
        if (a.Length == 0)
        {
            Console.WriteLine("Порожній масив");
            return;
        }

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write($"[{i}]: ");
            Console.Write("[ ");

            for (int j = 0; j < a[i].Length; j++)
            {
                Console.Write(a[i][j]);
                if (j < a[i].Length - 1) Console.Write(", ");
            }

            Console.WriteLine(" ]");
        }
    }

    static void RemoveEvenRows(ref int[][] a)
    {
        if (a.Length == 0)
            return;

        int newSize = a.Length / 2;

        if (newSize == 0)
        {
            a = new int[0][];
            return;
        }

        int[][] b = new int[newSize][];

        int k = 0;

        for (int i = 1; i < a.Length; i += 2)
        {
            b[k] = a[i]; 
            k++;
        }

        a = b;
    }

    static void Main()
    {
        Console.WriteLine("1 - вручну, 2 - випадково");
        string ch = Console.ReadLine();

        int[][] arr;

        if (ch == "1")
            arr = Input();
        else
        {
            Console.Write("Кількість рядків: ");
            int n = int.Parse(Console.ReadLine());
            arr = RandomFill(n);
        }

        Console.WriteLine("Було:");
        Show(arr);

        RemoveEvenRows(ref arr);

        Console.WriteLine("Стало:");
        Show(arr);
    }
}