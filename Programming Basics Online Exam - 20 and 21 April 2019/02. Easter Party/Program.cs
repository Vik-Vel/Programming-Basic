using System;

namespace _02._Easter_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numGuest = int.Parse(Console.ReadLine());
            double priceCuvert = double.Parse(Console.ReadLine());
            double bugete = double.Parse(Console.ReadLine());
            double cake = bugete * 0.10;
            if (numGuest >= 10 && numGuest <= 15)
            {
                priceCuvert = priceCuvert * 0.85;

            }
            else if (numGuest > 15 && numGuest <=20)
            {
                priceCuvert *= 0.80;
            }
            else if(numGuest > 20)
            {
                priceCuvert *= 0.75;
            }

            double allPriceCuvert = (numGuest * priceCuvert) + cake;

            if(bugete >= allPriceCuvert)
            {
                Console.WriteLine($"It is party time! {bugete - allPriceCuvert:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! { allPriceCuvert - bugete:f2} leva needed.");
            }
        }
    }
}
