using System;

namespace SetValue
{
    class GetSet
    {

        int i;
        public void setValue(int i)
        {

            this.i = i;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nIn setValue(); ");
        }
        public int getValue()
        {
            return i;
        }
    }
}