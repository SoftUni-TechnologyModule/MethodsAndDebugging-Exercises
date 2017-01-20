using System;

class NumbersReversedOrder
{
    static void Main()
    {
        string num = Console.ReadLine();    

        PrintReversedNumber(num);
    }

    static void PrintReversedNumber(string num)
    {
        char[] reverse = num.ToCharArray();

        for (int i = reverse.Length - 1; i >= 0; i--)
        {
            Console.Write(reverse[i]);
        }

        Console.WriteLine();   
    }
}

