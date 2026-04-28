using System;
using System.Text.RegularExpressions;

class Program
{
    static string[] units = { "", "один", "два", "три", "чотири", "п'ять", "шість", "сім", "вісім", "дев'ять" };
    static string[] unitsFemale = { "", "одна", "дві", "три", "чотири", "п'ять", "шість", "сім", "вісім", "дев'ять" };
    static string[] teens = { "десять", "одинадцять", "дванадцять", "тринадцять", "чотирнадцять", "п'ятнадцять", "шістнадцять", "сімнадцять", "вісімнадцять", "дев'ятнадцять" };
    static string[] tens = { "", "", "двадцять", "тридцять", "сорок", "п'ятдесят", "шістдесят", "сімдесят", "вісімдесят", "дев'яносто" };
    static string[] hundreds = { "", "сто", "двісті", "триста", "чотириста", "п'ятсот", "шістсот", "сімсот", "вісімсот", "дев'ятсот" };

    static string NumberToWords(int n, bool female)
    {
        if (n == 0) return "нуль";
        string result = "";

        if (n / 1000000 > 0)
        {
            result += NumberToWords(n / 1000000, false) + " мільйон" + ((n / 1000000 % 10 != 1) ? "и " : " ");
            n %= 1000000;
        }
        if (n / 1000 > 0)
        {
            result += NumberToWords(n / 1000, true) + " тисяча" + ((n / 1000 % 10 != 1) ? "і " : " ");
            n %= 1000;
        }
        if (n / 100 > 0)
        {
            result += hundreds[n / 100] + " ";
            n %= 100;
        }
        if (n >= 10 && n <= 19)
        {
            result += teens[n - 10] + " ";
            return result.Trim();
        }
        if (n >= 20)
        {
            result += tens[n / 10] + " ";
            n %= 10;
        }
        if (n > 0)
        {
            result += (female ? unitsFemale[n] : units[n]) + " ";
        }
        return result.Trim();
    }

    static string GetUnitWord(int number, string unit)
    {
        if (unit == "м")
        {
            if (number % 10 == 1 && number % 100 != 11) return "метр";
            else if (number % 10 >= 2 && number % 10 <= 4 && (number % 100 < 10 || number % 100 >= 20)) return "метри";
            else return "метрів";
        }
        else if (unit == "грн")
        {
            if (number % 10 == 1 && number % 100 != 11) return "гривня";
            else if (number % 10 >= 2 && number % 10 <= 4 && (number % 100 < 10 || number % 100 >= 20)) return "гривні";
            else return "гривень";
        }
        return unit;
    }

    static void Main()
    {
        Console.Write("Введіть рядок: ");
        string text = Console.ReadLine();

        string pattern = @"(\d+)\s*(м|грн)";
        Regex regex = new Regex(pattern);
        string result = regex.Replace(text, match =>
        {
            int number = int.Parse(match.Groups[1].Value);
            string unit = match.Groups[2].Value;
            bool female = unit == "грн";
            string words = NumberToWords(number, female);
            string unitWord = GetUnitWord(number, unit);
            return words + " " + unitWord;
        });

        Console.WriteLine(result);
    }
}
