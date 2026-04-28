using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Введіть рядок слів: ");
        string text = Console.ReadLine();

        Console.Write("Введіть шаблон: ");
        string patternInput = Console.ReadLine();

        string regexPattern = "^" + Regex.Escape(patternInput)
                                        .Replace("\\*", ".*")
                                        .Replace("\\?", ".") + "$";

        Regex regex = new Regex(regexPattern);

        string[] words = text.Split(' ', '\t');

        for (int i = 0; i < words.Length; i++)
        {
            if (!string.IsNullOrEmpty(words[i]) && regex.IsMatch(words[i]))
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
