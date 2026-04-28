using System;

class Program
{
    static void Main()
    {
        string s = "";

        while (true)
        {
            char c = Console.ReadLine()[0];
            if (c == '#') break;
            if (c >= '0' && c <= '9') s += c;
        }

        char[] arr = s.ToCharArray();
        Array.Sort(arr);
        Array.Reverse(arr);

        Console.WriteLine(new string(arr));
    }
}