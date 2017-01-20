using System;
class MaxMethod
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        Console.WriteLine(GetMax(first, second, third));
    }

    static int GetMax(int first, int second, int third)
    {
        int max = 0;
        max = Math.Max(first, second);
        if (max < third)
            max = third;
        return max;
    }
}

