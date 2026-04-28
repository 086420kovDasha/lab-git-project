using System;
class Program
{
    static void Main()
    {
        Console.Write("Введіть рядок: ");
        string text = Console.ReadLine();

        int balance = 0;

        foreach (char c in text)
        {
            if (c == '(')
            {
                balance++;
            }
            else if (c == ')')
            {
                balance--;
                if (balance < 0)
                {
                    Console.WriteLine("Дужки розставлені неправильно");
                    return;
                }
            }
        }

        if (balance == 0)
        {
            Console.WriteLine("Дужки розставлені правильно");
        }
        else
        {
            Console.WriteLine("Дужки розставлені неправильно");
        }
    }
}
