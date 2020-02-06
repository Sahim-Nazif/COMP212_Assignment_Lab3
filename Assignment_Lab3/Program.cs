using System;
using System.Threading;

namespace Assignment_Lab3
{
    class Program
    {
        //creating local variables
        public static double a;
        public static double b;
        public static double result;
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Nazif Sahim Multi Threading Calculator");
            Console.WriteLine("---------------------------------------------------");

            while (a != -1)
            {
                try
                {
                    Console.WriteLine("\nPlease enter first number or -1 to discontinue: ");
                    a = double.Parse(Console.ReadLine());
                    if (a == 0)
                    {

                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please Check Your Input !");
                }
            }
            
        }
    }

    public static void Add()
    {
        Thread.Sleep(3000);

    }
    public static void Subtract()
    {

    }
    public static void Multiply()
    {

    }
    public static void Divide()
    {

    }
}
