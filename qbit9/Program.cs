using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        int L = s.Length;

        int idx = 0;

        while (idx < L)
        {
            char a = s[idx];
            char b = (idx + 1 < L) ? s[idx + 1] : s[(idx + 1) % L];
            char c = (idx + 2 < L) ? s[idx + 2] : s[(idx + 2) % L];

            Console.WriteLine($"{a}{b}{c}");
            idx += 3;
        }
    }
}

