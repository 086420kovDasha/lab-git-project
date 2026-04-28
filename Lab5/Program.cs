using System;

class Program
{
    static void Main()
    {
        int[] array = ChooseInputMethod();
        if (array == null || array.Length == 0)
        {
            Console.WriteLine("Масив не створено. Програма завершується.");
            return;
        }

        Console.WriteLine("Масив:");
        PrintArray(array);

        int sum = SumBetweenMaxMin(array);
        if (sum != int.MinValue)
        {
            Console.WriteLine("Сума елементів між першим максимумом та мінімумом: " + sum);
        }
    }

    static int[] ChooseInputMethod()
    {
        Console.WriteLine("Оберіть спосіб заповнення масиву:");
        Console.WriteLine("1 - випадково");
        Console.WriteLine("2 - вручну (по рядках)");
        Console.WriteLine("3 - вручну (одним рядком)");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Введіть кількість елементів: ");
                int n1 = int.Parse(Console.ReadLine());
                return FillArrayRandom(n1);

            case "2":
                Console.Write("Введіть кількість елементів: ");
                int n2 = int.Parse(Console.ReadLine());
                return FillArrayManualSeparate(n2);

            case "3":
                return FillArrayManualSingleLine();

            default:
                Console.WriteLine("Невірний вибір. Масив не буде створено.");
                return null;
        }
    }

    static int[] FillArrayRandom(int n)
    {
        int[] arr = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            arr[i] = rnd.Next(-100, 101);
        }
        return arr;
    }

    static int[] FillArrayManualSeparate(int n)
    {
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Елемент " + i + ": ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        return arr;
    }

    static int[] FillArrayManualSingleLine()
    {
        Console.WriteLine("Введіть елементи масиву через пробіл або табуляцію:");
        string line = Console.ReadLine();
        string[] parts = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        int[] arr = new int[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            arr[i] = int.Parse(parts[i]);
        }
        return arr;
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    static int SumBetweenMaxMin(int[] arr)
    {
        if (arr.Length < 2)
        {
            Console.WriteLine("Масив занадто короткий для обчислення.");
            return int.MinValue;
        }

        int max = arr[0];
        int min = arr[0];
        int maxIndex = 0;
        int minIndex = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                maxIndex = i;
            }
            if (arr[i] < min)
            {
                min = arr[i];
                minIndex = i;
            }
        }

        int start = Math.Min(maxIndex, minIndex) + 1;
        int end = Math.Max(maxIndex, minIndex) - 1;

        if (start > end)
        {
            Console.WriteLine("Між максимальним і мінімальним елементами немає елементів.");
            return 0;
        }

        int sum = 0;
        for (int i = start; i <= end; i++)
        {
            sum += arr[i];
        }

        return sum;
    }
}