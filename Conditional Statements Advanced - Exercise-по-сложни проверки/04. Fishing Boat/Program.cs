using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budgete = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            double price = 0.0;
            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                    price = 4200;
                    break;
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                break;

                   
            }


           if(num <= 6)
            {
                price = price * 0.9;
            }
           else if (num <= 11)
            {
                price = price * 0.85;
            }
           else
            {
                price = price * 0.75;
            }


            double odd = num % 2;
            
           if(odd == 0 && season != "Autumn")
            {
                price = price * 0.95;
            }

           if(budgete >= price)
            {
                Console.WriteLine($"Yes! You have {budgete-price:f2} leva left.");
            }
           else
            {
                Console.WriteLine($"Not enough money! You need {price-budgete:f2} leva.");
            }


        }
    }
}
