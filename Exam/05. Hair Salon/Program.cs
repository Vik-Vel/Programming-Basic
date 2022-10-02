using System;

namespace _05._Hair_Salon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goal = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int mens = 15;
            int ladies = 20;
            int kids = 10;

            int touchUp = 20;
            int fullColor = 30;

            int moneyForTheDay = 0;

            while (input != "closed")
            {
                if (input == "haircut")
                {
                    input = Console.ReadLine();
                    if (input == "mens")
                    {
                        moneyForTheDay = moneyForTheDay + mens;
                    }

                    else if (input == "ladies")
                    {
                        moneyForTheDay = moneyForTheDay + ladies;

                    }
                    else if (input == "kids")
                    {
                        moneyForTheDay = moneyForTheDay + kids;

                    }
                }

                if (input == "color")
                {
                    input = Console.ReadLine();
                    if (input == "full color")
                    {
                        moneyForTheDay = moneyForTheDay + fullColor;
                       
                    }
                    else
                    {
                        moneyForTheDay = moneyForTheDay + touchUp;
                    }
                }

                if (moneyForTheDay >= goal)
                {
                    Console.WriteLine("You have reached your target for the day!");
                    Console.WriteLine($"Earned money: {moneyForTheDay}lv.");
                    break;
                }
                input = Console.ReadLine();
            }

            if (input == "closed")
            {
                Console.WriteLine($"Target not reached! You need {goal - moneyForTheDay}lv. more.");
                Console.WriteLine($"Earned money: {moneyForTheDay}lv.");
            }
                
            





        }
    }
}
