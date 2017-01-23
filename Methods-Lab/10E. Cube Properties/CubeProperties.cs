using System;

class CubeProperties
{
    static void Main()
    {
        double cubeSide = double.Parse(Console.ReadLine());
        string parameters = Console.ReadLine();

        if (parameters == "face")
            PrintFaceOfCube(cubeSide);
        else if (parameters == "space")
            PrintSpaceOfCube(cubeSide);
        else if (parameters == "volume")
            PrintVolumeOfCube(cubeSide);
        else
            PrintAreaOfCube(cubeSide);
    }

    static void PrintAreaOfCube(double cubeSide)
    {
        Console.WriteLine("{0:f2}", 6 * (Math.Pow(cubeSide, 2)));
    }

    static void PrintVolumeOfCube(double cubeSide)
    {
        Console.WriteLine("{0:f2}", Math.Pow(cubeSide, 3));
    }

    static void PrintSpaceOfCube(double cubeSide)
    {
        Console.WriteLine("{0:f2}", Math.Sqrt(3 * (Math.Pow(cubeSide, 2))));
    }

    static void PrintFaceOfCube(double cubeSide)
    {
        Console.WriteLine("{0:f2}", Math.Sqrt(2 * (Math.Pow(cubeSide, 2))));
    }
}

