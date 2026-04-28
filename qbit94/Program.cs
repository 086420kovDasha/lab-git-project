using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] parts = Console.ReadLine().Split();

        char[] result = new char[n];
        for (int i = 0; i < n; i++)
            result[i] = (char)int.Parse(parts[i]);

        Console.WriteLine(new string(result));
    }
}
