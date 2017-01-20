using System;

class MathPower
{
    static void Main()
    {
        double num = double.Parse(Console.ReadLine());
        double powerNum = double.Parse(Console.ReadLine());

        Console.WriteLine(CalculateRaisedNumbers(num, powerNum));
    }

    static decimal CalculateRaisedNumbers(double num, double powerNum)
    {
        decimal result = 1;
        //return (decimal)(Math.Pow(num, powerNum));
        while (powerNum-- > 0)
        {
            result *= (decimal)num;
        }

        return result;
    }
}

