using System;

namespace _06._Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            //skumriq
            double skumria = double.Parse(Console.ReadLine());
            double caca = double.Parse(Console.ReadLine());
            double palamud = double.Parse(Console.ReadLine());
            double safrid = double.Parse(Console.ReadLine());
            int midi = int.Parse(Console.ReadLine());

            double pricePalamud = skumria + (skumria * 0.6);
            double totalPricePalamud = palamud * pricePalamud;
            double priceSafrid = caca + (caca * 0.8);
            double totalPriceSafrid = safrid * priceSafrid;
            double priceMidi = midi * 7.50;

            double total = totalPricePalamud + totalPriceSafrid + priceMidi;



            Console.WriteLine("{0:f2}", total);
        }
    }
}
