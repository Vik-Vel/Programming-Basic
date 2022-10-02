using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int sizeOfAp = w * l * h;
            string input = Console.ReadLine();
            int size = 0;

            while(input != "Done")
            {
                size += int.Parse(input);

                if(size >= sizeOfAp)
                {
                    break;
                }
                 
                input = Console.ReadLine();

            }

            int diff = sizeOfAp - size;

            if(diff >= 0)
            {
                Console.WriteLine($"{diff} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(size-sizeOfAp)} Cubic meters more.");
            }



        }
    }
}
