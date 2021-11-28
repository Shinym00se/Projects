
using System;
using System.Text.RegularExpressions;

namespace CostOfTile
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool imp = false;
            string inputunit;
            string inputarea;
            string inputcost;
            string inputwidth;
            string inputlength;
            do
            {
                Console.WriteLine("Do you wish this to be in imperial units? (y/n");
                inputunit = Console.ReadLine();
            } while (!(Regex.IsMatch(inputunit, @"[yYnN]")));

            if(inputunit.ToLower() == "y")
            {
                imp = true;
            }
            
            do
            {
                Console.WriteLine("please enter the area you wish to tile. ex: 100.00");
                inputarea = Console.ReadLine();
            } while (!(Regex.IsMatch(inputarea, @"\d+(\.\d\d)?")));

            do
            {
                Console.WriteLine("please enter the Cost per tile. ex:1.00");
                inputcost = Console.ReadLine();
            } while (!(Regex.IsMatch(inputcost, @"\d+\.\d\d")));
            do
            {
                Console.WriteLine("please enter the width of the tile.");
                inputwidth = Console.ReadLine();
                Console.WriteLine("please enter the length of the tile.");
                inputlength = Console.ReadLine();
            } while (!(Regex.IsMatch(inputwidth, @"\d+")));

            Tile tile = new Tile(int.Parse(inputwidth), int.Parse(inputlength));

            double tilesPerArea = double.Parse(inputarea) / tile.Area(imp);

            double tileCost = (double.Parse(inputcost) * (tilesPerArea + tilesPerArea * .10));

            Console.WriteLine($"assuming 10 percent waste, the total cost of tiles will be {tileCost}.");

        }
    }

    class Tile
    {
        public int X
        { get; set; }
        public int Y
        { get; set; }


        public Tile (int x, int y)
        {
            this.X = x; 
            this.Y = y;
        }
        public double Area(bool imperial)
        {
            if (imperial)
            {
                return X * Y / 2.54d;
            }
            else
            {
                return Y * X;
            }
        }   
    }
}
