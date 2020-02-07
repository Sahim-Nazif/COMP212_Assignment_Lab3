using System;
using System.Diagnostics;
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
               
                    if (a ==-1)
                    {
                        Console.WriteLine("You have chosen to exit the application. Bye now ");
                        Console.ReadLine();
                        break;
                    }
                   else if (a == 0 || a < 0)
                    {
                        Console.WriteLine("The value which you have entered is not valid for division.. Please enter a value except zeor !");
                        continue;
                    }
                    Console.Write("\nPlease enter second number: ");
                    b = double.Parse(Console.ReadLine());

                    Thread addition = new Thread(new ThreadStart(Add));
                    Thread subtraction = new Thread(() => Subtract());
                    Thread multipication = new Thread(new ThreadStart(Multiply));
                    Thread division = new Thread(() => Divide());
                    Console.WriteLine("\nYour Input Calculation Results are");
                    Console.WriteLine("------------------------------------");
                    addition.Start();
                    subtraction.Start();
                    multipication.Start();
                    division.Start();
                    Console.ReadLine();

                  
                }
                catch (Exception)
                {
                    Console.WriteLine("Please Check Your Input !");
                }
            }
            
        }
        public static void Add()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Thread.Sleep(3000);
            result = a + b;
            Console.WriteLine("\nThe result of addition is :" + result);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds + " miliseconds elapsed to perform addition");

        }
        public static void Subtract()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Thread.Sleep(5000);
            result = a - b;
            Console.WriteLine("\nThe result of subtraction is :" + result);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds + " miliseconds elapsed to perform subtraction");

        }
        public static void Multiply()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Thread.Sleep(8000);
            result = a * b;
            Console.WriteLine("\nThe result of multipication is :" + result);
            stopwatch.Stop();
            
            Console.WriteLine(stopwatch.ElapsedMilliseconds + " miliseconds elapsed to perform multipication");

        }
        public static void Divide()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Thread.Sleep(11000);
            result = a / b;
            Console.WriteLine("\nThe result of division is :" + result);
            stopwatch.Stop();
            
            Console.WriteLine(stopwatch.ElapsedMilliseconds + " miliseconds elapsed to peform division");
            Console.WriteLine("\nEnd....");

        }
    }
}
