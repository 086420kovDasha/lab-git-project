using System;

class Program
{
    const int SIZE = 8;

    static bool ValidateBinary(string s)
    {
        if (s.Length != SIZE)
            return false;
        foreach (char c in s)
        {
            if (c != '0' && c != '1')
                return false;
        }
        return true;
    }

    static string BinaryAdd(string a, string b)
    {
        char[] result = new char[SIZE + 1];
        int carry = 0;
        int pos = SIZE;

        for (int i = SIZE - 1; i >= 0; i--)
        {
            int sum = (a[i] - '0') + (b[i] - '0') + carry;
            result[pos] = (char)('0' + (sum % 2));
            carry = sum / 2;
            pos--;
        }

        if (carry == 1)
        {
            result[0] = '1';
            return new string(result);
        }
        return new string(result, 1, SIZE);
    }

    static void Main()
    {
        string num1, num2;

        do
        {
            Console.Write("введiть перше бiнарне число (8 символiв): ");
            num1 = Console.ReadLine();
            if (!ValidateBinary(num1))
                Console.WriteLine("помилка введiть рiвно 8 символiв (0 або 1).\n");
        }
        while (!ValidateBinary(num1));

        do
        {
            Console.Write("введiть друге бiнарне число (8 символiв): ");
            num2 = Console.ReadLine();
            if (!ValidateBinary(num2))
                Console.WriteLine("помилка введiть рiвно 8 символiв (0 або 1).\n");
        }
        while (!ValidateBinary(num2));

        string resultBin = BinaryAdd(num1, num2);
        int dec1 = Convert.ToInt32(num1, 2);
        int dec2 = Convert.ToInt32(num2, 2);
        int decSum = dec1 + dec2;

        Console.WriteLine("перше число: " + num1 + " = " + dec1 + " (10)");
        Console.WriteLine("друге число: " + num2 + " = " + dec2 + " (10)");
        Console.WriteLine("сума: " + resultBin + " = " + decSum + " (10)");
    }
}