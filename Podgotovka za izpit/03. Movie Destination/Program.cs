using System;

namespace _03._Movie_Destination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budgete = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int numDay = int.Parse(Console.ReadLine());

            double priceForDay = 0;
            double moneyNeed = 0;

            switch(destination)
            {
                case "Dubai":
                    if(season == "Winter")
                    {
                        priceForDay = 45000;
                        
                    }
                    else
                    {
                        priceForDay = 40000;
                    }
                    break;

                case "Sofia":
                    if (season == "Winter")
                    {
                        priceForDay = 17000;

                    }
                    else
                    {
                        priceForDay = 12500;
                    }
                    break;

                case "London":
                    if (season == "Winter")
                    {
                        priceForDay = 24000;

                    }
                    else
                    {
                        priceForDay = 20250;
                    }
                    break;

                   
            }
            if (destination == "Dubai")
            {
                moneyNeed = priceForDay * numDay * 0.70;
            }
            else if (destination == "Sofia")
            {
                moneyNeed = priceForDay * numDay * 1.25;
            }
            else if(destination == "London")
            {
                moneyNeed = priceForDay * numDay;
            }

            
            if(moneyNeed <= budgete)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budgete - moneyNeed :f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {Math.Abs(budgete-moneyNeed):f2} leva more!");
            }
            
          



        }
    }
}
