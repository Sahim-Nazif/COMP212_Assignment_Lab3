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
                    Console.Write("\nPlease enter first number or -1 to discontinue: ");
                    a = double.Parse(Console.ReadLine());
                    if (a == 0)
                    {
                        Console.WriteLine("The value which you have entered is not valid for division.. Please enter a value except zeor !");
                        continue;
                    }
                    if (a == -1)
                    {
                        Console.WriteLine("You have chose to exit the application. Bye now ");
                        Console.ReadLine();
                        break;
                    }
                    Console.Write("\nPlease enter second number: ");
                    b = double.Parse(Console.ReadLine());

                    Thread addition = new Thread(new ThreadStart(Add));
                    Thread subtraction = new Thread(() => Subtract());
                    Thread multipication = new Thread(new ThreadStart(Multiply));
                    Thread division = new Thread(() => Divide());
                    Console.WriteLine("\nYour Input Calculation Results are");
                    Console.WriteLine("------------------------------------");

                }
                catch (Exception)
                {
                    Console.WriteLine("Please Check Your Input !");
                }
            }
            
        }
        public static void Add()
        {
            Thread.Sleep(3000);
            result = a + b;
            Console.WriteLine("\nThe result of addition is :" + result);

        }
        public static void Subtract()
        {
            Thread.Sleep(5000);
            result = a - b;
            Console.WriteLine("\nThe result of subtraction is :" + result);

        }
        public static void Multiply()
        {
            Thread.Sleep(8000);
            result = a * b;
            Console.WriteLine("\nThe result of multipication is :" + result);

        }
        public static void Divide()
        {
            Thread.Sleep(11000);
            result = a + b;
            Console.WriteLine("\nThe result of division is :" + result);
            Console.WriteLine("\nEnd....");

        }
    }


}
