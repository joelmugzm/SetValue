using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
//-----------------------------------//

// Setup a new repo in GitHub that is public.
namespace SetValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nIn Main(); ");
            //Set up the Logger
            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File(@"C:\dev\logs\SetValue.SeriLog.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

            //Start Logging I guess
            Log.Information("Program main started.");

            DisplayTheInfoInMain.PrintToScreen();

            ShowTime.PrintTime();

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}