using System;

namespace _02._Easter_Guests
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double numGuest = int.Parse(Console.ReadLine());
            int bugeteLubo = int.Parse(Console.ReadLine());

            int easterBread = 4;
            double egg = 0.45;

            double easterBreadNum = Math.Ceiling(numGuest / 3);
            double eggs = numGuest * 2 ;

            double all = easterBreadNum * 4 + eggs * 0.45;

            if(bugeteLubo >= all)
            {
                Console.WriteLine($"Lyubo bought {easterBreadNum} Easter bread and {eggs} eggs.");
                Console.WriteLine($"He has {bugeteLubo-all:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {all-bugeteLubo:f2} lv. more.");
            }
           
        }
    }
}
