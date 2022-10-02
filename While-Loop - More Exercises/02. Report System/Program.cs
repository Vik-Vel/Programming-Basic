using System;

namespace _02._Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            double cash = 0;
            double cart = 0;

            double allSumFromCSandCT = 0;
            int counter = 1;

            while (input != "End" || allSumFromCSandCT >= sum)
            {
                int sumNow = int.Parse(input);
             
                if (counter % 2 == 0) // s karta
                    {
                        if (sumNow < 10) //pod 10
                        {
                            Console.WriteLine($"Error in transaction!");
                        }
                        else
                        {
                            cart = cart + sumNow;
                            Console.WriteLine($"Product sold!");
                        }

                    }
                    else // v broi
                    {
                        if (sumNow > 100)
                        {
                            Console.WriteLine($"Error in transaction!");
                        }

                        else
                        {
                            cash = cash + sumNow;
                            Console.WriteLine($"Product sold!");
                        }

                    }
                allSumFromCSandCT = cash + cart;
                if(allSumFromCSandCT >= sum)
                {
                    break;
                }

                counter++;                   
                    input = Console.ReadLine();
                
                
            }

            if(allSumFromCSandCT >= sum)
            {
                Console.WriteLine($"Average CS: {cash/2:f2}");
                Console.WriteLine($"Average CC: {cart/2:f2}");

            }
            if(input == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }

        }
    }
}
