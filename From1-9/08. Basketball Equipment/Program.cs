using System;

namespace _08._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());

            double shoes = tax - (tax * 0.4);
            double outfit = shoes - (shoes * 0.2);
            double ball = 0.25 * outfit;
            double accessories = 0.20 * ball;
            double totalPrice = tax + shoes + outfit + ball + accessories;


            Console.WriteLine(totalPrice);
        }
    }
}
