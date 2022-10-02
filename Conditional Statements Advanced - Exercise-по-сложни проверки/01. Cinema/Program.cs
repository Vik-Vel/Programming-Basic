using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double income = 0.0;

            if(projection == "Premiere")
            {
                income = (r * c) * 12.00;
            }
            else if (projection == "Normal")
            {
                income = (r * c) * 7.50;
            }
            else
            {
                income = (r * c) * 5.00;
            }

            Console.WriteLine($"{income:f2} leva");
        }
    }
}
