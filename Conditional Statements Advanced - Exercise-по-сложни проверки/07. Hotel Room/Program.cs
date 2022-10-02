using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {

            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studio = 0.0;
            double apartment = 0.0;

            switch(month)
            {
                case "May":
                case "October":
                    
                    if (nights > 7 && nights <= 14)
                    {
                        studio = (50 * nights) * 0.95;
                        apartment = nights * 65 ;


                    }
                    else if (nights > 14)
                    {
                        studio = (50 * nights) * 0.70;
                        apartment = (65 * nights) * 0.90;

                    }
                    else
                    {
                        studio = 50 * nights;
                        apartment = 65 * nights ;
                    }
                    break;

                case "June":
                case "September":
                   
                     if (nights > 14)
                    {
                        studio = (75.20 * nights) * 0.80;
                        apartment = (68.70 * nights) * 0.90;
                    }
                     else
                    {
                        studio = 75.20 * nights;
                        apartment = 68.70 * nights;
                    }
                    break;


                case "July":
                case "August":
                    if (nights > 14)
                    {
                        studio = 76 * nights;
                        apartment = 77 * nights * 0.90;
                    }
                    else
                    {
                        studio = 76 * nights;
                        apartment = 77 * nights;
                    }
                    break;
            }

            Console.WriteLine($"Apartment: {apartment:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv.");
        }
    }
}
