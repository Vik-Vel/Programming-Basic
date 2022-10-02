using System;

namespace _04._Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            // broi km
            int n = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();


            double price = 0;

            double taxiRate = 0;

            if (dayOrNight == "day")
            {
                taxiRate = 0.79;
            }
            else
            {
                taxiRate = 0.90;
            }

            if (n < 20)
            {
                price = 0.70 + n * taxiRate; ;
            }
            else if ( n < 100)
            {
                price = n * 0.09;
            }
            else
            {
                price = n * 0.06;
            }

            Console.WriteLine("{0:f2}", price);


        }
    }
}
