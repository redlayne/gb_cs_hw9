public static class CustomLibClass
{

    public static void Break()
    {
        Console.WriteLine();
        Console.WriteLine(new string('*', 50));
        Console.WriteLine();
    }

    public static int Input(string inputmessage)
    {
        Console.Write(inputmessage);
        int output = Convert.ToInt32(Console.ReadLine());
        return output;
    }

    public static void Anykey()
    {
        Console.Write("\npress any key to continue...");
        Console.ReadKey();
        Console.WriteLine("\b"+ " ");

    }

    public static void Swap(ref int exchangeItem1, ref int exchangeItem2)
    {
        int tempExchange = 0;
        tempExchange = exchangeItem1;
        exchangeItem1 = exchangeItem2;
        exchangeItem2 = tempExchange;
    }
}