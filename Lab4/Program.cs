using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Введіть n: ");
        int n = int.Parse(Console.ReadLine());

        int[] values = { 10000, 20000, 50000, 100000, 200000 };

        foreach (int currentN in values)
        {
            Console.WriteLine("\n=== n = " + currentN + " ===");

            Measure("Версія 1: string +=", () =>
            {
                string s = "";
                for (int i = 1; i <= currentN; i++)
                {
                    s += i + " ";
                }
                return s;
            });

            Measure("Версія 2: string + у початок", () =>
            {
                string s = "";
                for (int i = currentN; i >= 1; i--)
                {
                    s = i + " " + s;
                }
                return s;
            });

            Measure("Версія 3: StringBuilder.Append", () =>
            {
                var sb = new StringBuilder();
                for (int i = 1; i <= currentN; i++)
                {
                    sb.Append(i).Append(" ");
                }
                return sb.ToString();
            });

            Measure("Версія 4: StringBuilder.Insert", () =>
            {
                var sb = new StringBuilder();
                for (int i = currentN; i >= 1; i--)
                {
                    sb.Insert(0, i + " ");
                }
                return sb.ToString();
            });
        }
    }

    static void Measure(string title, Func<string> action)
    {
        var sw = Stopwatch.StartNew();
        action();
        sw.Stop();
        Console.WriteLine(title + ": " + sw.ElapsedMilliseconds + " ms");
    }
}
