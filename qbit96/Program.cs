using System;

class Program
{
    static void Main()
    {
        char start = char.Parse(Console.ReadLine());
        char end = char.Parse(Console.ReadLine());

        if (start > end)
        {
            char temp = start;
            start = end;
            end = temp;
        }

        for (char c = start; c <= end; c++)
        {
            Console.Write(char.ToUpper(c));
            Console.Write(char.ToLower(c));
            if (c != end) Console.Write(" ");
        }
    }
}
