using System;

namespace _02._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int rest = int.Parse(Console.ReadLine());

            double workDays = 365 - rest;
            double playWorkDays = workDays * 63;

            double playRestDays = rest * 127;

            double realMinYears = playWorkDays + playRestDays;

            double difrrr = realMinYears - 30000;
            double h = difrrr / 60;
            double m = difrrr % 60;

            double diffr = 30000 - realMinYears;

            double hh = diffr / 60;
            double mm = diffr % 60;
            if (30000 <= realMinYears)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Floor(h)} hours and {m} minutes more for play");

            }

            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Floor(hh)} hours and {mm} minutes less for play");

            }

           
        }
    }
}
