using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int time = first + second + third;

            int min = time / 60; //75/60 => 1
            int sec = time % 60; //75%60 => 15

            if(sec < 10)
            {
                Console.WriteLine($"{min}:0{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:{sec}");

            }

        }
    }
}
