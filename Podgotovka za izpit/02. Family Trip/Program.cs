using System;

namespace _02._Family_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budgete = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            double percentMoreExp = double.Parse(Console.ReadLine());

            double money = 0;

            if(nights > 7)
            {
                pricePerNight *= 0.95;
            }
            double moreExp = (percentMoreExp / 100) * budgete;

            money = pricePerNight * nights + moreExp;

           if(budgete >= money)
            {
                Console.WriteLine($"Ivanovi will be left with {budgete - money:f2} leva after vacation.");
            }
           else
            {
                Console.WriteLine($"{Math.Abs(budgete - money):f2} leva needed.");
            }
        }
    }
}
