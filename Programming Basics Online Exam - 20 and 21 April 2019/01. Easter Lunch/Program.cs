using System;

namespace _01._Easter_Lunch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numEasterBread = int.Parse(Console.ReadLine());    
            int numEggShell = int.Parse(Console.ReadLine());
            int kgCookies = int.Parse(Console.ReadLine());

            double easterBreadPrice = 3.20 * numEasterBread;
            double eggShellPrice = 4.35 *numEggShell ;
            double cookies = 5.40 * kgCookies;
            double paintForEgg = 0.15 * (numEggShell * 12);

            double allSum = easterBreadPrice + eggShellPrice + cookies + paintForEgg;
            Console.WriteLine($"{allSum:f2}");

        }
    }
}
