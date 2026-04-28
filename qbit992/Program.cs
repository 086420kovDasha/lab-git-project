using System;
using System.Linq;

class Program
{
    static void Main()
    {
        char[] a = new char[5];
        for (int i = 0; i < 5; i++)
            a[i] = Console.ReadLine()[0];

        foreach (char c in a.OrderBy(x => (int)x))
            Console.WriteLine($"{c} {(int)c}");
    }
}