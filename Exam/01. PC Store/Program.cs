using System;

namespace _01._PC_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceDollerForProcesor = double.Parse(Console.ReadLine());
            double priceDollerForVideoCard = double.Parse(Console.ReadLine());
            double priceDollerForRam = double.Parse(Console.ReadLine());
            int numRam = int.Parse(Console.ReadLine());
            double percentOff = double.Parse(Console.ReadLine());

            double leva = 1.57;

            double priceLevaForProcesor = priceDollerForProcesor * leva ;
            double priceLevaForVideoCard = priceDollerForVideoCard * leva;
            double priceLevaForRam = priceDollerForRam * leva;


            double numRamLeva = priceLevaForRam * numRam;

            double priceForProcesorAfterOff = priceLevaForProcesor - (priceLevaForProcesor * percentOff);
            double priceForVideoCardAfterOff = priceLevaForVideoCard - (priceLevaForVideoCard * percentOff);

            double allMoneyNeed = priceForProcesorAfterOff + priceForVideoCardAfterOff + numRamLeva;

            Console.WriteLine($"Money needed - {allMoneyNeed:f2} leva.");
        }
    }
}
