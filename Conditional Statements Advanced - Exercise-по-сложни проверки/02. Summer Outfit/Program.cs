using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degree = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            if (time == "Morning")
            {
                if (degree <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degree <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }

            }
            else if(time == "Afternoon")
            {
                if (degree <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degree <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else
            {
                if (degree <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degree <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }


            Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
        }
    }
}
