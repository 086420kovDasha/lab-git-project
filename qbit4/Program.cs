using System;

class Program
{
    static void Main()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();

        if (s1 == s2)
        {
            Console.WriteLine("Strings are the same");
            return;
        }

        if (s1.Length != s2.Length)
        {
            if (s1.Length > s2.Length)
                Console.WriteLine(s1 + "\n" + s2);
            else
                Console.WriteLine(s2 + "\n" + s1);
        }
        else
        {
            if (string.Compare(s1, s2) > 0)
                Console.WriteLine(s1 + "\n" + s2);
            else
                Console.WriteLine(s2 + "\n" + s1);
        }
    }
}