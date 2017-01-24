using System;
using System.Numerics;

class FactorialTrailingZeroes
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(GetLastZerosFromFactorial(num));
    }

    static int GetLastZerosFromFactorial(int num)
    {
        BigInteger factorial = 1;

        for (int i = 1; i <= num; i++)
        {
            factorial = factorial * i;
        }

        int countZero = 0;

        while (factorial > 0)
        {
            BigInteger digit = 0;
            digit = factorial % 10;

            if (digit != 0)
            {
                break;
            }
            else
            {
                countZero++;
            }
            factorial = factorial / 10;
        }

        return countZero;
    }
}

