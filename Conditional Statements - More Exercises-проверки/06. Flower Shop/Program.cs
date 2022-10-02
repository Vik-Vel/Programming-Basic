using System;

namespace _06._Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolias = int.Parse(Console.ReadLine());
            int hyacinth = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int cactus = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double magnoliasPrice = magnolias * 3.25;
            double hyacinthPrice = hyacinth * 4;
            double rosePrice = rose * 3.50;
            double cactusPrice = cactus * 8;


            double moneyAll = magnoliasPrice + hyacinthPrice + rosePrice + cactusPrice;
            double danak = moneyAll * 0.05;

            double cleanMoney = moneyAll - danak;

            double neDostatuchni = giftPrice - cleanMoney;

            if (cleanMoney >= giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(cleanMoney - giftPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(neDostatuchni)} leva.");
            }


        }
    }
}


