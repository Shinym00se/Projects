//**Find PI to the Nth Digit** - Enter a number and have the program generate PI up to that many decimal places. Keep a limit to how far the program will go.

using System.Text.RegularExpressions;

namespace PI_to_the_nth_digit
{
    public class Class1
    {
        static void Main(string[] args)
        {
            string input;

            do
            {
                Console.WriteLine("finding pi to the nth digit");
                Console.WriteLine("please enter a number of digits that you would like to find pi to....");

                input = Console.ReadLine();
            }
            while (!(Regex.IsMatch(input, @"^\d+$")));

            Console.WriteLine(CalculatePi(input));

        }

        static double CalculatePi(string input)
        {
            int places = int.Parse(input);
            if(places > 30)
            {
                places = 30;
            }
            double pi = 16 * Math.Atan(1D / 5D) - 4 * Math.Atan(1D / 239D);
            return Math.Round(pi, places);
        }
    }
}