//Find e to the Nth Digit** - Just like the previous problem, but with e instead of PI. Enter a number and have the program generate e up to that many decimal places. Keep a limit to how far the program will go.
using System;
using System.Text.RegularExpressions;


namespace e_to_the_nth_digit
{
    public class Program
    {
        private static double m;

        static void Main(string[] args)
        {
            string input;

            do
            {
                Console.WriteLine("finding eulers number to the nth digit");
                Console.WriteLine("please enter a number of digits that you would like to find e to....");

                input = Console.ReadLine();
            }
            while (!(Regex.IsMatch(input, @"^\d+$")));

            Console.WriteLine(CalculatePi(input));

        }

        static double CalculatePi(string input)
        {
            int places = int.Parse(input);
            if (places > 15)
            {
                places = 15;
            }
            double irregular = 1d / 60d;
            double e = Math.Pow(1d + irregular, 60d);
            

            return Math.Round(e, places);
        }
    }
}