using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string kind  = Console.ReadLine();
            double resultOfSides = 0;

            if (kind == "square")
            {
                double side = double.Parse(Console.ReadLine());

                 resultOfSides = side * side;

            }

            else if (kind == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                 resultOfSides = a * b;

            }

            else if (kind == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                 resultOfSides = radius * radius * Math.PI;

            }

            else if (kind == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                 resultOfSides = a * b / 2;

            }


            Console.WriteLine($"{resultOfSides:f3}");


            // 2 ВАРИАНТ

            //if( kind == "square")
            //{
            //    double side = double.Parse(Console.ReadLine());

            //    double resultOfSides = side * side;

            //    Console.WriteLine($"{ resultOfSides: f3}");
            //}

            //else if( kind == "rectangle")
            //{
            //    double a = double.Parse(Console.ReadLine());
            //    double b = double.Parse(Console.ReadLine());

            //    double resultOfSides = a * b;

            //    Console.WriteLine($"{resultOfSides:f3}");
            //}

            //else if(kind == "circle")
            //{
            //    double radius = double.Parse(Console.ReadLine());

            //    double resultOfSides = radius * radius * Math.PI;

            //    Console.WriteLine($"{resultOfSides:f3}");
            //}

            //else if( kind == "triangle")
            //{
            //    double a = double.Parse(Console.ReadLine());
            //    double b = double.Parse(Console.ReadLine());

            //    double resultOfSides = a * b / 2;

            //    Console.WriteLine($"{resultOfSides:f3}");

            //}
        }
    }
}
