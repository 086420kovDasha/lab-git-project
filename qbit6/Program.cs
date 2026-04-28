using System;

class Program
{
    static void Main()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        string s3 = Console.ReadLine();

        int max = Math.Max(Math.Max(s1.Length, s2.Length), s3.Length);

        for (int i = 0; i < max; i++)
        {
            char c1 = i < s1.Length ? s1[i] : ' ';
            char c2 = i < s2.Length ? s2[i] : ' ';

            Console.Write(c1 + " | " + c2 + " | ");

            if (i < s3.Length)
                Console.WriteLine(s3[i]);
            else
                Console.WriteLine();
        }
    }
}
