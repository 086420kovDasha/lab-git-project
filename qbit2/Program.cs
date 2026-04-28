using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string message = Console.ReadLine();

        int[] freq = new int[128];

        for (int i = 0; i < n; i++)
        {
            char ch = message[i];
            freq[ch]++;
        }

        int maxCount = 0;
        int asciiCode = 0;

        for (int i = 32; i <= 127; i++)
        {
            if (freq[i] > maxCount)
            {
                maxCount = freq[i];
                asciiCode = i;
            }
        }

        Console.WriteLine(asciiCode);
    }
}
