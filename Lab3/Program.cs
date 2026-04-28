using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть m: ");
        if (!int.TryParse(Console.ReadLine(), out int m))
        {
            Console.WriteLine("Помилка введення m");
            return;
        }

        Console.Write("Введіть n: ");
        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Помилка введення n");
            return;
        }

        if (m < 0 || n < 0 || n > m)
        {
            Console.WriteLine("Некоректні вхідні дані");
            return;
        }

        long c1 = CalcCNonRec(m, n);
        long c2 = CalcCRec(m, n);

        Console.WriteLine($"C({m},{n}) за формулою = {c1}");
        Console.WriteLine($"C({m},{n}) рекурсивно = {c2}");
    }

    static long CalcFactorial(int n)
    {
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    static long CalcCNonRec(int m, int n)
    {
        return CalcFactorial(m) /
               (CalcFactorial(n) * CalcFactorial(m - n));
    }

    static long CalcCRec(int m, int n)
    {
        if (n == 0 || n == m)
        {
            return 1;
        }

        return CalcCRec(m - 1, n - 1) + CalcCRec(m - 1, n);
    }
}
