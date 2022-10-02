using System;

namespace _05._Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodInKg = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine());

            double allFood = (dogFood + catFood + turtleFood / 1000.0)*days;

            if (foodInKg >= allFood)
            {
                Console.WriteLine($"{Math.Floor(foodInKg - allFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(allFood - foodInKg):f0} more kilos of food are needed.");
            }


        }
    }
}
