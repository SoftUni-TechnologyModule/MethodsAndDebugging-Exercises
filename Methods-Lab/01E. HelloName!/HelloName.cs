using System;
class HelloName
{
    static void Main()
    {
        string name = Console.ReadLine();

        PrintName(name);
    }

    static void PrintName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
}

