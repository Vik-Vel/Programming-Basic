using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyForTrip = double.Parse(Console.ReadLine());
            double moneyNow = double.Parse(Console.ReadLine());
            double sum = 0;
            string spenSave = "";
            double savedMoney = 0;
            int countDaysSpend = 0;
            int countDaySave = 0;

            while(moneyForTrip > moneyNow)
            {
                spenSave = Console.ReadLine();
                sum = double.Parse(Console.ReadLine());
                countDaySave++;
                if (spenSave == "spend")
                {
                    countDaySave = 0;
                    countDaysSpend++;
                    if(sum >= moneyNow)
                    {
                       moneyNow = 0;
                    }
                    else
                    {
                        moneyNow = moneyNow - sum;
                    }
                    if(countDaysSpend == 5)
                    {
                        
                        Console.WriteLine("You can't save the money");
                        Console.WriteLine(countDaysSpend);
                        break;
                    }
                }
                if (spenSave == "save")
                {
                    moneyNow += sum;
                }
                


                spenSave = Console.ReadLine();
                sum = double.Parse(Console.ReadLine());

            }

            
                Console.WriteLine($"You saved the money for {countDaySave} days.");


            //   double moneyNeed = double.Parse(Console.ReadLine());
            //   double moneyNow = double.Parse(Console.ReadLine());

            //    string spendOrSave = "";
            //    double money = 0;

            //    int daysCount = 0; //izminali dni
            //    int spendCount = 0; // poredni dni w koito harchi

            //    while (moneyNow < moneyNeed) 
            //    {
            //        spendOrSave = Console.ReadLine(); 
            //        money = double.Parse(Console.ReadLine());
            //        daysCount++;

            //        if(spendOrSave == "save")
            //        {
            //            moneyNow += money;
            //            spendCount = 0;
            //        }
            //        else
            //        {
            //            moneyNow -= money;
            //            if(moneyNow < 0)
            //            {
            //                moneyNow = 0;
            //            }

            //            spendCount++;

            //            if(spendCount == 5)
            //            {
            //                Console.WriteLine($"You can't save the money.");
            //                Console.WriteLine($"{daysCount}");
            //                break;
            //            }

            //        }


            //    }
            //    if(moneyNow >= moneyNeed)
            //    {
            //        Console.WriteLine($"You saved the money for {daysCount} days.");
            //    }

        }
    }
}
