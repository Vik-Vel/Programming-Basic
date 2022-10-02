using System;

namespace _09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            int capacity = lenght * width * height;
            double capacityLiters = capacity * 0.001;
            double space = percentage * 0.01;
            double needLitres = capacityLiters * (1 - space);


            Console.WriteLine(needLitres);







        }
    }
}
