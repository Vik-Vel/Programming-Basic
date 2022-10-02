using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double travel = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears= int.Parse(Console.ReadLine());
            int minions= int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double puzzlePrice = puzzles * 2.60;
            double dollsPrice = dolls * 3;
            double bearsPrice = bears * 4.10;
            double minionsPrice = minions * 8.20;
            double truckPrice = trucks * 2;

            double price = puzzlePrice + dollsPrice + bearsPrice + minionsPrice + truckPrice;
            double allTolls = puzzles + dolls + bears + minions + trucks;

            if(allTolls >= 50)
            {
                price = price - (price * 0.25);
                price = price - (price * 0.10);
            }

            else
            {
                price = price - (price * 0.10);

            }

            if(price >= travel)
            {
                Console.WriteLine($"Yes! {price - travel :f2} lv left.");
            }

            else
            {
                Console.WriteLine($"Not enought money! {travel - price:f2} lv needed.");

            }
















            //double travel = double.Parse(Console.ReadLine());
            //int puzzle = int.Parse(Console.ReadLine());
            //int doll = int.Parse(Console.ReadLine());
            //int bear = int.Parse(Console.ReadLine());
            //int minion = int.Parse(Console.ReadLine());
            //int truck = int.Parse(Console.ReadLine());


            //double puzzlePrice = puzzle * 2.60;
            //double dollPrice = doll * 3;
            //double bearPrice = bear * 4.10;
            //double minionPrice = minion * 8.20;
            //double truckPrice = truck * 2;




            //double allPurch = puzzle + doll + bear + minion + truck;
            //double allPurchPrice = puzzlePrice + dollPrice + bearPrice + minionPrice + truckPrice;

            //if ( allPurch > 50)
            //{
            //    allPurchPrice = allPurchPrice - (allPurchPrice * 0.25);
            //    allPurchPrice = allPurchPrice - (allPurchPrice * 0.10);
            //}
            //else
            //{
            //    allPurchPrice = allPurchPrice - (allPurchPrice * 0.10);

            //}


            //if (allPurchPrice >= travel)
            //{
            //    Console.WriteLine($"Yes!{allPurchPrice - travel:f2}lv left");
            //}

            //else
            //{
            //    Console.WriteLine($"Not enought money!{travel - allPurchPrice:f2}lv left");

            //}
        }
    }
}
