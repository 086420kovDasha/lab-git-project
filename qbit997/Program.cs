using System;

class Program
{
    static void Main()
    {
        string S = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        string[] parts = Console.ReadLine().Split();

        string result = "";

        for (int i = 0; i < n; i++)
        {
            int idx = int.Parse(parts[i]) - 1;
            result += S[idx];
        }

        Console.WriteLine(result);
    }
}