using System;
class DrawFilledSquare
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        PrintTopBottomPart(n);
        PrintMiddlePart(n);
        PrintTopBottomPart(n);
    }
    static void PrintTopBottomPart(int n)
    {
        Console.WriteLine("{0}", new string('-', n * 2));
    }
    static void PrintMiddlePart(int n)
    {
        for (int i = 1; i <= n - 2; i++)
        {
            Console.Write("-");
            for (int r = 1; r <= n - 1; r++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }
}

