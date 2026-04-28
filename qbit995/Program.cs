using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<char, int> count = new Dictionary<char, int>();

        while (true)
        {
            string s = Console.ReadLine();
            if (s == null) return;
            if (s == "#") break;

            if (s.Length > 0)
            {
                char ch = char.ToUpper(s[0]);
                if (ch >= 33 && ch <= 126)
                {
                    if (!count.ContainsKey(ch)) count[ch] = 0;
                    count[ch]++;
                }
            }
        }

        bool pascal = Check(new (char, int)[] {
            ('P',1), ('A',2), ('S',1), ('C',1), ('L',1)
        }, count);

        bool python = Check(new (char, int)[] {
            ('P',1), ('Y',1), ('T',1), ('H',1), ('O',1), ('N',1)
        }, count);

        bool cpp = Check(new (char, int)[] {
            ('C',1), ('P',2)
        }, count);

        bool java = Check(new (char, int)[] {
            ('J',1), ('A',2), ('V',1)
        }, count);

        Console.WriteLine(pascal ? "YES" : "NO");
        Console.WriteLine(python ? "YES" : "NO");
        Console.WriteLine(cpp ? "YES" : "NO");
        Console.WriteLine(java ? "YES" : "NO");
    }

    static bool Check((char letter, int req)[] need, Dictionary<char, int> cnt)
    {
        foreach (var x in need)
            if (!cnt.ContainsKey(x.letter) || cnt[x.letter] < x.req)
                return false;
        return true;
    }
}
