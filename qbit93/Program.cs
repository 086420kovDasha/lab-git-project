using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();

        int[] a = new int[n];
        for (int i = 0; i < n; i++)
            a[i] = (int)s[i];

        Console.WriteLine(string.Join(" ", a));
    }
}