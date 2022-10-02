using System;

namespace _04._Easter_EggsBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numEggsFirstGamer = int.Parse(Console.ReadLine());
            int numEggsSecondGamer = int.Parse(Console.ReadLine());

            int counterEggsF = numEggsFirstGamer;
            int counterEggsS = numEggsSecondGamer;
            string input = Console.ReadLine();

            while (input != "End")
            {
               

                if(input == "one")
                {
                    
                    counterEggsS = counterEggsS - 1;
                }
                else
                {
                    
                   counterEggsF = counterEggsF - 1;
                }
                if(counterEggsF == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {counterEggsS} eggs left.");
                    break;
                }
                else if (counterEggsS == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {counterEggsF} eggs left.");
                    break;
                }
                input = Console.ReadLine();

            }
            if(input == "End")
            {
                Console.WriteLine($"Player one has {counterEggsF} eggs left.");
                Console.WriteLine($"Player two has {counterEggsS} eggs left.");
            }
        }
    }
}
