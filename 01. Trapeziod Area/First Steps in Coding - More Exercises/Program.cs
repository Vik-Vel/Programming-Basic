using System;

namespace First_Steps_in_Coding___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double face = (b1 + b2) * h / 2;

            Console.WriteLine("{0:f2}", face); //закръгляне след 2рия знак

        }
    }
}
