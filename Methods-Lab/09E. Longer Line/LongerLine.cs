using System;
using System.Collections.Generic;
using System.Linq;

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

        Console.WriteLine("(" + String.Join(", ",
            GetLongerLine(pointX1, pointY1, pointX2, pointY2, pointX3, pointY3, pointX4, pointY4) + ")"));
        GetNearestToZeroPoint(pointX1, pointY1, pointX2, pointY2, pointX3, pointY3, pointX4, pointY4);
    }

    static double[] GetLongerLine(
        double pointX1,
        double pointY1,
        double pointX2,
        double pointY2,
        double pointX3,
        double pointY3,
        double pointX4,
        double pointY4)
    {
        double[] points = new double[2];

        double firstLine = Math.Abs(Math.Sqrt(Math.Pow(pointX1, 2)) + Math.Pow(pointY2, 2) - 
            (Math.Sqrt(Math.Pow(pointX2, 2)) + Math.Pow(pointY2,2)));
        double secondLine = Math.Abs(Math.Sqrt(Math.Pow(pointX1, 2)) + Math.Pow(pointY2, 2) -
           (Math.Sqrt(Math.Pow(pointX2, 2)) + Math.Pow(pointY2, 2)));

        if (firstLine > secondLine)
        {
            points[]
        }
    }
    static double GetNearestToZeroPoint(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    {
        double[] points = new double[2];

        if (Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)) < Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)))
        {
            points[0] = x1;
            points[1] = y1;
            return points;
        }
        else
        {
            points[0] = x2;
            points[1] = y2;
            return points;
        }
    }
}

