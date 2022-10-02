using System;

namespace _03._Painting_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string color = Console.ReadLine();
            int partid = int.Parse(Console.ReadLine());
            double money = 0;

            switch (size)
            {
                case "Large":

                    switch (color)
                    {
                        case "Red":
                            money = partid * 16;
                            break;

                        case "Green":
                            money = partid * 12;
                            break;

                        case "Yellow":
                            money = partid * 9;
                            break;
                    }
                    break;

                case "Medium":

                    switch (color)
                    {
                        case "Red":
                            money = partid * 13;
                            break;

                        case "Green":
                            money = partid * 9;
                            break;

                        case "Yellow":
                            money = partid * 7;
                            break;
                    }
                    break;

                case "Small":

                    switch (color)
                    {
                        case "Red":
                            money = partid * 9;
                            break;

                        case "Green":
                            money = partid * 8;
                            break;

                        case "Yellow":
                            money = partid * 5;
                            break;
                    }
                    break;

            }

            double cost = money * 0.35;
            Console.WriteLine($"{money - cost:f2} leva.");
            }
    }
}
