using System;
using System.Text;
using System.Diagnostics;
class Program
{
    static void Main()
    {
        Console.Write("Введіть число n: ");
        int n = int.Parse(Console.ReadLine());

        string result1 = "";
        Stopwatch sw1 = Stopwatch.StartNew();
        for (int i = 1; i <= n; i++)
        {
            result1 += i + " ";
        }
        result1 = result1.TrimEnd();
        sw1.Stop();
        Console.WriteLine($"Версія 1 (string +=, 1→n): {sw1.ElapsedMilliseconds} мс");

        string result2 = "";
        Stopwatch sw2 = Stopwatch.StartNew();
        for (int i = n; i >= 1; i--)
        {
            result2 = i + " " + result2;
        }
        result2 = result2.TrimEnd();
        sw2.Stop();
        Console.WriteLine($"Версія 2 (string + на початок, n→1): {sw2.ElapsedMilliseconds} мс");

        StringBuilder sb3 = new StringBuilder();
        Stopwatch sw3 = Stopwatch.StartNew();
        for (int i = 1; i <= n; i++)
        {
            sb3.Append(i).Append(" ");
        }
        sb3.Length--;
        sw3.Stop();
        Console.WriteLine($"Версія 3 (StringBuilder.Append, 1→n): {sw3.ElapsedMilliseconds} мс");

        StringBuilder sb4 = new StringBuilder();
        Stopwatch sw4 = Stopwatch.StartNew();
        for (int i = n; i >= 1; i--)
        {
            sb4.Insert(0, i + " ");
        }
        sb4.Length--;
        sw4.Stop();
        Console.WriteLine($"Версія 4 (StringBuilder.Insert, n→1): {sw4.ElapsedMilliseconds} мс");
    }
}