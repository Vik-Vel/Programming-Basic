using System;

namespace _04._Easter_Eggs_Battle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numEggFirst = int.Parse(Console.ReadLine());
            int numEggSecond = int.Parse(Console.ReadLine());
            string input = input = Console.ReadLine(); ;

            int counterFirstEgg = numEggFirst;
            int counterSecondEgg = numEggSecond;

            while(input != "End")
            {
                

                if(input == "one")
                {
                    counterSecondEgg--;


                }
                else
                {
                    counterFirstEgg--;
                }

                if(counterFirstEgg == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {counterSecondEgg} eggs left.");
                    break;
                }
                else if(counterSecondEgg == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {counterFirstEgg} eggs left.");
                    break;
                }
                input = Console.ReadLine();

            }
            if (input == "End")
            {
                Console.WriteLine($"Player one has {counterFirstEgg} eggs left.");
                Console.WriteLine($"Player two has {counterSecondEgg} eggs left.");
            }



        }
    }
}
