using System;

class Program
{
    static void Main()
    {
        char c = Console.ReadLine()[0];

        if (c >= 65 && c <= 90)
            c = (char)(c + 32);
        else if (c >= 97 && c <= 122)
            c = (char)(c - 32);

        Console.WriteLine(c);
    }
}
