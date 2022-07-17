using SetValue;
class DisplayTheInfoInMain
{
    public static void PrintToScreen()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n\nIn PrintToScreen(); ");
        GetSet GetSet = new GetSet();
        GetSet.setValue(10000);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\t\t[ ");
        Console.Write(GetSet.getValue().ToString());
        Console.WriteLine(" ]");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
    }
}
