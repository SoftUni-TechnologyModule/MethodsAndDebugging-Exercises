using System;

class LongerLine
{
    static void Main()
    {
        double pointX1 = double.Parse(Console.ReadLine());
        double pointY1 = double.Parse(Console.ReadLine());
        double pointX2 = double.Parse(Console.ReadLine());
        double pointY2 = double.Parse(Console.ReadLine());
        double pointX3 = double.Parse(Console.ReadLine());
        double pointY3 = double.Parse(Console.ReadLine());
        double pointX4 = double.Parse(Console.ReadLine());
        double pointY4 = double.Parse(Console.ReadLine());

        PrintLongestLine(pointX1, pointY1, pointX2, pointY2, pointX3, pointY3, pointX4, pointY4);
    }

    static double GetFirstLine(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    }

    static double GetSecondLine(double x3, double y3, double x4, double y4)
    {
        return Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
    }

    static double GetNearestToCenterPoint(double x, double y)
    {
        return Math.Sqrt(Math.Pow((0 - x), 2) + Math.Pow((0 - y), 2));
    }

    static void PrintNearestToCenterPoint(double x1, double y1, double x2, double y2)
    {
        if (GetNearestToCenterPoint(x1, y1) > GetNearestToCenterPoint(x2, y2))
        {
            Console.Write("(" + x2 + ", " + y2 + ")");
            Console.WriteLine("(" + x1 + ", " + y1 + ")");
        }
        else
        {
            Console.Write("(" + x1 + ", " + y1 + ")");
            Console.WriteLine("(" + x2 + ", " + y2 + ")");
        }
    }

    static void PrintLongestLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    {
        if (GetFirstLine(x1, y1, x2, y2) >= GetSecondLine(x3, y3, x4, y4))
        {
            PrintNearestToCenterPoint(x1, y1, x2, y2);
        }
        else
        {
            PrintNearestToCenterPoint(x3, y3, x4, y4);
        }
    }
}

