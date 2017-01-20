using System;


class CenterPoint
{
    static void Main()
    {
        double pointX1 = double.Parse(Console.ReadLine());
        double pointY1 = double.Parse(Console.ReadLine());
        double pointX2 = double.Parse(Console.ReadLine());
        double pointY2 = double.Parse(Console.ReadLine());

        Console.WriteLine("(" + String.Join(", ", GetNearestPoint(pointX1, pointY1, pointX2, pointY2)) + ")");
    }

    static double[] GetNearestPoint(double x1, double y1, double x2, double y2)
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
