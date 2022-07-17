using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Declaring_Method
{
    class Program
    {
        string name, city;
        int age;

        public void acceptdetails()
        {
            Console.Write("\nEnter your name:\t");
            name = Console.ReadLine();

            Console.Write("\nEnter Your City:\t");
            city = Console.ReadLine();

            Console.Write("\nEnter your age:\t\t");
            age = Convert.ToInt32(Console.ReadLine());
        }

        public void printdetails()
        {
            Console.Write("\n\n====================");
            Console.Write("\nName:\t" + name);
            Console.Write("\nCity:\t" + city);
            Console.Write("\nAge:\t" + age);
            Console.Write("\n====================\n");
        }

        static void Main(string[] args)
        {
            //creating object of class Program
            Program p = new Program();
            p.acceptdetails(); // Calling method
            p.printdetails(); // Calling method
            Console.ReadLine();
        }
    }
}