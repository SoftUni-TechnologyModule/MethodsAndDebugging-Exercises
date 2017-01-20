using System;
class BlankReceipt
{
    static void PrintReceipt()
    {
        PrintReceiptHeader();
        PrintReceiptBody();
        PrintReceiptFooter();
    }
    static void PrintReceiptHeader()
    {
        Console.WriteLine("CASH RECEIPT\n------------------------------");
    }
    static void PrintReceiptBody()
    {
        Console.WriteLine("Charged to____________________\nReceived by___________________");
    }
    static void PrintReceiptFooter()
    {
        Console.WriteLine("------------------------------\n\u00A9 SoftUni");
    }
    static void Main()
    {
        PrintReceipt();
    }
}

