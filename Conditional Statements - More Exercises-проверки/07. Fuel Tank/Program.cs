using System;

namespace _07._Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine().ToLowerusing System;

namespace _07._Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine().ToLower();
            int litres = int.Parse(Console.ReadLine());

            if (fuel == "diesel" || fuel == "gasoline" || fuel == "gas")
            {
                if (litres >= 25)
                {
                    Console.WriteLine($"You have enough {fuel}.");
                }

                else
                {
                    Console.WriteLine($"Fill your tank with { fuel }!");



                }
                
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }




        }
    }
}
();
            int litres = int.Parse(Console.ReadLine());

            if (fuel == "diesel" || fuel == "gasoline" || fuel == "gas")
            {
                if (litres >= 25)
                {
                    Console.WriteLine($"You have enough {fuel}.");
                }

                else
                {
                    Console.WriteLine($"Fill your tank with { fuel }!");



                }
                
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }




        }
    }
}
