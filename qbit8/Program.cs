using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        int L = s.Length;

        int i = 0;
        while (i + 1 < L)
        {
            Console.WriteLine($"{s[i]}{s[i + 1]}");
            i += 2;
        }

        if (i < L)
            Console.WriteLine($"{s[L - 1]}{s[L - 1]}");
    }
}