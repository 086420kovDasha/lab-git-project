using System;
using System.Globalization;

class Program
{
    static void QuickSort(double[] arr, int left, int right)
    {
        int i = left;
        int j = right;
        double pivot = arr[(left + right) / 2];

        while (i <= j)
        {
            while (arr[i] < pivot) i++;
            while (arr[j] > pivot) j--;

            if (i <= j)
            {
                double temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
        }

        if (left < j) QuickSort(arr, left, j);
        if (i < right) QuickSort(arr, i, right);
    }

    static void Main()
    {
        double[] towers = Array.ConvertAll(Console.ReadLine().Split(' '),double.Parse);
        if (towers.Length <= 1)
        {
            Console.WriteLine(0);
            return;
        }
        double r = double.Parse(Console.ReadLine());
        QuickSort(towers, 0, towers.Length - 1);
        double uncovered = 0;
        double currentRight = towers[0] + r;

        for (int i = 1; i < towers.Length; i++)
        {
            double nextLeft = towers[i] - r;
            if (nextLeft > currentRight)
                uncovered += nextLeft - currentRight;

            currentRight = towers[i] + r;
        }
        Console.WriteLine(uncovered);
    }
}