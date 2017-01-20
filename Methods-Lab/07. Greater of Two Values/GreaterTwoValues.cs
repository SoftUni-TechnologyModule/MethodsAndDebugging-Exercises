using System;

class GreaterTwoValues
{
    static void Main()
    {
        var inputType = Console.ReadLine();

        if (inputType == "int")
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMaxNum(firstNum, secondNum));
        }
        else if (inputType == "char")
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            Console.WriteLine(GetMaxChar(firstChar, secondChar));
        }
        else
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            Console.WriteLine(GetMaxString(firstString, secondString));
        }
    }

    static string GetMaxString(string firstString, string secondString)
    {
        string maxString;
        if (firstString.CompareTo(secondString) >= 0)
            maxString = firstString;
        else
            maxString = secondString;

        return maxString;
    }

    static char GetMaxChar(char firstChar, char secondChar)
    {
        char maxChar;
        if (firstChar > secondChar)
            maxChar = firstChar;
        else
            maxChar = secondChar;

        return maxChar;
    }

    static int GetMaxNum(int firstNum, int secondNum)
    {
        return Math.Max(firstNum, secondNum);
    }
}

