using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        GetFibonacciNumber(n);
    }

    static void GetFibonacciNumber(int n)
    {
        int first = 1;
        int second = 1;
        int third = 0;

        if (n == 0 || n == 1)
        {
            Console.WriteLine(1);
        }
        else
        {
            for (int i = 1; i < n; i++)
            {
                third = first + second;
                first = second;
                second = third;
            }
            Console.WriteLine(second);
        }
    }
}

