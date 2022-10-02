using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {

            double movieBuget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double priceForClothes = double.Parse(Console.ReadLine());

            double dekor = movieBuget * 0.1;

            double priceForAllClothes = people * priceForClothes;

            
            if (people > 150)
            {
                priceForAllClothes = priceForAllClothes - (priceForAllClothes * 0.1);

            }

            double neededMoney = priceForAllClothes + dekor;

            double difference = movieBuget - neededMoney;

            if (difference >= 0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:f2} leva left.");

            }  
                else 
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs (difference) :f2} leva more."); //НЕ ВРЪЩА ОТРИЦАТЕЛНО ЧИСЛО, А НОРМАЛНО

            }
        }
    }
}
