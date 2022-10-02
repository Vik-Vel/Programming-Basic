using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int w = int.Parse(Console.ReadLine());
          int h = int.Parse(Console.ReadLine());

            int size = w * h;
            int pieces = 0;

            string input = Console.ReadLine();

            while(input!= "STOP")
            {
                pieces += int.Parse(input);

                if (pieces > size) 
                {
                    break;
                }

                input = Console.ReadLine();
            }

            int diff = size - pieces;

            if (diff >= 0)
            {
                Console.WriteLine($"{diff} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(diff)} pieces more.");
            }



        }
    }
}
