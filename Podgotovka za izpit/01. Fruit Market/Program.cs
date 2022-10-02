using System;

namespace _01._Fruit_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceStrawBerry = double.Parse(Console.ReadLine());
            double quantityBannanaKg = double.Parse(Console.ReadLine());
            double quantityOrangeKg = double.Parse(Console.ReadLine());
            double quantityRaspberryKg = double.Parse(Console.ReadLine());
            double quantityStrawberryKg = double.Parse(Console.ReadLine());


            double priceRasp = (priceStrawBerry / 2) ;
            double priceOrange = (priceRasp * 0.6)  ;
            double priceBan = (priceRasp * 0.2) ;
            

            double allMoneyNeeded = priceRasp *quantityRaspberryKg + priceOrange * quantityOrangeKg + priceBan * quantityBannanaKg + priceStrawBerry * quantityStrawberryKg;

            Console.WriteLine($"{allMoneyNeeded:f2}");


        }
    }
}
