using System;

class GeometryCalculator
{
    static void Main()
    {
        string figureType = Console.ReadLine();

        if (figureType == "triangle")
        {
            double baseSide = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", GetTriangleArea(baseSide, height));
        }
        else if (figureType == "square")
        {
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", GetSquareArea(side));
        }
        else if (figureType == "rectangle")
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", GetRectangleArea(width, height));
        }
        else
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", GetCircleArea(radius));
        }
    }

    private static double GetCircleArea(double radius)
    {
        double circleArea = Math.PI * (Math.Pow(radius, 2));
        return circleArea;
    }

    static double GetRectangleArea(double width, double height)
    {
        double rectangleArea = width * height;
        return rectangleArea;
    }

    static double GetSquareArea(double side)
    {
        double squareArea = side = Math.Pow(side, 2);
        return squareArea;
    }

    static double GetTriangleArea(double baseSide, double height)
    {
        double triangleArea = (baseSide / 2) * height;
        return triangleArea;
    }
}

