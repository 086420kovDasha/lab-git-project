using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        int L = s.Length;

        for (int k = 2; k <= 5; k += (k == 2 ? 1 : 2))
        {
            for (int i = k - 1; i < L; i += k)
            {
                Console.Write(s[i]);
                if (i + k < L) Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}