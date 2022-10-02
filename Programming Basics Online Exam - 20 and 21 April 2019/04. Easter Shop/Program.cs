using System;

namespace _04._Easter_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int colEggInStore = int.Parse(Console.ReadLine());
            string buyOrFill = Console.ReadLine();
            int eggBuyOrFill = 0;

            int available = colEggInStore;
            int soldEgg = 0;
            while(buyOrFill != "Close")
            {
                eggBuyOrFill = int.Parse(Console.ReadLine());

              
                if (buyOrFill == "Buy" )
                {
                    if (available < eggBuyOrFill)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {available}.");
                        break;
                    }
                    available = available - eggBuyOrFill;
                    soldEgg = soldEgg + eggBuyOrFill;

                    
                }

                else if (buyOrFill == "Fill")
                {
                    available = available + eggBuyOrFill;
                }





                buyOrFill = Console.ReadLine();
                 

            }
            if (buyOrFill == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{soldEgg} eggs sold.");
            }



        }
    }
}
