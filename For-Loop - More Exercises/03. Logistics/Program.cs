using System;

namespace _03._Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cargo = int.Parse(Console.ReadLine());

            double minibus = 0;
            double truck = 0;
            double train = 0;
            double allTon = 0;

            double minibusP = 0;
            double truckP = 0;
            double trainP = 0;
            double averagePrice = 0;

            for(int i = 1; i <= cargo; i++)
            {
                int tonove = int.Parse(Console.ReadLine());
                allTon += tonove;

                if (tonove <= 3)
                {
                    minibus = minibus + tonove ;
                    minibusP = minibusP + tonove * 200;
                }
                else if (tonove <= 11)
                {
                    truck = truck + tonove;
                    truckP = truckP + tonove * 175;
                }
              
                else
                {
                    train = train + tonove;
                    trainP = trainP + tonove * 120;
                }
            }
            allTon = minibus + truck + train;
            averagePrice = (minibusP + truckP + trainP)/allTon;



            double percentCargoMinibus = minibus / allTon * 100;
            double percentCargoTruck = truck / allTon * 100;
            double percentCargoTrain = train / allTon * 100;


            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{percentCargoMinibus:f2}%");
            Console.WriteLine($"{percentCargoTruck:f2}%");
            Console.WriteLine($"{percentCargoTrain:f2}%");




        }
    }
}
