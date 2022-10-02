using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lilyAge = int.Parse(Console.ReadLine());
            double priceWashMachine = double.Parse(Console.ReadLine());
            int priceForOneToy = int.Parse(Console.ReadLine());

            int toys = 0;
            double money = 0;

            double allMoney = 0;

            for(int i = 1; i <= lilyAge; i++)
            {
                if(i % 2 == 0)
                {
                    money += i * 5 - 1; 
                }
                else if(i % 2 != 0)
                {
                    money += priceForOneToy;
                }
            }

            

            if (money >= priceWashMachine)
            {
                Console.WriteLine($"Yes! {money - priceWashMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWashMachine - money:f2}");
            }






        }
    }
}
