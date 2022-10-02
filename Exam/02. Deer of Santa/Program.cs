using System;

namespace _02._Deer_of_Santa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numDaysSantaGone = int.Parse(Console.ReadLine());
            int leftFoodInKG = int.Parse(Console.ReadLine());
            double foodPerDayForFirstDeer = double.Parse(Console.ReadLine());
            double foodPerDayForSecondtDeer = double.Parse(Console.ReadLine());
            double foodPerDayForThirdDeer = double.Parse(Console.ReadLine());

            double eatenFood = 0;

            double firstDeerEatenFood = numDaysSantaGone * foodPerDayForFirstDeer;
            double secondDeerEatenFood = numDaysSantaGone * foodPerDayForSecondtDeer;
            double thirdDeerEatenFood = numDaysSantaGone * foodPerDayForThirdDeer;

            eatenFood = firstDeerEatenFood + secondDeerEatenFood + thirdDeerEatenFood;

            if(eatenFood < leftFoodInKG)
            {
                Console.WriteLine($"{Math.Floor(leftFoodInKG - eatenFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(eatenFood - leftFoodInKG)} more kilos of food are needed.");
            }

        }
    }
}
