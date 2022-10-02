using System;

namespace _01._Back_To_The_Past
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int age = 17;

            //double moneyLeft = money;
            for(int i = 1800 ; i <= year; i++)
            {

                if (i % 2 == 0)
                {
                    age++;
                    money = money - 12000;

                }
                else
                {
                    age++;
                    money = money - (12000 + (50 * age)) ;
                }

            }
            if (money >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(money):f2} dollars to survive.");
            }
        }
    }
}
