using System;

namespace _04._Food_for_Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numDays = int.Parse(Console.ReadLine());
            double quantityFood = double.Parse(Console.ReadLine());

            double quantityFoodDog = 0;
            double quantityFoodCat = 0; 
            double quantityCookies = 0;
            double quantityAllFood = 0;

            double quantityFoodDogInput = 0;
            double quantityFoodCatInput = 0;
            for (int i = 1; i <= numDays; i++)
            {
               quantityFoodDogInput =  double.Parse(Console.ReadLine());
               quantityFoodCatInput =  double.Parse(Console.ReadLine());

               
                
                if( i % 3 == 0)
                {

                    quantityCookies =  quantityCookies + ((quantityFoodCatInput + quantityFoodDogInput) * 0.1);
                }

                quantityFoodDog = quantityFoodDog + quantityFoodDogInput;
                quantityFoodCat = quantityFoodCat + quantityFoodCatInput;
            }
            quantityAllFood =  quantityFoodDog + quantityFoodCat;

            double percentEatenFood = (quantityAllFood / quantityFood) * 100;
            double percentEatenFoodDog = (quantityFoodDog / quantityAllFood) * 100;
            double percentEatenFoodCat = (quantityFoodCat / quantityAllFood) * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(quantityCookies)}gr.");
            Console.WriteLine($"{percentEatenFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentEatenFoodDog:f2}% eaten from the dog.");
            Console.WriteLine($"{percentEatenFoodCat:f2}% eaten from the cat.");

        }
    }
}
