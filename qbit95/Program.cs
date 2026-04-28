using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<char> digits = new List<char>();
        string s;

        while ((s = Console.ReadLine()) != "#")
        {
            if (s.Length > 0 && char.IsDigit(s[0]))
                digits.Add(s[0]);
        }

        if (digits.Count == 0)
        {
            return;
        }

        digits.Sort();

        if (digits[0] == '0' && digits.Count > 1)
        {
            for (int i = 1; i < digits.Count; i++)
            {
                if (digits[i] != '0')
                {
                    char t = digits[0];
                    digits[0] = digits[i];
                    digits[i] = t;
                    break;
                }
            }
        }

        Console.WriteLine(new string(digits.ToArray()));
    }
}