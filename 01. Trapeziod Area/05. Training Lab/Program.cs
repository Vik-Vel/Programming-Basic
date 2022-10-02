using System;

namespace _05._Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
  
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());


            double num = (h - 1) * 100 / 70;
            double row = (w * 100 / 120);
            double sum = Math.Floor(num) * Math.Floor(row) - 3; //закръгля надолу ; май без остатък

            Console.WriteLine(sum);
        }
    }
}
