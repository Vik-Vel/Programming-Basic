using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();

            double price = 0.0;
            if(days < 10)
            {
                if (room == "room for one person")
                {
                    price = 18.0 * (days - 1);
                }
                else if (room == "apartment")
                {
                    price = 25.0 * (days - 1);
                    price = price * 0.70;
                }
                else if (room == "president apartment")
                {
                    price = 35.0 * (days - 1);
                    price = price * 0.90;
                }

            }
            else if(days <= 15)
            {
                if (room == "room for one person")
                {
                    price = 18.0 * (days - 1);
                   
                }
                else if (room == "apartment")
                {
                    price = 25.0 * (days - 1);
                    price = price * 0.65;
                }
                else if (room == "president apartment")
                {
                    price = 35.0 * (days - 1);
                    price = price * 0.85;
                }
            }
            else 
            {
                if (room == "room for one person")
                {
                    price = 18.0 * (days - 1);

                }
                else if (room == "apartment")
                {
                    price = 25.0 * (days - 1);
                    price = price * 0.50;
                }
                else if (room == "president apartment")
                {
                    price = 35.0 * (days - 1);
                    price = price * 0.80;
                }
            }

            if(rating == "positive")
            {
                price = price + (price * 0.25);
            }
            else
            {
                price = price * 0.90;
            }


            Console.WriteLine($"{price:f2}");
        }
    }
}
