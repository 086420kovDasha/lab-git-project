using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        char c = input[0];

        char next = (char)(c + 1);
        char prev = (char)(c - 1);

        Console.WriteLine($"The next char for '{c}' ({(int)c}) is '{next}' ({(int)next}).");
        Console.WriteLine($"The previous char for '{c}' ({(int)c}) is '{prev}' ({(int)prev}).");
    }
}
