// **Fibonacci Sequence** - Enter a number and have the program generate the Fibonacci sequence to that number or to the Nth number.
using System;
using System.Text.RegularExpressions;

namespace FibonacciRecursive
{
    public class Program
    {
        private static double m;

        static void Main(string[] args)
        {
            string input;

            do
            {
                Console.WriteLine("Printing the fobbonacci secuence");
                Console.WriteLine("please enter a number you wish to display the sequence of....");

                input = Console.ReadLine();
            }
            while (!(Regex.IsMatch(input, @"^\d+$")));
            int number = int.Parse(input);
            for(int i = 0; i < number; i++)
            {
                Console.WriteLine(fib(i));
            }
            

        }

        static double fib(int input)
        {
            if (input == 0|| input == 1) 
            { 
                return input; 
            }
            else
            {
                return fib(input - 1) + fib(input - 2);
            }
        }
    }
}