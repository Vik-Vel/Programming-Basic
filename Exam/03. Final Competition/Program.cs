using System;

namespace _03._Final_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numDansers = int.Parse(Console.ReadLine());
            double numPoints = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            double prize = 0;
            double cost = 0;
            double donation = 0;
            if(season == "summer")
            {
                if(place == "Bulgaria")
                {
                    prize = numPoints * numDansers;
                    cost = prize * 0.05;

                }
                else
                {
                    prize = numPoints * numDansers;
                    prize = prize + (prize * 0.5);
                    cost = prize * 0.1;

                }
            }

            if (season == "winter")
            {
                if (place == "Bulgaria")
                {
                    prize = numPoints * numDansers;
                    cost = prize * 0.08;
                }
                else
                {
                    prize = numPoints * numDansers;
                    prize = prize + (prize * 0.5);
                    cost = prize * 0.15;

                }
            }
            prize = prize - cost;
            donation = prize * 0.75;

            double left = prize - donation;


            Console.WriteLine($"Charity - {donation:f2}");
            Console.WriteLine($"Money per dancer - {left/numDansers:f2}");
        }
    }
}
