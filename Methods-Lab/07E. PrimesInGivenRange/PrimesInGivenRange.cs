using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());

        Console.WriteLine(string.Join(", ", FindPrimesInRange(first, second)));
    }

    static List<int> FindPrimesInRange(int first, int second)
    {
        List<int> primes = new List<int>();
        if (first < 2)        
            first = 2;    

        for (int i = first; i <= second; i++)
        {
            bool isPrime = true;
            for (int j = 2; (j * j) <= i; j++)
            {
                if ((i % j) == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)            
                primes.Add(i);            
        }

        return primes;
    }
}

