using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        int L = s.Length;

        int left = 0;
        int right = L - 1;

        while (left < right)
        {
            Console.WriteLine($"{s[left]}{s[right]}");
            left++;
            right--;
        }

        if (left == right)
            Console.WriteLine($"{s[left]}{s[left]}");
    }
}

