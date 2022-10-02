using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {




            //Бюджетът на Петър -реално число в интервала[0.0…100000.0]
            double budget = double.Parse(Console.ReadLine());
            //Броят видеокарти - цяло число в интервала[0…100]
            int videoCards = int.Parse(Console.ReadLine());
            //3.Броят процесори - цяло число в интервала[0…100]
            int processors = int.Parse(Console.ReadLine());
            //4.Броят рам памет -цяло число в интервала[0…100]
            int ram = int.Parse(Console.ReadLine());



            // Петър иска да купи N видеокарти, M процесора и P на брой рам памет.
            // Ако броя на видеокартите е по-голям от този на процесорите получава
            // 15 % отстъпка от крайната сметка.Важат следните цени:

            //Видеокарта – 250 лв./ бр.
            double videoCardPrice = 250;
            double videoCardSum = videoCards * videoCardPrice;
            // Процесор – 35 % от цената на закупените видеокарти/ бр.
            double processorsPrice = videoCardSum * 0.35;
            double processorsSum = processors * processorsPrice;
            // Рам памет – 10 % от цената на закупените видеокарти/ бр.
            double ramPrice = videoCardSum * 0.10;
            double ramSum = ram * ramPrice;

            //Да се изчисли нужната сума за закупуване на материалите и да се пресметне дали бюджета ще му стигне.

            double totalSum = processorsSum + videoCardSum + ramSum;

            bool isCardsMoreProcessors = videoCards > processors;

            if (isCardsMoreProcessors)
            {
                totalSum = totalSum * 0.85;
            }
            double difference = budget - totalSum;

            bool isBudgetEnought = budget >= totalSum;
             if(isBudgetEnought)
            {
                Console.WriteLine($"You have {difference :f2} leva left!");
            }
             else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference):f2} leva more!");
            }




            //double peterBudget = double.Parse(Console.ReadLine());
            //int videocart = int.Parse(Console.ReadLine());
            //int procesor = int.Parse(Console.ReadLine());
            //int ram = int.Parse(Console.ReadLine());

            //double videocartPrice = 250;
            //double videocartSum = videocart * videocartPrice;

            //double procesorPrice = videocartSum * 0.35;
            //double procesorSum = procesor * procesorPrice;

            //double ramPrice = videocartSum * 0.10;
            //double ramSum = ram * ramPrice;


            //double totalPrice = videocartSum + procesorSum + ramSum;

            //if (videocartSum > procesorSum)
            //{
            //    totalPrice = totalPrice * 0.85;
            //}

            //if (peterBudget >= totalPrice)
            //{
            //    Console.WriteLine($"You have { (peterBudget - totalPrice):f2} leva left!");
            //}
            //else
            //{
            //    Console.WriteLine($"Not enough money! You need {Math.Abs(totalPrice - peterBudget):f2} leva more!");
            //}

            ////Console.WriteLine(totalPrice);

        }
    }
}
