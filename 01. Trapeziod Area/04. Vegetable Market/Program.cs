using System;

namespace _04._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double kgVeg = double.Parse(Console.ReadLine());
            double kgFru = double.Parse(Console.ReadLine());
            int allKgVeg = int.Parse(Console.ReadLine());
            int allKgFru = int.Parse(Console.ReadLine());

            double priceVeg = kgVeg * allKgVeg;
            double priceFru = kgFru * allKgFru;

            double total = (priceVeg + priceFru) / 1.94;


            Console.WriteLine("{0:f2}", total);
        }
    }
}
