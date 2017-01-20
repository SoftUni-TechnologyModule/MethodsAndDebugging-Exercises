using System;

class PrimeChecker
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        Console.WriteLine(IsPrimeNumber(n));
    }

    static bool IsPrimeNumber(long n)
    {
        bool prime = true;

        if (n == 0 || n == 1)
            prime = false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }
        }
        return prime;
    }
}

