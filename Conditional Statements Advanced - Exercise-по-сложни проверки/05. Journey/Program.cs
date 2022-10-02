using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                if(season == "summer")
                {
                    Console.WriteLine($"Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {budget*0.3:f2}");

                }
                else
                {
                    Console.WriteLine($"Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {budget * 0.7:f2}");
                }
            }

            else if(budget <= 1000)
            {
                if (season == "summer")
                {
                    Console.WriteLine($"Somewhere in Balkans");
                    Console.WriteLine($"Camp - {budget * 0.4:f2}");

                }
                else
                {
                    Console.WriteLine($"Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {budget * 0.8:f2}");
                }
            }

            else
            {
                Console.WriteLine($"Somewhere in Europe");
                Console.WriteLine($"Hotel - {budget * 0.9:f2}");
            }



        }
    }
}
