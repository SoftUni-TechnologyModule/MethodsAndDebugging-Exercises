using System;
class Program
{
    static void Main()
    {
        int numPrices = int.Parse(Console.ReadLine());
        double range = double.Parse(Console.ReadLine());
        double last = double.Parse(Console.ReadLine());

        for (int i = 0; i < numPrices - 1; i++)
        {          
            double currentPrices = double.Parse(Console.ReadLine());
            double div = Proc(last, currentPrices);
            bool isSignificantDifference = CheckingForDifference(div, range);
            Console.WriteLine(GetUpdatedPrices(currentPrices, last, div, isSignificantDifference));
            last = currentPrices;          
        } 
    }

    private static string GetUpdatedPrices(double current, double last, double difference, bool etherTrueOrFalse)
    {
        string to = "";
        if (difference == 0)
        {
            to = string.Format("NO CHANGE: {0}", current);
        }
        else if (!etherTrueOrFalse)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, current, (difference * 100));
        }
        else if (etherTrueOrFalse && (difference > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, current, (difference * 100));
        }
        else if (etherTrueOrFalse && (difference < 0))
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, current, (difference * 100));
        return to;
    }

    private static bool CheckingForDifference(double range, double isDiff)
    {
        if (Math.Abs(range) >= isDiff)
        {
            return true;
        }
        return false;
    }
    
    private static double Proc(double last, double current)
    {
        double r = (current - last) / last;
        return r;
    }
}

