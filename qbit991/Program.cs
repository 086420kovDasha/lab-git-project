using System;

class Program
{
    static void Main()
    {
        char min = (char)126;
        char max = (char)33;

        for (int i = 0; i < 5; i++)
        {
            char c = Console.ReadLine()[0];

            if (c < min) min = c;
            if (c > max) max = c;
        }

        Console.WriteLine($"{min} {(int)min}");
        Console.WriteLine($"{max} {(int)max}");
    }
}
