using System;

namespace _03._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y= double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int perspnal = int.Parse(Console.ReadLine());

            //double vineyard = x * 0.4;
            double vineyard = x * y;
            double vine = vineyard * 0.4 / 2.5;

            double ost = vine - z;
            bool isVineMore = vine >= z;

            if( vine < z)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(z-vine)} liters wine needed.");
            }
            if(vine >= z)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(vine) } liters.") ;
                Console.WriteLine($"{ost} liters left -> {Math.Ceiling(ost / perspnal)} liters per person.");

            }
            
           
        }
    }
}
