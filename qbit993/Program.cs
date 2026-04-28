using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            char c = Console.ReadLine()[0];

            if (char.IsDigit(c))
            {
                int d = c - '0';
                d = (d % 2 == 0) ? d + 1 : d - 1;
                Console.WriteLine(d);
            }
            else if (char.IsLetter(c))
            {
                char r = char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
                Console.WriteLine(r);
            }
            else
            {
                Console.WriteLine("@");
            }
        }
    }
}