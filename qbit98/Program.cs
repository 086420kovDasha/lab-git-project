using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        int digits = 0;

        for (int i = 0; i < 5; i++)
        {
            char c = Console.ReadLine()[0];

            if (c >= '0' && c <= '9')
            {
                sum += c - '0';
                digits++;
            }
        }

        if (digits > 0)
            Console.WriteLine(sum);
        else
            Console.WriteLine("No digits!");
    }
}