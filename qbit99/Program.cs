using System;

class Program
{
    static void Main()
    {
        int count = 0;
        string result = "";

        for (int i = 0; i < 5; i++)
        {
            char c = Console.ReadLine()[0];

            if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
            {
                count++;
                result += c;
            }
        }

        if (count > 0)
        {
            Console.WriteLine(count);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("No english chars!");
        }
    }
}

