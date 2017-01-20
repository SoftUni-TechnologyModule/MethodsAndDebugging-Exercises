using System;
class PrintingTriangle
{
    static void PrintTriangle(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int r = 1; r <= i; r++)
            {
                Console.Write(r + " ");
            }
            Console.WriteLine();
        }
        for (int i = 1; i < n; i++)
        {
            for (int r = 1; r <= n - i; r++)
            {
                Console.Write(r + " ");
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintTriangle(n);
    }
}

