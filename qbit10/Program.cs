using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        int L = s.Length;
        int left = 0, right = L - 1, supp = 0;

        while (left <= right)
        {
            char a = s[left++];
            char b = (left <= right) ? s[left++] : s[supp++];
            char c = (left <= right) ? s[right--] : s[supp++];

            Console.WriteLine($"{a}{b}{c}");
        }
    }
}