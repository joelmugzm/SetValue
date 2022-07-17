class ShowTime
{
    public static void PrintTime()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n\nIn PrintTime(); ");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("\n\nCurrent Date and Time is : ");
        DateTime now = DateTime.Now;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(now);
        Console.ReadLine();
    }

}