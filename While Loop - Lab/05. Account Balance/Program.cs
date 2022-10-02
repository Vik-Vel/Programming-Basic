using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string moneyInput = Console.ReadLine();

            double allMoney = 0;

            while(moneyInput != "NoMoreMoney")
            {
                double moneyInpuNew = double.Parse(moneyInput);

                if(moneyInpuNew < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                allMoney += moneyInpuNew;
                Console.WriteLine($"Increase: {moneyInpuNew:f2}");
  
                moneyInput = Console.ReadLine();
            }
            Console.WriteLine($"Total: {allMoney:f2}");





           

















            //string money = Console.ReadLine();
            //double allMoney = 0;

            //while(money != "NoMoreMoney")
            //{
            //    double amount = double.Parse(money);

            //    if (amount < 0)
            //    {
            //        Console.WriteLine($"Invalid operation!");
            //        break;
            //    }  

            //        allMoney += amount;
            //    Console.WriteLine($"Increase: {amount:f2}");
            //    money = Console.ReadLine();
            //}
            //Console.WriteLine($"Total: {allMoney:f2}");


        }
    }
}
