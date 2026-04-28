using System;

class Program
{
    static void Main()
    {
        string S = Console.ReadLine();

        for (int i = S.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(S[i]);
        }
    }
}
