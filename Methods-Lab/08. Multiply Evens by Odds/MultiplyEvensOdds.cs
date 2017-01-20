using System;

class MultiplyEvensOdds
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        if (num < 0)
        {
            num *= (-1);
        }

        Console.WriteLine(GetMultiplyOfEvensAndOdds(num));
    }

    static int GetMultiplyOfEvensAndOdds(int num)
    {
        int oddSum = GetOddsSum(num);
        int evenSum = GetEvenSum(num);
        return oddSum * evenSum;
    }

    static int GetEvenSum(int num)
    {
        int digit = 0;
        int evenSum = 0;
        while (num > 0)
        {
            digit = num % 10;
            if (digit % 2 == 0)
            {
                evenSum += digit;
            }
            num /= 10;
        }

        return evenSum;
    }

    static int GetOddsSum(int num)
    {
        int digit = 0;
        int oddSum = 0;
        while (num > 0)
        {
            digit = num % 10;
            if (digit % 2 == 1)
            {
                oddSum += digit;
            }
            num /= 10;
        }

        return oddSum;
    }
}

