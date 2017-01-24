using System;
using System.Numerics;

class Factorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(GetFactorial(n)); 
        
    }

    static BigInteger GetFactorial(int num)
    {
        BigInteger factorial = 1;

        for (int i = 1; i <= num; i++)
        {

            factorial = factorial * i;
        }

        return factorial;
    }
}

