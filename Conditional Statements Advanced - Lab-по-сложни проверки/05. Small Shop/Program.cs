﻿using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //град   coffee   water   beer   sweets  peanuts
            //Sofia   0.50    0.80    1.20    1.45    1.60
            //Plovdiv 0.40    0.70    1.15    1.30    1.50
            //Varna   0.45    0.70    1.10    1.35    1.55

            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());

            double price = 0;

            switch (city)
            {
                case "Sofia":

                switch (product)
                    {
                        case "coffee":
                            price = qty * 0.50;
                            break;

                        case "water":
                            price = qty * 0.80;
                            break;

                        case "beer":
                            price = qty * 1.20;
                            break;

                        case "sweets":
                            price = qty * 1.45;
                            break;

                        case "peanuts":
                            price = qty * 1.60;
                            break;
                    }

                    break;

                case "Plovdiv":

                    switch (product)
                    {
                        case "coffee":
                            price = qty * 0.40;
                            break;

                        case "water":
                            price = qty * 0.70;
                            break;

                        case "beer":
                            price = qty * 1.15;
                            break;

                        case "sweets":
                            price = qty * 1.30;
                            break;

                        case "peanuts":
                            price = qty * 1.50;
                            break;
                    }

                    
                    break;

                case "Varna":


                    switch (product)
                    {
                        case "coffee":
                            price = qty * 0.45;
                            break;

                        case "water":
                            price = qty * 0.70;
                            break;

                        case "beer":
                            price = qty * 1.10;
                            break;

                        case "sweets":
                            price = qty * 1.35;
                            break;

                        case "peanuts":
                            price = qty * 1.55;
                            break;
                    }

                    
                    break;
            }

            Console.WriteLine(price);
        }
    }
}
