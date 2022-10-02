using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameSeries = Console.ReadLine();
            int seriesTime = int.Parse(Console.ReadLine());
            int lunchBreak = int.Parse(Console.ReadLine());


            double timeForSeries = lunchBreak * 5 / 8.0;

            //bool isEnought = ;
            if(timeForSeries >= seriesTime)
            {
                Console.WriteLine($"You have enough time to watch {nameSeries} and left with {Math.Ceiling(timeForSeries- seriesTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {nameSeries}, you need {Math.Ceiling(seriesTime - timeForSeries)} more minutes.");
            }

        }
    }
}
