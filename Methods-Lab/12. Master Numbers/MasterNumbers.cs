using System;
using System.Collections.Generic;

class MasterNumbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i < num; i++)
        {
            if (IsPalindromes(i) && SumOfDigits(i) && ContainsEvenDigits(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool ContainsEvenDigits(int num)
    {
        bool result = false;
        int digit = 0;

        while (num > 0)
        {
            digit = num % 10;
            if (digit % 2 == 0)
            {
                result = true;
                break;
            }

            num = num / 10;
        }

        return result;
    }

    static bool SumOfDigits(int num)
    {
        bool result = false;
        int digit = 0;
        int sum = 0;
        while (num > 0)
        {
            digit = num % 10;
            sum += digit;
            num = num / 10;
        }

        if (sum % 7 == 0)
        {
            result = true;
        }

        return result;
    }

    static bool IsPalindromes(int num)
    {
        bool result = false;
        int n = num;
        int digit = 0;
        int reversed = 0;
        while (num > 0)
        {
            digit = num % 10;
            reversed = reversed * 10 + digit;
            num = num / 10;
        }

        if (n == reversed)
        {
            result = true;
        }

        return result;
    }
}

