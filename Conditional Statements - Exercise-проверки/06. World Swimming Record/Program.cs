using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double distanceInM = double.Parse(Console.ReadLine());
            double timeInSecFor1M = double.Parse(Console.ReadLine());

            double hasToSwimFor = distanceInM * timeInSecFor1M;

            double moreTime = (Math.Floor(distanceInM / 15) * 12.5);

            double ivansTime = hasToSwimFor + moreTime;

            double timeLeft =  recordInSec - ivansTime;

            if (ivansTime < recordInSec)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {(ivansTime):f2} seconds.");
            }

            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(timeLeft):f2} seconds slower.");
            }
            //Console.WriteLine(hasToSwimFor);
            //Console.WriteLine(moreTime);
            //Console.WriteLine(ivansTime);
        }
    }
}
