using System;

class Program
{
    static void Main()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();

        int max = Math.Max(s1.Length, s2.Length);

        for (int i = 0; i < max; i++)
        {
            char c1 = i < s1.Length ? s1[i] : ' ';

            Console.Write(c1 + " | ");

            if (i < s2.Length)
                Console.WriteLine(s2[i]);
            else
                Console.WriteLine();
        }
    }
}