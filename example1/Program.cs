using System;

class Program
{
    static void Main()
    {
        Console.Write("введіть кількість елементів: ");
        int n = int.Parse(Console.ReadLine());

        if (n % 2 != 0)
        {
            Console.WriteLine("иди нахуй");
            return;
        }

        int[] arr = new int[n];

        Console.WriteLine("введіть числа:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Array.Sort(arr);

        Console.WriteLine("\nвідсортований масив:");
        foreach (int num in arr)
            Console.Write(num + " ");

        Console.WriteLine("\n\nпари:");

        for (int i = 0; i < n; i += 2)
        {
            if (arr[i] != arr[i + 1])
            {
                Console.WriteLine("неможливо");
                return;
            }

            Console.WriteLine($"{arr[i]} {arr[i + 1]}");
        }
    }
}
