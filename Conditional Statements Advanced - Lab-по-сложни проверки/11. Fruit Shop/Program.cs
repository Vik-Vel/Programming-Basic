using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double num = double.Parse(Console.ReadLine());

            double totalPrice = 0;

           
            switch(day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch(fruit)
                    {
                        case "banana":
                            totalPrice = num * 2.50;
                            break;

                        case "apple":
                            totalPrice = num * 1.20;
                            break;

                        case "orange":
                            totalPrice = num * 0.85;
                            break;

                        case "grapefruit":
                            totalPrice = num * 1.45;
                            break;

                        case "kiwi":
                            totalPrice = num * 2.70;
                            break;

                        case "pineapple":
                            totalPrice = num * 5.50;
                            break;

                        case "grapes":
                            totalPrice = num * 3.85;
                            break;

                        default:
                            Console.WriteLine("error");
                            break;
                    }
                
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            totalPrice = num * 2.70;
                            break;

                        case "apple":
                            totalPrice = num * 1.25;
                            break;

                        case "orange":
                            totalPrice = num * 0.90;
                            break;

                        case "grapefruit":
                            totalPrice = num * 1.60;
                            break;

                        case "kiwi":
                            totalPrice = num * 3.00;
                            break;

                        case "pineapple":
                            totalPrice = num * 5.60;
                            break;

                        case "grapes":
                            totalPrice = num * 4.20;
                            break;

                            break;

                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            if (totalPrice > 0)
            {
                Console.WriteLine($"{totalPrice:f2}");
            }

        }
    }
}
