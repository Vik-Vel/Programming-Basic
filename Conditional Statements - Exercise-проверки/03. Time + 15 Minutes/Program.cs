using System;

namespace _03._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrs = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            min = min + (hrs * 60);

           int minAfter15Min = min + 15;

            

            int hAfter = minAfter15Min / 60;
            int mAfter = minAfter15Min % 60;

            if (hAfter > 23)
            {
                //hrs = hrs - 24;
                hAfter = 0;

            }

             if (mAfter < 10)
            {
                Console.WriteLine($"{hAfter}:0{mAfter}");

            }
            
            else
            {
                Console.WriteLine($"{hAfter}:{mAfter}");

            }
        }
    }
}
