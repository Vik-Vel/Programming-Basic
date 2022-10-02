using System;

namespace _01._Easter_Bakery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceForFlour = double.Parse(Console.ReadLine());    
            double kgFlour = double.Parse(Console.ReadLine());
            double kgSugar = double.Parse(Console.ReadLine());
            int numEggShel = int.Parse(Console.ReadLine());
            int maya = int.Parse(Console.ReadLine());

            double priceShugar = priceForFlour * 0.75;
            double priceEggShell = priceForFlour * 1.10;
            double priceMaya = priceShugar * 0.20;

            double allPrice = (kgFlour * priceForFlour + kgSugar * priceShugar + numEggShel * priceEggShell + maya * priceMaya);

            Console.WriteLine($"{allPrice:f2}");
        }
    }
}
